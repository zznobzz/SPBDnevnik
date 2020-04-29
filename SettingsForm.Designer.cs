namespace SPBDnevnik
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.saveBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.attachFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFolderTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ofdBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(10, 153);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(106, 23);
            this.saveBTN.TabIndex = 0;
            this.saveBTN.Text = "Сохранить";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBTN.Location = new System.Drawing.Point(212, 153);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(106, 23);
            this.cancelBTN.TabIndex = 1;
            this.cancelBTN.Text = "Отмена";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите логин и пароль от petersburgedu.ru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(70, 32);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(248, 21);
            this.loginTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(70, 63);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(248, 21);
            this.passwordTB.TabIndex = 6;
            this.passwordTB.WordWrap = false;
            // 
            // saveFolderTB
            // 
            this.saveFolderTB.Location = new System.Drawing.Point(10, 121);
            this.saveFolderTB.Name = "saveFolderTB";
            this.saveFolderTB.Size = new System.Drawing.Size(266, 21);
            this.saveFolderTB.TabIndex = 7;
            this.saveFolderTB.DoubleClick += new System.EventHandler(this.saveFolderTB_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите папку для сохранения вложений:";
            // 
            // ofdBTN
            // 
            this.ofdBTN.Location = new System.Drawing.Point(281, 119);
            this.ofdBTN.Name = "ofdBTN";
            this.ofdBTN.Size = new System.Drawing.Size(37, 23);
            this.ofdBTN.TabIndex = 9;
            this.ofdBTN.Text = "...";
            this.ofdBTN.UseVisualStyleBackColor = true;
            this.ofdBTN.Click += new System.EventHandler(this.ofdBTN_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.saveBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBTN;
            this.ClientSize = new System.Drawing.Size(330, 179);
            this.Controls.Add(this.ofdBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveFolderTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.saveBTN);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Настройки программы";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.FolderBrowserDialog attachFBD;
        private System.Windows.Forms.TextBox saveFolderTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ofdBTN;
    }
}