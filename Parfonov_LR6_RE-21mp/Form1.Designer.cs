namespace Parfonov_LR6_RE_21mp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_fileKey_out = new System.Windows.Forms.Button();
            this.textBox_fileKey_out = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_hand = new System.Windows.Forms.CheckBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_viewPassWord = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_fileSave = new System.Windows.Forms.Button();
            this.label_fileSave = new System.Windows.Forms.Label();
            this.button_fileCipher = new System.Windows.Forms.Button();
            this.label_fileCipher = new System.Windows.Forms.Label();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.label_fileOpen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_bits = new System.Windows.Forms.Label();
            this.comboBox_keyLength_byte = new System.Windows.Forms.ComboBox();
            this.radioButton_passWord = new System.Windows.Forms.RadioButton();
            this.radioButton_keyGen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.linkLabel_author = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(59, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 166);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Файл з ключем";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_fileKey_out);
            this.groupBox1.Controls.Add(this.textBox_fileKey_out);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шлях до файлу";
            // 
            // button_fileKey_out
            // 
            this.button_fileKey_out.Location = new System.Drawing.Point(538, 42);
            this.button_fileKey_out.Name = "button_fileKey_out";
            this.button_fileKey_out.Size = new System.Drawing.Size(75, 23);
            this.button_fileKey_out.TabIndex = 1;
            this.button_fileKey_out.Text = "...";
            this.button_fileKey_out.UseVisualStyleBackColor = true;
            this.button_fileKey_out.Click += new System.EventHandler(this.button_fileKey_out_Click);
            // 
            // textBox_fileKey_out
            // 
            this.textBox_fileKey_out.Location = new System.Drawing.Point(30, 43);
            this.textBox_fileKey_out.Name = "textBox_fileKey_out";
            this.textBox_fileKey_out.Size = new System.Drawing.Size(476, 22);
            this.textBox_fileKey_out.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ключ у HEX форматі";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_hand);
            this.groupBox3.Controls.Add(this.textBox_Key);
            this.groupBox3.Location = new System.Drawing.Point(29, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ключ (HEX формат)";
            // 
            // checkBox_hand
            // 
            this.checkBox_hand.AutoSize = true;
            this.checkBox_hand.Image = global::Parfonov_LR6_RE_21mp.Properties.Resources.hand;
            this.checkBox_hand.Location = new System.Drawing.Point(541, 26);
            this.checkBox_hand.Name = "checkBox_hand";
            this.checkBox_hand.Size = new System.Drawing.Size(69, 46);
            this.checkBox_hand.TabIndex = 1;
            this.checkBox_hand.UseVisualStyleBackColor = true;
            this.checkBox_hand.CheckedChanged += new System.EventHandler(this.checkBox_hand_CheckedChanged);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(32, 37);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.ReadOnly = true;
            this.textBox_Key.Size = new System.Drawing.Size(486, 22);
            this.textBox_Key.TabIndex = 0;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Key_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.textBox_password);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.checkBox_viewPassWord);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(664, 137);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Власний пароль";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(191, 44);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(328, 22);
            this.textBox_password.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Придумайте свій пароль \r\nі запишіть його сюди";
            // 
            // checkBox_viewPassWord
            // 
            this.checkBox_viewPassWord.AutoSize = true;
            this.checkBox_viewPassWord.Image = global::Parfonov_LR6_RE_21mp.Properties.Resources.eye;
            this.checkBox_viewPassWord.Location = new System.Drawing.Point(534, 30);
            this.checkBox_viewPassWord.Name = "checkBox_viewPassWord";
            this.checkBox_viewPassWord.Size = new System.Drawing.Size(92, 47);
            this.checkBox_viewPassWord.TabIndex = 1;
            this.checkBox_viewPassWord.UseVisualStyleBackColor = true;
            this.checkBox_viewPassWord.CheckedChanged += new System.EventHandler(this.checkBox_viewPassWord_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.button_fileSave);
            this.tabPage4.Controls.Add(this.label_fileSave);
            this.tabPage4.Controls.Add(this.button_fileCipher);
            this.tabPage4.Controls.Add(this.label_fileCipher);
            this.tabPage4.Controls.Add(this.button_fileOpen);
            this.tabPage4.Controls.Add(this.label_fileOpen);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(664, 137);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Файл XOR ключ";
            // 
            // button_fileSave
            // 
            this.button_fileSave.Image = global::Parfonov_LR6_RE_21mp.Properties.Resources.b3;
            this.button_fileSave.Location = new System.Drawing.Point(601, 37);
            this.button_fileSave.Name = "button_fileSave";
            this.button_fileSave.Size = new System.Drawing.Size(57, 59);
            this.button_fileSave.TabIndex = 5;
            this.button_fileSave.UseVisualStyleBackColor = true;
            this.button_fileSave.Click += new System.EventHandler(this.button_fileSave_Click);
            // 
            // label_fileSave
            // 
            this.label_fileSave.AutoSize = true;
            this.label_fileSave.BackColor = System.Drawing.SystemColors.Control;
            this.label_fileSave.Location = new System.Drawing.Point(472, 37);
            this.label_fileSave.Name = "label_fileSave";
            this.label_fileSave.Size = new System.Drawing.Size(122, 48);
            this.label_fileSave.TabIndex = 4;
            this.label_fileSave.Text = "3.\r\n     Зберегти файл\r\n           (немає)";
            // 
            // button_fileCipher
            // 
            this.button_fileCipher.Image = global::Parfonov_LR6_RE_21mp.Properties.Resources.b2;
            this.button_fileCipher.Location = new System.Drawing.Point(334, 37);
            this.button_fileCipher.Name = "button_fileCipher";
            this.button_fileCipher.Size = new System.Drawing.Size(132, 59);
            this.button_fileCipher.TabIndex = 3;
            this.button_fileCipher.UseVisualStyleBackColor = true;
            this.button_fileCipher.Click += new System.EventHandler(this.button_fileCipher_Click);
            // 
            // label_fileCipher
            // 
            this.label_fileCipher.AutoSize = true;
            this.label_fileCipher.BackColor = System.Drawing.SystemColors.Control;
            this.label_fileCipher.Location = new System.Drawing.Point(221, 37);
            this.label_fileCipher.Name = "label_fileCipher";
            this.label_fileCipher.Size = new System.Drawing.Size(107, 48);
            this.label_fileCipher.TabIndex = 2;
            this.label_fileCipher.Text = "2.\r\n     Шифрування\r\n          (немає)";
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Image = global::Parfonov_LR6_RE_21mp.Properties.Resources.m11;
            this.button_fileOpen.Location = new System.Drawing.Point(147, 26);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(57, 59);
            this.button_fileOpen.TabIndex = 1;
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.button_fileOpen_Click);
            // 
            // label_fileOpen
            // 
            this.label_fileOpen.AutoSize = true;
            this.label_fileOpen.BackColor = System.Drawing.SystemColors.Control;
            this.label_fileOpen.Location = new System.Drawing.Point(23, 26);
            this.label_fileOpen.Name = "label_fileOpen";
            this.label_fileOpen.Size = new System.Drawing.Size(118, 48);
            this.label_fileOpen.TabIndex = 0;
            this.label_fileOpen.Text = "1.\r\n     Відкрити файл\r\n           (немає)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_bits);
            this.groupBox2.Controls.Add(this.comboBox_keyLength_byte);
            this.groupBox2.Controls.Add(this.radioButton_passWord);
            this.groupBox2.Controls.Add(this.radioButton_keyGen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(59, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ключ";
            // 
            // label_bits
            // 
            this.label_bits.AutoSize = true;
            this.label_bits.Location = new System.Drawing.Point(205, 56);
            this.label_bits.Name = "label_bits";
            this.label_bits.Size = new System.Drawing.Size(28, 16);
            this.label_bits.TabIndex = 5;
            this.label_bits.Text = "bits";
            // 
            // comboBox_keyLength_byte
            // 
            this.comboBox_keyLength_byte.FormattingEnabled = true;
            this.comboBox_keyLength_byte.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32",
            "12500000"});
            this.comboBox_keyLength_byte.Location = new System.Drawing.Point(205, 22);
            this.comboBox_keyLength_byte.Name = "comboBox_keyLength_byte";
            this.comboBox_keyLength_byte.Size = new System.Drawing.Size(121, 24);
            this.comboBox_keyLength_byte.TabIndex = 4;
            this.comboBox_keyLength_byte.TextChanged += new System.EventHandler(this.comboBox_keyLength_byte_TextChanged);
            this.comboBox_keyLength_byte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_keyLength_byte_KeyPress);
            // 
            // radioButton_passWord
            // 
            this.radioButton_passWord.AutoSize = true;
            this.radioButton_passWord.Location = new System.Drawing.Point(330, 73);
            this.radioButton_passWord.Name = "radioButton_passWord";
            this.radioButton_passWord.Size = new System.Drawing.Size(300, 20);
            this.radioButton_passWord.TabIndex = 3;
            this.radioButton_passWord.TabStop = true;
            this.radioButton_passWord.Text = "Ключ генерується з розширенням пароля";
            this.radioButton_passWord.UseVisualStyleBackColor = true;
            this.radioButton_passWord.CheckedChanged += new System.EventHandler(this.radioButton_passWord_CheckedChanged);
            // 
            // radioButton_keyGen
            // 
            this.radioButton_keyGen.AutoSize = true;
            this.radioButton_keyGen.Checked = true;
            this.radioButton_keyGen.Location = new System.Drawing.Point(330, 22);
            this.radioButton_keyGen.Name = "radioButton_keyGen";
            this.radioButton_keyGen.Size = new System.Drawing.Size(279, 36);
            this.radioButton_keyGen.TabIndex = 2;
            this.radioButton_keyGen.TabStop = true;
            this.radioButton_keyGen.Text = "Ключ з криптографічного генератора \r\nпсевдовипадкових послідовностей";
            this.radioButton_keyGen.UseVisualStyleBackColor = true;
            this.radioButton_keyGen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Довжина колюча (біти)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Довжина ключа (байти)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тривалість розрахунків (мін. с.):";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(613, 354);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(55, 16);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "00:00.00";
            // 
            // button_OK
            // 
            this.button_OK.BackgroundImage = global::Parfonov_LR6_RE_21mp.Properties.Resources.key1;
            this.button_OK.Location = new System.Drawing.Point(63, 342);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(232, 38);
            this.button_OK.TabIndex = 4;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // linkLabel_author
            // 
            this.linkLabel_author.AutoSize = true;
            this.linkLabel_author.Location = new System.Drawing.Point(588, 13);
            this.linkLabel_author.Name = "linkLabel_author";
            this.linkLabel_author.Size = new System.Drawing.Size(47, 16);
            this.linkLabel_author.TabIndex = 5;
            this.linkLabel_author.TabStop = true;
            this.linkLabel_author.Text = "Автор";
            this.linkLabel_author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_author_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.linkLabel_author);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_passWord;
        private System.Windows.Forms.RadioButton radioButton_keyGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_fileKey_out;
        private System.Windows.Forms.TextBox textBox_fileKey_out;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBox_keyLength_byte;
        private System.Windows.Forms.Label label_bits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.CheckBox checkBox_hand;
        private System.Windows.Forms.CheckBox checkBox_viewPassWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_fileOpen;
        private System.Windows.Forms.Button button_fileOpen;
        private System.Windows.Forms.Button button_fileSave;
        private System.Windows.Forms.Label label_fileSave;
        private System.Windows.Forms.Button button_fileCipher;
        private System.Windows.Forms.Label label_fileCipher;
        private System.Windows.Forms.LinkLabel linkLabel_author;
    }
}

