namespace SearchFiles
{
    partial class Form1
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButtonWordFull = new System.Windows.Forms.RadioButton();
            this.radioButtonEndsWith = new System.Windows.Forms.RadioButton();
            this.radioButtonBeginsWith = new System.Windows.Forms.RadioButton();
            this.radioButtonOpenFile = new System.Windows.Forms.RadioButton();
            this.radioButtonShowFile = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(29, 112);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(219, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Регистр";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(296, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1131, 589);
            this.listBox1.TabIndex = 5;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(54, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(29, 12);
            this.textBoxDir.Multiline = true;
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.ReadOnly = true;
            this.textBoxDir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDir.Size = new System.Drawing.Size(1398, 51);
            this.textBoxDir.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Выбор каталога";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // radioButtonWordFull
            // 
            this.radioButtonWordFull.AutoSize = true;
            this.radioButtonWordFull.Location = new System.Drawing.Point(43, 189);
            this.radioButtonWordFull.Name = "radioButtonWordFull";
            this.radioButtonWordFull.Size = new System.Drawing.Size(103, 17);
            this.radioButtonWordFull.TabIndex = 9;
            this.radioButtonWordFull.TabStop = true;
            this.radioButtonWordFull.Text = "Слова целиком";
            this.radioButtonWordFull.UseVisualStyleBackColor = true;
            this.radioButtonWordFull.CheckedChanged += new System.EventHandler(this.RadioButtonWordFull_CheckedChanged);
            // 
            // radioButtonEndsWith
            // 
            this.radioButtonEndsWith.AutoSize = true;
            this.radioButtonEndsWith.Location = new System.Drawing.Point(43, 212);
            this.radioButtonEndsWith.Name = "radioButtonEndsWith";
            this.radioButtonEndsWith.Size = new System.Drawing.Size(117, 17);
            this.radioButtonEndsWith.TabIndex = 10;
            this.radioButtonEndsWith.TabStop = true;
            this.radioButtonEndsWith.Text = "Заканчивается на";
            this.radioButtonEndsWith.UseVisualStyleBackColor = true;
            this.radioButtonEndsWith.CheckedChanged += new System.EventHandler(this.RadioButtonEndsWith_CheckedChanged);
            // 
            // radioButtonBeginsWith
            // 
            this.radioButtonBeginsWith.AutoSize = true;
            this.radioButtonBeginsWith.Location = new System.Drawing.Point(43, 235);
            this.radioButtonBeginsWith.Name = "radioButtonBeginsWith";
            this.radioButtonBeginsWith.Size = new System.Drawing.Size(109, 17);
            this.radioButtonBeginsWith.TabIndex = 11;
            this.radioButtonBeginsWith.TabStop = true;
            this.radioButtonBeginsWith.Text = "Начинается на...";
            this.radioButtonBeginsWith.UseVisualStyleBackColor = true;
            this.radioButtonBeginsWith.CheckedChanged += new System.EventHandler(this.RadioButtonBeginsWith_CheckedChanged);
            // 
            // radioButtonOpenFile
            // 
            this.radioButtonOpenFile.AutoSize = true;
            this.radioButtonOpenFile.Location = new System.Drawing.Point(6, 19);
            this.radioButtonOpenFile.Name = "radioButtonOpenFile";
            this.radioButtonOpenFile.Size = new System.Drawing.Size(69, 17);
            this.radioButtonOpenFile.TabIndex = 12;
            this.radioButtonOpenFile.TabStop = true;
            this.radioButtonOpenFile.Text = "Открыть";
            this.radioButtonOpenFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonShowFile
            // 
            this.radioButtonShowFile.AutoSize = true;
            this.radioButtonShowFile.Location = new System.Drawing.Point(6, 42);
            this.radioButtonShowFile.Name = "radioButtonShowFile";
            this.radioButtonShowFile.Size = new System.Drawing.Size(151, 17);
            this.radioButtonShowFile.TabIndex = 13;
            this.radioButtonShowFile.TabStop = true;
            this.radioButtonShowFile.Text = "Показать расположение";
            this.radioButtonShowFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOpenFile);
            this.groupBox1.Controls.Add(this.radioButtonShowFile);
            this.groupBox1.Location = new System.Drawing.Point(22, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "При двойном клике";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 715);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButtonBeginsWith);
            this.Controls.Add(this.radioButtonEndsWith);
            this.Controls.Add(this.radioButtonWordFull);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonWordFull;
        private System.Windows.Forms.RadioButton radioButtonEndsWith;
        private System.Windows.Forms.RadioButton radioButtonBeginsWith;
        private System.Windows.Forms.RadioButton radioButtonOpenFile;
        private System.Windows.Forms.RadioButton radioButtonShowFile;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

