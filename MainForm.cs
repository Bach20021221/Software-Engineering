// Copyright © 2020 Andrew Vardeman.  Published under the MIT license.
// See license.txt in the AzureMultiTranslator distribution or repository for the
// full text of the license.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leaf.xNet;
using Microsoft.CognitiveServices.Speech;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace AzureMultiTranslator
{
    public partial class MainForm : Form
    {
        const string APPNAME = "AzureMultiTranslator";

        private bool _everActivated = false;

        private Translator Translator { get; }

        private string SettingsDirPath { get; }

        private string SettingsPath { get; }

        private Settings Settings { get; }

        private List<TranslatedTextRow> BackingRows { get; } = new List<TranslatedTextRow>();

        public BindingList<TranslatedTextRow> Rows { get; }

        private Dictionary<string, Translation> translations;
        public MainForm()
        {
            InitializeComponent();
            LoadTranslations();
            InitializeComboBox();
            Rows = new BindingList<TranslatedTextRow>(BackingRows);

            SettingsDirPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), APPNAME);
            SettingsPath = Path.Combine(SettingsDirPath, "settings.json");
            if (File.Exists(SettingsPath))
            {
                try
                {
                    string json = File.ReadAllText(SettingsPath);
                    Settings = JsonConvert.DeserializeObject<Settings>(json);
                }
                catch (Exception)
                {
                }
            }
            if (Settings == null)
            {
                Settings = new Settings();
                Settings.WindowSize = this.Size;
                Settings.MainSplitContainerSplitterDistance = mainSplitContainer.SplitterDistance;
                Settings.TranslationsPaneSplitContainerSplitterDistance = translationsPaneSplitContainer.SplitterDistance;
                Settings.TranslationsTextBoxesSplitContainerSplitterDistance = translationsTextBoxesSplitContainer.SplitterDistance;
                Settings.Languages.Add("da");
                Settings.Languages.Add("de");
                Settings.Languages.Add("es");
                Settings.Languages.Add("fr");
                Settings.Languages.Add("hu");
                Settings.Languages.Add("nl");
                Settings.Languages.Add("ru");
            }
            int mainSplitContainerSplitterDistance =
                Settings.MainSplitContainerSplitterDistance;
            int translationsPaneSplitContainerSplitterDistance =
                Settings.TranslationsPaneSplitContainerSplitterDistance;
            int translationsTextBoxesSplitContainerSplitterDistance =
                Settings.TranslationsTextBoxesSplitContainerSplitterDistance;

            Point location = Settings.WindowLocation;
            if (location.X < 0)
            {
                location.X = 0;
            }
            if (location.Y < 0)
            {
                location.Y = 0;
            }
            Location = location;

            Size size = Settings.WindowSize;
            if (size.Width < 100)
            {
                size.Width = 100;
            }

            if (size.Height < 100)
            {
                size.Height = 100;
            }

            if (Settings.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            Activated += (s, e) =>
            {
                if (_everActivated)
                {
                    return;
                }
                _everActivated = true;
                if (WindowState != FormWindowState.Maximized)
                {
                    Size = size;
                }
                try
                {
                    mainSplitContainer.SplitterDistance =
                        mainSplitContainerSplitterDistance;
                }
                catch
                {
                    // NBD
                }
                try
                {
                    translationsPaneSplitContainer.SplitterDistance =
                        translationsPaneSplitContainerSplitterDistance;
                }
                catch
                {
                    // NBD
                }
                try
                {
                    translationsTextBoxesSplitContainer.SplitterDistance =
                        translationsTextBoxesSplitContainerSplitterDistance;
                }
                catch
                {
                    // NBD
                }
                Size = size;
            };

            foreach (string language in Settings.Languages)
            {
                Rows.Add(new TranslatedTextRow(language));
            }
            Rows.ListChanged += Rows_ListChanged;
            Settings.PropertyChanged += Settings_PropertyChanged;
            Translator = new Translator(Settings);
            translatedTextRowBindingSource.DataSource = Rows;
            SyncBackTranslateUI();
            FireBackTranslate();
        }
        public class Translation
        {
            public string Name { get; set; }
            public string NativeName { get; set; }
            public string Dir { get; set; }
        }

        public class LanguageTranslations
        {
            public Dictionary<string, Translation> Translation { get; set; }
        }
        private void LoadTranslations()
        {
            string url = "https://api.cognitive.microsofttranslator.com/languages?api-version=3.0";
            string jsonResponse;

            try
            {
                using (HttpRequest request = new HttpRequest())
                {
                    request.KeepAlive = false;
                    request.AddHeader(HttpHeader.Accept, "application/json");
                    request.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
                    request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, như Gecko) Chrome/75.0.3770.100 Safari/537.36";

                    jsonResponse = request.Get(url).ToString();
                }

                var languageTranslations = JsonConvert.DeserializeObject<LanguageTranslations>(jsonResponse);
                translations = languageTranslations.Translation;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching languages: {ex.Message}");
                return;
            }
        }
        private void InitializeComboBox()
        {

            ComboBoxLanguage.DisplayMember = "Value";
            ComboBoxLanguage.ValueMember = "Key";

            foreach (var translation in translations)
            {
                ComboBoxLanguage.Items.Add(new KeyValuePair<string, string>(translation.Key, translation.Value.Name));
            }

            ComboBoxLanguage.SelectedIndexChanged += ComboBoxLanguages_SelectedIndexChanged;

            ComboBoxLanguage2.DisplayMember = "Value";
            ComboBoxLanguage2.ValueMember = "Key";

            foreach (var translation in translations)
            {
                ComboBoxLanguage2.Items.Add(new KeyValuePair<string, string>(translation.Key, translation.Value.Name));
            }

            ComboBoxLanguage2.SelectedIndexChanged += ComboBoxLanguages_SelectedIndexChanged;
        }
        private void ComboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLanguage.SelectedItem != null)
            {
                var selectedLanguage = (KeyValuePair<string, string>)ComboBoxLanguage.SelectedItem;
                string languageCode = selectedLanguage.Key;
                string languageValue = selectedLanguage.Value;

                SettingsTools.Default.OutputLang = languageValue;
                SettingsTools.Default.Save();
            }
        }
        private async void Settings_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Settings.BackTranslate))
            {
                SyncBackTranslateUI();
                FireBackTranslate();
            }
            if (e.PropertyName == nameof(Settings.SubscriptionKey))
            {
                UpdateTranslateButton();
            }
            settingsTimer.Stop();
            settingsTimer.Start();
        }

        private void Rows_ListChanged(object sender, ListChangedEventArgs e)
        {
            Settings.Languages.Clear();
            foreach (string language in Rows.Select(r => r.Language))
            {
                Settings.Languages.Add(language);
            }
        }

        private void translationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column = translationGrid.Columns[e.ColumnIndex];
            if (column == copyTranslatedColumn || column == copyBackTranslatedColumn)
            {
                string text = Rows[e.RowIndex].TranslatedText;
                if (column == copyBackTranslatedColumn)
                {
                    text = Rows[e.RowIndex].BackTranslatedText;
                }
                if (string.IsNullOrEmpty(text))
                {
                    Clipboard.Clear();
                }
                else
                {
                    Clipboard.SetText(text);
                }
            }

            translatedTextBox.Text = "" + Rows[e.RowIndex].TranslatedText;
            backTranslatedTextBox.Text = "" + Rows[e.RowIndex].BackTranslatedText;

            if (column == deleteColumn)
            {
                DialogResult result = MessageBox.Show(
                   $"Remove language \"{Rows[e.RowIndex].Language}\"?", "Remove Language?",
                   MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            var selectedLanguage = (KeyValuePair<string, string>)ComboBoxLanguage.SelectedItem;
            string languageCode = selectedLanguage.Key;


            Rows.Add(new TranslatedTextRow(languageCode));

        }

        private async void translateButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            if (string.IsNullOrEmpty(sourceTextBox.Text))
            {
                MessageBox.Show("Chưa nhập Văn bản muốn dịch", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(ComboBoxLanguage2.Text))
            {
                MessageBox.Show("Chưa nhập ngôn ngữ của văn bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            List<TranslatedTextRow> rowsToTranslate = Rows.Where(r => r.Translate).ToList();
            if (rowsToTranslate.Count == 0)
            {
                MessageBox.Show("Chưa nhập ngôn ngữ muốn chuyển sang", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int length = sourceTextBox.Text.Length;
            int rowsPerCall = Math.Max(1, length > 0 ? (int)Math.Min(maxCharsUpDown.Value / length, rowsToTranslate.Count) : rowsToTranslate.Count);
            try
            {
                var selectedLanguage = (KeyValuePair<string, string>)ComboBoxLanguage2.SelectedItem;
                string languageCode = selectedLanguage.Key;



                for (int i = 0; i < rowsToTranslate.Count; i += rowsPerCall)
                {
                    List<TranslatedTextRow> rowsThisCall = rowsToTranslate.Skip(i).Take(rowsPerCall).ToList();


                    //await Translator.DetectLanguageAsync();

                    string[] languages = rowsThisCall.Select(r => r.Language).ToArray();
                    List<string> translations = await Translator.Translate(languageCode,
                        languages, sourceTextBox.Text, htmlCheckBox.Checked);
                    for (int j = 0; j < translations.Count; j++)
                    {
                        rowsThisCall[j].TranslatedText = translations[j];
                    }
                }

                await BackTranslate();
            }
            catch (AzureException ex)
            {
                ShowAzureException(ex);
            }
            catch (UnrecognizedResponseException ex)
            {
                ShowUnrecognizedResponseException(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Unknown exception: {ex.Message}");
            }

            if (translationGrid.SelectedRows.Count > 0)
            {
                translationGrid_CellContentClick(translationGrid,
                   new DataGridViewCellEventArgs(0, translationGrid.SelectedRows[0].Index));
            }

            Enabled = true;
        }

        private async void FireBackTranslate()
        {
            await BackTranslate();
        }

        private async Task BackTranslate()
        {
            bool savedEnabledState = Enabled;
            Enabled = false;
            foreach (TranslatedTextRow row in Rows.Where(r => r.Translate))
            {
                if (Settings.BackTranslate)
                {
                    if (string.IsNullOrEmpty(row.TranslatedText))
                    {
                        row.BackTranslatedText = string.Empty;
                    }
                    else if (row.TranslatedText.Length <= 5000)
                    {
                        try
                        {
                            var selectedLanguage = (KeyValuePair<string, string>)ComboBoxLanguage2.SelectedItem;
                            string languageCode = selectedLanguage.Key;
                            List<string> backTranslations =
                               await Translator.Translate(row.Language, new[] { languageCode },
                                  row.TranslatedText, htmlCheckBox.Checked);
                            row.BackTranslatedText = backTranslations[0];
                        }
                        catch (AzureException ex)
                        {
                            ShowAzureException(ex);
                        }
                        catch (UnrecognizedResponseException ex)
                        {
                            ShowUnrecognizedResponseException(ex);
                        }
                    }
                    else
                    {
                        row.BackTranslatedText = "Too long to back-translate";
                    }
                }
                else
                {
                    row.BackTranslatedText = "";
                }
            }
            Enabled = savedEnabledState;
        }

        private void ShowAzureException(AzureException ex)
        {
            MessageBox.Show(this, $"Azure error {ex.Code}: {ex.Message}");
        }

        private void ShowUnrecognizedResponseException(UnrecognizedResponseException ex)
        {
            MessageBox.Show(this, ex.Message);
        }

        private void SyncBackTranslateUI()
        {
            copyBackTranslatedColumn.Visible =
                backTranslatedTextDataGridViewTextBoxColumn.Visible = Settings.BackTranslate;
            translationsTextBoxesSplitContainer.Panel2Collapsed = !Settings.BackTranslate;
        }

        private void UpdateTranslateButton()
        {
            int length = sourceTextBox.Text.Length;
            translateButton.Enabled = length > 0 && length <= 5000;
        }

        private void englishTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTranslateButton();
            lengthTextBox.Text = sourceTextBox.Text.Length.ToString();
            if (translateButton.Enabled)
            {
                lengthTextBox.ForeColor = SystemColors.ControlText;
            }
            else
            {
                lengthTextBox.ForeColor = Color.Red;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            settingsBindingSource.DataSource = Settings;
            ComboBoxLanguage2.Text = SettingsTools.Default.InputLang;
            ComboBoxLanguage.Text = SettingsTools.Default.OutputLang;
        }

        private void settingsTimer_Tick(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Directory.CreateDirectory(SettingsDirPath);
            string subscriptionKey = Settings.SubscriptionKey;
            if (!Settings.SaveSubscriptionKey)
            {
                // temporarily blank this out to save if the user doesn't want it persisted
                Settings.SubscriptionKey = "";
            }
            string json = JsonConvert.SerializeObject(Settings);
            // restore the subscription key if it was blanked out
            Settings.SubscriptionKey = subscriptionKey;
            // kill the timer we just started by changing the settings
            settingsTimer.Stop();
            File.WriteAllText(SettingsPath, json);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void mainSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Settings.MainSplitContainerSplitterDistance = mainSplitContainer.SplitterDistance;
        }

        private void translationsPaneSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Settings.TranslationsPaneSplitContainerSplitterDistance = translationsPaneSplitContainer.SplitterDistance;
        }

        private void translationsTextBoxesSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Settings.TranslationsTextBoxesSplitContainerSplitterDistance = translationsTextBoxesSplitContainer.SplitterDistance;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (Settings != null)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    Settings.WindowSize = Size;
                }
                Settings.Maximized = (WindowState == FormWindowState.Maximized);
            }
        }

        private void addLanguageTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = addLanguageButton;
        }

        private void addLanguageTextBox_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            BackingRows.Sort((r1, r2) => r1.Language.CompareTo(r2.Language));
            Rows.ResetBindings();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            List<int> selectedIndices = GetSelectedIndices();
            if (selectedIndices.Count > 0)
            {
                int insertIndex = selectedIndices[0];
                if (insertIndex > 0)
                {
                    insertIndex--;
                }

                List<TranslatedTextRow> rows = GetRowsAtIndices(selectedIndices);
                BackingRows.RemoveAll(r => rows.Contains(r));
                ReinsertAndSelect(insertIndex, rows);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            List<int> selectedIndices = GetSelectedIndices();
            if (selectedIndices.Count > 0)
            {
                TranslatedTextRow rowToInsertAfter = null;
                int newIndex = selectedIndices.Last();
                if (newIndex < BackingRows.Count - 1)
                {
                    rowToInsertAfter = Rows[newIndex + 1];
                }
                List<TranslatedTextRow> rows = GetRowsAtIndices(selectedIndices);
                BackingRows.RemoveAll(r => rows.Contains(r));
                int insertIndex = BackingRows.Count;
                if (rowToInsertAfter != null)
                {
                    insertIndex = BackingRows.IndexOf(rowToInsertAfter) + 1;
                }
                ReinsertAndSelect(insertIndex, rows);
            }
        }

        private List<int> GetSelectedIndices()
        {
            List<int> selectedIndices = new List<int>();
            var selectedRows = translationGrid.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    selectedIndices.Add(row.Index);
                }
            }
            selectedIndices.Sort();

            return selectedIndices;
        }

        private List<TranslatedTextRow> GetRowsAtIndices(List<int> indices)
        {
            List<TranslatedTextRow> rows = new List<TranslatedTextRow>();
            foreach (int index in indices)
            {
                rows.Add(Rows[index]);
            }

            return rows;
        }

        private void ReinsertAndSelect(int insertIndex, List<TranslatedTextRow> rows)
        {
            BackingRows.InsertRange(insertIndex, rows);
            Rows.ResetBindings();
            translationGrid.ClearSelection();
            for (int i = insertIndex; i < insertIndex + rows.Count; i++)
            {
                translationGrid.Rows[i].Selected = true;
            }
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            if (Settings != null && WindowState == FormWindowState.Normal)
            {
                Settings.WindowLocation = Location;
            }
        }

        private void ComboBoxLanguage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLanguage2.SelectedItem != null)
            {
                var selectedLanguage = (KeyValuePair<string, string>)ComboBoxLanguage2.SelectedItem;
                string languageCode = selectedLanguage.Key;
                string languageValue = selectedLanguage.Value;
                SettingsTools.Default.InputLang = languageValue;
                SettingsTools.Default.Save();

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string text = translatedTextBox.Text;
            await SynthesizeSpeechAsync(text);
        }
        private static async Task SynthesizeSpeechAsync(string text)
        {
            // Replace YOUR_SUBSCRIPTION_KEY and YOUR_REGION with your actual Azure subscription key and region.
            var config = SpeechConfig.FromSubscription("94ac6457bd7646bc8a3956823e541517", "southeastasia");

            // Set the voice to Yunyi Multilingual Mandarin
            config.SpeechSynthesisVoiceName = "zh-CN-YunyiMultilingualNeural";

            using (var synthesizer = new SpeechSynthesizer(config))
            {
                var result = await synthesizer.SpeakTextAsync(text);

                if (result.Reason == ResultReason.SynthesizingAudioCompleted)
                {
                    MessageBox.Show("Text-to-Speech completed!");
                }
                else if (result.Reason == ResultReason.Canceled)
                {
                    var cancellation = SpeechSynthesisCancellationDetails.FromResult(result);
                    MessageBox.Show($"CANCELED: Reason={cancellation.Reason}\nDetails={cancellation.ErrorDetails}");
                }
            }
        }

        private void subscriptionKeyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subscriptionKeyTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string text = backTranslatedTextBox.Text;
            await SynthesizeSpeechAsync(text);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Enabled = false;
           
            try
            {
                var selectedLanguage = (KeyValuePair<string, string>)ComboBoxLanguage2.SelectedItem;
                string languageCode = selectedLanguage.Key;
                string requestBody = "";
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Chưa nhập web muốn dịch", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string url = textBox1.Text;
                using (var request = new HttpRequest())
                {
                    // Gửi yêu cầu GET để lấy nội dung HTML
                    HttpResponse response = request.Get(url);
                    string htmlContent = response.ToString();

                    // Phân tích cú pháp HTML và lấy văn bản thuần túy
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(htmlContent);
                     requestBody = doc.DocumentNode.SelectSingleNode("//body").InnerText;
                    if (requestBody.Length > 5000)
                    {
                        requestBody = requestBody.Substring(0, 5000);
                    }

                }
            
                List<TranslatedTextRow> rowsToTranslate = Rows.Where(r => r.Translate).ToList();
                int length = requestBody.Length;
                int rowsPerCall = Math.Max(1, length > 0 ? (int)Math.Min(maxCharsUpDown.Value / length, rowsToTranslate.Count) : rowsToTranslate.Count);

                for (int i = 0; i < rowsToTranslate.Count; i += rowsPerCall)
                {
                    List<TranslatedTextRow> rowsThisCall = rowsToTranslate.Skip(i).Take(rowsPerCall).ToList();


                    //await Translator.DetectLanguageAsync();

                    string[] languages = rowsThisCall.Select(r => r.Language).ToArray();
                    List<string> translations = await Translator.Translate(languageCode,
                        languages, requestBody, htmlCheckBox.Checked);
                    for (int j = 0; j < translations.Count; j++)
                    {
                        rowsThisCall[j].TranslatedText = translations[j];
                    }
                }

                await BackTranslate();
            }
            catch (AzureException ex)
            {
                ShowAzureException(ex);
            }
            catch (UnrecognizedResponseException ex)
            {
                ShowUnrecognizedResponseException(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Unknown exception: {ex.Message}");
            }

            if (translationGrid.SelectedRows.Count > 0)
            {
                translationGrid_CellContentClick(translationGrid,
                   new DataGridViewCellEventArgs(0, translationGrid.SelectedRows[0].Index));
            }

            Enabled = true;
        }
    }
}
