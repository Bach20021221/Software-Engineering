namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnTranslate = new Button();
            txtInput = new RichTextBox();
            txtResult = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnTranslate
            // 
            btnTranslate.BackColor = SystemColors.ActiveCaption;
            btnTranslate.Image = (Image)resources.GetObject("btnTranslate.Image");
            btnTranslate.ImageAlign = ContentAlignment.MiddleLeft;
            btnTranslate.Location = new Point(323, 282);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(156, 35);
            btnTranslate.TabIndex = 0;
            btnTranslate.Text = "Translate Text";
            btnTranslate.UseVisualStyleBackColor = false;
            btnTranslate.Click += button1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(28, 53);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(328, 214);
            txtInput.TabIndex = 1;
            txtInput.Text = "";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(454, 53);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(328, 214);
            txtResult.TabIndex = 2;
            txtResult.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 3;
            label1.Text = "Translate from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 26);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Translate into";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(537, 24);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(323, 63);
            label3.Name = "label3";
            label3.Size = new Size(24, 28);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 342);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(txtInput);
            Controls.Add(btnTranslate);
            Name = "Form1";
            Text = "Translation Tool";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTranslate;
        private RichTextBox txtInput;
        private RichTextBox txtResult;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
    }
}