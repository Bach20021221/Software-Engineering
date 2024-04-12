using Leaf.xNet;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WinFormsApp;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string url = "https://api.cognitive.microsofttranslator.com/languages?api-version=3.0";
            HttpRequest request = new HttpRequest();
            request.KeepAlive = false; // Đặt lại thành true để giữ kết nối sống
            request.AddHeader(HttpHeader.Accept, "application/json"); // Sửa lại để chấp nhận JSON
            request.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.5");
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36";
            string jsonResponse;

            try
            {
                jsonResponse = request.Get(url).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching languages: {ex.Message}");
                return;
            }

            // Sửa lại phần deserialize để phản ánh đúng cấu trúc JSON
            var root = JsonConvert.DeserializeObject<Root>(jsonResponse);
            if (root != null && root.translation != null)
            {
                foreach (var item in root.translation)
                {
                    Language language = item.Value;
                    comboBox1.Items.Add(new { Id = item.Key, language.Name });
                    comboBox2.Items.Add(new { Id = item.Key, language.Name });
                }
            }

            // Đặt giá trị hiển thị cho ComboBox
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
        }

        public class Language
        {
            public string Name { get; set; }
            public string NativeName { get; set; }
            public string Dir { get; set; }
        }

        public class Root
        {
            public Dictionary<string, Language> translation { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string subscriptionKey = "d141d4610c0e47ebab1b0497611d3909";
            string endpoint = "66340571ecb74e1c9d850a6d73efa406";
            string location = "eastasia";
            string inputText = txtInput.Text; // Gi? s? txtInput là TextBox ch?a v?n b?n c?n d?ch
            string toLanguage = "en"; // ??t ngôn ng? m?c tiêu

            var translator = new AzureTranslator(subscriptionKey, endpoint, location);
            string translatedText = await translator.TranslateTextAsync(inputText, toLanguage);

            txtResult.Text = translatedText; // Gi? s? txtResult là TextBox hi?n th? v?n b?n ?ã d?ch
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }
    }
}