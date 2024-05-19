namespace AzureMultiTranslator
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ComboBoxLanguage2 = new System.Windows.Forms.ComboBox();
            ComboBoxLanguage = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            sourceTextBox = new System.Windows.Forms.TextBox();
            mainSplitContainer = new System.Windows.Forms.SplitContainer();
            panel2 = new System.Windows.Forms.Panel();
            button3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            lengthTextBox = new System.Windows.Forms.TextBox();
            lengthLabel = new System.Windows.Forms.Label();
            htmlCheckBox = new System.Windows.Forms.CheckBox();
            settingsBindingSource = new System.Windows.Forms.BindingSource(components);
            languageLabel = new System.Windows.Forms.Label();
            translationsPaneSplitContainer = new System.Windows.Forms.SplitContainer();
            translationGrid = new System.Windows.Forms.DataGridView();
            Translate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            translatedTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            copyTranslatedColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            backTranslatedTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            copyBackTranslatedColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            translatedTextRowBindingSource = new System.Windows.Forms.BindingSource(components);
            translationsTextBoxesSplitContainer = new System.Windows.Forms.SplitContainer();
            translatedTextBox = new System.Windows.Forms.TextBox();
            translatedLabel = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            backTranslatedTextBox = new System.Windows.Forms.TextBox();
            backTranslatedLabel = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            maxCharsUpDown = new System.Windows.Forms.NumericUpDown();
            maxCharsLabel = new System.Windows.Forms.Label();
            upButton = new System.Windows.Forms.Button();
            downButton = new System.Windows.Forms.Button();
            sortButton = new System.Windows.Forms.Button();
            backTranslateCheckBox = new System.Windows.Forms.CheckBox();
            addLanguageButton = new System.Windows.Forms.Button();
            translateButton = new System.Windows.Forms.Button();
            languageTextBox = new System.Windows.Forms.TextBox();
            addLanguageTextBox = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            rememberKeyCheckBox = new System.Windows.Forms.CheckBox();
            subscriptionKeyTextBox = new System.Windows.Forms.TextBox();
            keyLabel = new System.Windows.Forms.Label();
            endpointTextBox = new System.Windows.Forms.TextBox();
            endpointLabel = new System.Windows.Forms.Label();
            settingsTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)translationsPaneSplitContainer).BeginInit();
            translationsPaneSplitContainer.Panel1.SuspendLayout();
            translationsPaneSplitContainer.Panel2.SuspendLayout();
            translationsPaneSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)translationGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)translatedTextRowBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)translationsTextBoxesSplitContainer).BeginInit();
            translationsTextBoxesSplitContainer.Panel1.SuspendLayout();
            translationsTextBoxesSplitContainer.Panel2.SuspendLayout();
            translationsTextBoxesSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxCharsUpDown).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxLanguage2
            // 
            ComboBoxLanguage2.FormattingEnabled = true;
            ComboBoxLanguage2.Location = new System.Drawing.Point(72, 6);
            ComboBoxLanguage2.Name = "ComboBoxLanguage2";
            ComboBoxLanguage2.Size = new System.Drawing.Size(102, 23);
            ComboBoxLanguage2.TabIndex = 9;
            ComboBoxLanguage2.SelectedIndexChanged += ComboBoxLanguage2_SelectedIndexChanged;
            // 
            // ComboBoxLanguage
            // 
            ComboBoxLanguage.FormattingEnabled = true;
            ComboBoxLanguage.Location = new System.Drawing.Point(527, 7);
            ComboBoxLanguage.Name = "ComboBoxLanguage";
            ComboBoxLanguage.Size = new System.Drawing.Size(121, 23);
            ComboBoxLanguage.TabIndex = 8;
            ComboBoxLanguage.SelectedIndexChanged += ComboBoxLanguages_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.Location = new System.Drawing.Point(302, 17);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(56, 36);
            button1.TabIndex = 2;
            button1.Text = "Voice";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sourceTextBox
            // 
            sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            sourceTextBox.Location = new System.Drawing.Point(0, 69);
            sourceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sourceTextBox.Multiline = true;
            sourceTextBox.Name = "sourceTextBox";
            sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            sourceTextBox.Size = new System.Drawing.Size(379, 568);
            sourceTextBox.TabIndex = 0;
            sourceTextBox.TextChanged += englishTextBox_TextChanged;
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            mainSplitContainer.Location = new System.Drawing.Point(0, 10);
            mainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(sourceTextBox);
            mainSplitContainer.Panel1.Controls.Add(panel2);
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(translationsPaneSplitContainer);
            mainSplitContainer.Panel2.Controls.Add(panel1);
            mainSplitContainer.Size = new System.Drawing.Size(1148, 637);
            mainSplitContainer.SplitterDistance = 379;
            mainSplitContainer.SplitterWidth = 5;
            mainSplitContainer.TabIndex = 1;
            mainSplitContainer.SplitterMoved += mainSplitContainer_SplitterMoved;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(ComboBoxLanguage2);
            panel2.Controls.Add(lengthTextBox);
            panel2.Controls.Add(lengthLabel);
            panel2.Controls.Add(htmlCheckBox);
            panel2.Controls.Add(languageLabel);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(379, 69);
            panel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(278, 34);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(88, 27);
            button3.TabIndex = 12;
            button3.Text = "Translate web";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 11;
            label1.Text = "Web";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(74, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(178, 23);
            textBox1.TabIndex = 10;
            // 
            // lengthTextBox
            // 
            lengthTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lengthTextBox.Location = new System.Drawing.Point(315, 8);
            lengthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new System.Drawing.Size(62, 23);
            lengthTextBox.TabIndex = 5;
            lengthTextBox.Text = "0";
            lengthTextBox.TextChanged += lengthTextBox_TextChanged;
            // 
            // lengthLabel
            // 
            lengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lengthLabel.AutoSize = true;
            lengthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            lengthLabel.Location = new System.Drawing.Point(259, 10);
            lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new System.Drawing.Size(47, 15);
            lengthLabel.TabIndex = 4;
            lengthLabel.Text = "Length:";
            // 
            // htmlCheckBox
            // 
            htmlCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            htmlCheckBox.AutoSize = true;
            htmlCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settingsBindingSource, "Html", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            htmlCheckBox.Location = new System.Drawing.Point(194, 9);
            htmlCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            htmlCheckBox.Name = "htmlCheckBox";
            htmlCheckBox.Size = new System.Drawing.Size(58, 19);
            htmlCheckBox.TabIndex = 2;
            htmlCheckBox.Text = "HTML";
            htmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // settingsBindingSource
            // 
            settingsBindingSource.DataSource = typeof(Settings);
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new System.Drawing.Point(9, 10);
            languageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new System.Drawing.Size(59, 15);
            languageLabel.TabIndex = 1;
            languageLabel.Text = "Language";
            // 
            // translationsPaneSplitContainer
            // 
            translationsPaneSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            translationsPaneSplitContainer.Location = new System.Drawing.Point(0, 37);
            translationsPaneSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            translationsPaneSplitContainer.Name = "translationsPaneSplitContainer";
            translationsPaneSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // translationsPaneSplitContainer.Panel1
            // 
            translationsPaneSplitContainer.Panel1.Controls.Add(translationGrid);
            // 
            // translationsPaneSplitContainer.Panel2
            // 
            translationsPaneSplitContainer.Panel2.Controls.Add(translationsTextBoxesSplitContainer);
            translationsPaneSplitContainer.Size = new System.Drawing.Size(764, 600);
            translationsPaneSplitContainer.SplitterDistance = 202;
            translationsPaneSplitContainer.SplitterWidth = 5;
            translationsPaneSplitContainer.TabIndex = 3;
            translationsPaneSplitContainer.SplitterMoved += translationsPaneSplitContainer_SplitterMoved;
            // 
            // translationGrid
            // 
            translationGrid.AutoGenerateColumns = false;
            translationGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            translationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            translationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Translate, languageDataGridViewTextBoxColumn, translatedTextDataGridViewTextBoxColumn, copyTranslatedColumn, backTranslatedTextDataGridViewTextBoxColumn, copyBackTranslatedColumn, deleteColumn });
            translationGrid.DataSource = translatedTextRowBindingSource;
            translationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            translationGrid.Location = new System.Drawing.Point(0, 0);
            translationGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            translationGrid.Name = "translationGrid";
            translationGrid.RowHeadersVisible = false;
            translationGrid.RowHeadersWidth = 82;
            translationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            translationGrid.Size = new System.Drawing.Size(764, 202);
            translationGrid.TabIndex = 0;
            translationGrid.CellContentClick += translationGrid_CellContentClick;
            // 
            // Translate
            // 
            Translate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            Translate.DataPropertyName = "Translate";
            Translate.HeaderText = "";
            Translate.Name = "Translate";
            Translate.Width = 5;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            languageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            languageDataGridViewTextBoxColumn.HeaderText = "";
            languageDataGridViewTextBoxColumn.MinimumWidth = 10;
            languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            languageDataGridViewTextBoxColumn.ReadOnly = true;
            languageDataGridViewTextBoxColumn.Width = 10;
            // 
            // translatedTextDataGridViewTextBoxColumn
            // 
            translatedTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            translatedTextDataGridViewTextBoxColumn.DataPropertyName = "TranslatedText";
            translatedTextDataGridViewTextBoxColumn.HeaderText = "Translated";
            translatedTextDataGridViewTextBoxColumn.MinimumWidth = 10;
            translatedTextDataGridViewTextBoxColumn.Name = "translatedTextDataGridViewTextBoxColumn";
            // 
            // copyTranslatedColumn
            // 
            copyTranslatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            copyTranslatedColumn.DataPropertyName = "Copy";
            copyTranslatedColumn.HeaderText = "";
            copyTranslatedColumn.MinimumWidth = 10;
            copyTranslatedColumn.Name = "copyTranslatedColumn";
            copyTranslatedColumn.ReadOnly = true;
            copyTranslatedColumn.Width = 10;
            // 
            // backTranslatedTextDataGridViewTextBoxColumn
            // 
            backTranslatedTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            backTranslatedTextDataGridViewTextBoxColumn.DataPropertyName = "BackTranslatedText";
            backTranslatedTextDataGridViewTextBoxColumn.HeaderText = "Back-Translated";
            backTranslatedTextDataGridViewTextBoxColumn.MinimumWidth = 10;
            backTranslatedTextDataGridViewTextBoxColumn.Name = "backTranslatedTextDataGridViewTextBoxColumn";
            // 
            // copyBackTranslatedColumn
            // 
            copyBackTranslatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            copyBackTranslatedColumn.DataPropertyName = "Copy";
            copyBackTranslatedColumn.HeaderText = "";
            copyBackTranslatedColumn.MinimumWidth = 10;
            copyBackTranslatedColumn.Name = "copyBackTranslatedColumn";
            copyBackTranslatedColumn.ReadOnly = true;
            copyBackTranslatedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            copyBackTranslatedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            copyBackTranslatedColumn.Width = 19;
            // 
            // deleteColumn
            // 
            deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            deleteColumn.DataPropertyName = "Remove";
            deleteColumn.HeaderText = "";
            deleteColumn.MinimumWidth = 10;
            deleteColumn.Name = "deleteColumn";
            deleteColumn.ReadOnly = true;
            deleteColumn.Width = 10;
            // 
            // translatedTextRowBindingSource
            // 
            translatedTextRowBindingSource.DataSource = typeof(TranslatedTextRow);
            // 
            // translationsTextBoxesSplitContainer
            // 
            translationsTextBoxesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            translationsTextBoxesSplitContainer.Location = new System.Drawing.Point(0, 0);
            translationsTextBoxesSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            translationsTextBoxesSplitContainer.Name = "translationsTextBoxesSplitContainer";
            // 
            // translationsTextBoxesSplitContainer.Panel1
            // 
            translationsTextBoxesSplitContainer.Panel1.Controls.Add(button1);
            translationsTextBoxesSplitContainer.Panel1.Controls.Add(translatedTextBox);
            translationsTextBoxesSplitContainer.Panel1.Controls.Add(translatedLabel);
            // 
            // translationsTextBoxesSplitContainer.Panel2
            // 
            translationsTextBoxesSplitContainer.Panel2.Controls.Add(button2);
            translationsTextBoxesSplitContainer.Panel2.Controls.Add(backTranslatedTextBox);
            translationsTextBoxesSplitContainer.Panel2.Controls.Add(backTranslatedLabel);
            translationsTextBoxesSplitContainer.Size = new System.Drawing.Size(764, 393);
            translationsTextBoxesSplitContainer.SplitterDistance = 380;
            translationsTextBoxesSplitContainer.SplitterWidth = 5;
            translationsTextBoxesSplitContainer.TabIndex = 2;
            translationsTextBoxesSplitContainer.SplitterMoved += translationsTextBoxesSplitContainer_SplitterMoved;
            // 
            // translatedTextBox
            // 
            translatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            translatedTextBox.Location = new System.Drawing.Point(0, 15);
            translatedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            translatedTextBox.Multiline = true;
            translatedTextBox.Name = "translatedTextBox";
            translatedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            translatedTextBox.Size = new System.Drawing.Size(380, 378);
            translatedTextBox.TabIndex = 0;
            // 
            // translatedLabel
            // 
            translatedLabel.AutoSize = true;
            translatedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            translatedLabel.Location = new System.Drawing.Point(0, 0);
            translatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            translatedLabel.Name = "translatedLabel";
            translatedLabel.Size = new System.Drawing.Size(60, 15);
            translatedLabel.TabIndex = 1;
            translatedLabel.Text = "Translated";
            // 
            // button2
            // 
            button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button2.Location = new System.Drawing.Point(303, 19);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(56, 36);
            button2.TabIndex = 3;
            button2.Text = "Voice";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // backTranslatedTextBox
            // 
            backTranslatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            backTranslatedTextBox.Location = new System.Drawing.Point(0, 15);
            backTranslatedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            backTranslatedTextBox.Multiline = true;
            backTranslatedTextBox.Name = "backTranslatedTextBox";
            backTranslatedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            backTranslatedTextBox.Size = new System.Drawing.Size(379, 378);
            backTranslatedTextBox.TabIndex = 3;
            // 
            // backTranslatedLabel
            // 
            backTranslatedLabel.AutoSize = true;
            backTranslatedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            backTranslatedLabel.Location = new System.Drawing.Point(0, 0);
            backTranslatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            backTranslatedLabel.Name = "backTranslatedLabel";
            backTranslatedLabel.Size = new System.Drawing.Size(90, 15);
            backTranslatedLabel.TabIndex = 2;
            backTranslatedLabel.Text = "Back-Translated";
            // 
            // panel1
            // 
            panel1.Controls.Add(maxCharsUpDown);
            panel1.Controls.Add(maxCharsLabel);
            panel1.Controls.Add(ComboBoxLanguage);
            panel1.Controls.Add(upButton);
            panel1.Controls.Add(downButton);
            panel1.Controls.Add(sortButton);
            panel1.Controls.Add(backTranslateCheckBox);
            panel1.Controls.Add(addLanguageButton);
            panel1.Controls.Add(translateButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(764, 37);
            panel1.TabIndex = 1;
            // 
            // maxCharsUpDown
            // 
            maxCharsUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            maxCharsUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", settingsBindingSource, "MaxChars", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            maxCharsUpDown.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            maxCharsUpDown.Location = new System.Drawing.Point(302, 8);
            maxCharsUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            maxCharsUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            maxCharsUpDown.Name = "maxCharsUpDown";
            maxCharsUpDown.Size = new System.Drawing.Size(78, 23);
            maxCharsUpDown.TabIndex = 7;
            maxCharsUpDown.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // maxCharsLabel
            // 
            maxCharsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            maxCharsLabel.AutoSize = true;
            maxCharsLabel.Location = new System.Drawing.Point(229, 11);
            maxCharsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            maxCharsLabel.Name = "maxCharsLabel";
            maxCharsLabel.Size = new System.Drawing.Size(63, 15);
            maxCharsLabel.TabIndex = 6;
            maxCharsLabel.Text = "Max Chars";
            // 
            // upButton
            // 
            upButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            upButton.AutoSize = true;
            upButton.Location = new System.Drawing.Point(390, 4);
            upButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            upButton.Name = "upButton";
            upButton.Size = new System.Drawing.Size(29, 29);
            upButton.TabIndex = 7;
            upButton.Text = "⯅";
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // downButton
            // 
            downButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            downButton.AutoSize = true;
            downButton.Location = new System.Drawing.Point(425, 3);
            downButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            downButton.Name = "downButton";
            downButton.Size = new System.Drawing.Size(29, 29);
            downButton.TabIndex = 6;
            downButton.Text = "⯆";
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += downButton_Click;
            // 
            // sortButton
            // 
            sortButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            sortButton.AutoSize = true;
            sortButton.Location = new System.Drawing.Point(461, 4);
            sortButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(44, 29);
            sortButton.TabIndex = 5;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // backTranslateCheckBox
            // 
            backTranslateCheckBox.AutoSize = true;
            backTranslateCheckBox.Checked = true;
            backTranslateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            backTranslateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settingsBindingSource, "BackTranslate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            backTranslateCheckBox.Location = new System.Drawing.Point(96, 9);
            backTranslateCheckBox.Margin = new System.Windows.Forms.Padding(2);
            backTranslateCheckBox.Name = "backTranslateCheckBox";
            backTranslateCheckBox.Size = new System.Drawing.Size(102, 19);
            backTranslateCheckBox.TabIndex = 4;
            backTranslateCheckBox.Text = "Back-Translate";
            backTranslateCheckBox.UseVisualStyleBackColor = true;
            // 
            // addLanguageButton
            // 
            addLanguageButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            addLanguageButton.AutoSize = true;
            addLanguageButton.Location = new System.Drawing.Point(655, 5);
            addLanguageButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addLanguageButton.Name = "addLanguageButton";
            addLanguageButton.Size = new System.Drawing.Size(100, 29);
            addLanguageButton.TabIndex = 2;
            addLanguageButton.Text = "Add Language";
            addLanguageButton.UseVisualStyleBackColor = true;
            addLanguageButton.Click += addLanguageButton_Click;
            // 
            // translateButton
            // 
            translateButton.Location = new System.Drawing.Point(4, 5);
            translateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            translateButton.Name = "translateButton";
            translateButton.Size = new System.Drawing.Size(88, 27);
            translateButton.TabIndex = 3;
            translateButton.Text = "Translate!";
            translateButton.UseVisualStyleBackColor = true;
            translateButton.Click += translateButton_Click;
            // 
            // languageTextBox
            // 
            languageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", settingsBindingSource, "SourceLanguage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            languageTextBox.Location = new System.Drawing.Point(77, 8);
            languageTextBox.Margin = new System.Windows.Forms.Padding(2);
            languageTextBox.Name = "languageTextBox";
            languageTextBox.Size = new System.Drawing.Size(60, 23);
            languageTextBox.TabIndex = 6;
            // 
            // addLanguageTextBox
            // 
            addLanguageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            addLanguageTextBox.Location = new System.Drawing.Point(588, 8);
            addLanguageTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addLanguageTextBox.Name = "addLanguageTextBox";
            addLanguageTextBox.Size = new System.Drawing.Size(59, 23);
            addLanguageTextBox.TabIndex = 1;
            addLanguageTextBox.Enter += addLanguageTextBox_Enter;
            addLanguageTextBox.Leave += addLanguageTextBox_Leave;
            // 
            // panel3
            // 
            panel3.Controls.Add(rememberKeyCheckBox);
            panel3.Controls.Add(subscriptionKeyTextBox);
            panel3.Controls.Add(keyLabel);
            panel3.Controls.Add(endpointTextBox);
            panel3.Controls.Add(endpointLabel);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1148, 10);
            panel3.TabIndex = 2;
            // 
            // rememberKeyCheckBox
            // 
            rememberKeyCheckBox.AutoSize = true;
            rememberKeyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settingsBindingSource, "SaveSubscriptionKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            rememberKeyCheckBox.Location = new System.Drawing.Point(861, 9);
            rememberKeyCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rememberKeyCheckBox.Name = "rememberKeyCheckBox";
            rememberKeyCheckBox.Size = new System.Drawing.Size(84, 19);
            rememberKeyCheckBox.TabIndex = 4;
            rememberKeyCheckBox.Text = "Remember";
            rememberKeyCheckBox.UseVisualStyleBackColor = true;
            rememberKeyCheckBox.Visible = false;
            // 
            // subscriptionKeyTextBox
            // 
            subscriptionKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", settingsBindingSource, "SubscriptionKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            subscriptionKeyTextBox.Location = new System.Drawing.Point(522, 8);
            subscriptionKeyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            subscriptionKeyTextBox.Name = "subscriptionKeyTextBox";
            subscriptionKeyTextBox.Size = new System.Drawing.Size(334, 23);
            subscriptionKeyTextBox.TabIndex = 3;
            subscriptionKeyTextBox.Visible = false;
            subscriptionKeyTextBox.TextChanged += subscriptionKeyTextBox_TextChanged_1;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new System.Drawing.Point(413, 10);
            keyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new System.Drawing.Size(95, 15);
            keyLabel.TabIndex = 2;
            keyLabel.Text = "Subscription Key";
            keyLabel.Visible = false;
            // 
            // endpointTextBox
            // 
            endpointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", settingsBindingSource, "Endpoint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            endpointTextBox.Location = new System.Drawing.Point(72, 8);
            endpointTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            endpointTextBox.Name = "endpointTextBox";
            endpointTextBox.Size = new System.Drawing.Size(334, 23);
            endpointTextBox.TabIndex = 1;
            // 
            // endpointLabel
            // 
            endpointLabel.AutoSize = true;
            endpointLabel.Location = new System.Drawing.Point(9, 10);
            endpointLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            endpointLabel.Name = "endpointLabel";
            endpointLabel.Size = new System.Drawing.Size(55, 15);
            endpointLabel.TabIndex = 0;
            endpointLabel.Text = "Endpoint";
            // 
            // settingsTimer
            // 
            settingsTimer.Interval = 250;
            settingsTimer.Tick += settingsTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1148, 647);
            Controls.Add(mainSplitContainer);
            Controls.Add(panel3);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "AzureMultiTranslator";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Move += MainForm_Move;
            Resize += MainForm_Resize;
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel1.PerformLayout();
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsBindingSource).EndInit();
            translationsPaneSplitContainer.Panel1.ResumeLayout(false);
            translationsPaneSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)translationsPaneSplitContainer).EndInit();
            translationsPaneSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)translationGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)translatedTextRowBindingSource).EndInit();
            translationsTextBoxesSplitContainer.Panel1.ResumeLayout(false);
            translationsTextBoxesSplitContainer.Panel1.PerformLayout();
            translationsTextBoxesSplitContainer.Panel2.ResumeLayout(false);
            translationsTextBoxesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)translationsTextBoxesSplitContainer).EndInit();
            translationsTextBoxesSplitContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxCharsUpDown).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.DataGridView translationGrid;
        private System.Windows.Forms.BindingSource translatedTextRowBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.TextBox addLanguageTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.CheckBox htmlCheckBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.SplitContainer translationsTextBoxesSplitContainer;
        private System.Windows.Forms.TextBox translatedTextBox;
        private System.Windows.Forms.Label translatedLabel;
        private System.Windows.Forms.TextBox backTranslatedTextBox;
        private System.Windows.Forms.Label backTranslatedLabel;
        private System.Windows.Forms.SplitContainer translationsPaneSplitContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox subscriptionKeyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox endpointTextBox;
        private System.Windows.Forms.Label endpointLabel;
        private System.Windows.Forms.CheckBox rememberKeyCheckBox;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.Timer settingsTimer;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.CheckBox backTranslateCheckBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Translate;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translatedTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn copyTranslatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backTranslatedTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn copyBackTranslatedColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.Label maxCharsLabel;
        private System.Windows.Forms.NumericUpDown maxCharsUpDown;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
        private System.Windows.Forms.ComboBox ComboBoxLanguage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

