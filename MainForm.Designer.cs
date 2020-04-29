namespace SPBDnevnik
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDTP = new System.Windows.Forms.DateTimePicker();
            this.fromDTP = new System.Windows.Forms.DateTimePicker();
            this.childCB = new System.Windows.Forms.ComboBox();
            this.debug2BTN = new System.Windows.Forms.Button();
            this.debugBTN = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.debugRTB = new System.Windows.Forms.RichTextBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.toDTP);
            this.topPanel.Controls.Add(this.fromDTP);
            this.topPanel.Controls.Add(this.childCB);
            this.topPanel.Controls.Add(this.debug2BTN);
            this.topPanel.Controls.Add(this.debugBTN);
            this.topPanel.Controls.Add(this.settingsButton);
            this.topPanel.Location = new System.Drawing.Point(4, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(953, 40);
            this.topPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Период";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // toDTP
            // 
            this.toDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDTP.Location = new System.Drawing.Point(613, 10);
            this.toDTP.Name = "toDTP";
            this.toDTP.Size = new System.Drawing.Size(91, 20);
            this.toDTP.TabIndex = 5;
            // 
            // fromDTP
            // 
            this.fromDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDTP.Location = new System.Drawing.Point(511, 10);
            this.fromDTP.Name = "fromDTP";
            this.fromDTP.Size = new System.Drawing.Size(91, 20);
            this.fromDTP.TabIndex = 4;
            // 
            // childCB
            // 
            this.childCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childCB.FormattingEnabled = true;
            this.childCB.Location = new System.Drawing.Point(715, 9);
            this.childCB.Name = "childCB";
            this.childCB.Size = new System.Drawing.Size(227, 21);
            this.childCB.TabIndex = 3;
            // 
            // debug2BTN
            // 
            this.debug2BTN.BackColor = System.Drawing.SystemColors.Control;
            this.debug2BTN.Location = new System.Drawing.Point(175, 7);
            this.debug2BTN.Name = "debug2BTN";
            this.debug2BTN.Size = new System.Drawing.Size(111, 23);
            this.debug2BTN.TabIndex = 2;
            this.debug2BTN.Text = "Получить данные";
            this.debug2BTN.UseVisualStyleBackColor = false;
            this.debug2BTN.Visible = false;
            this.debug2BTN.Click += new System.EventHandler(this.debug2BTN_Click);
            // 
            // debugBTN
            // 
            this.debugBTN.BackColor = System.Drawing.SystemColors.Control;
            this.debugBTN.Location = new System.Drawing.Point(87, 7);
            this.debugBTN.Name = "debugBTN";
            this.debugBTN.Size = new System.Drawing.Size(82, 23);
            this.debugBTN.TabIndex = 1;
            this.debugBTN.Text = "Соединиться";
            this.debugBTN.UseVisualStyleBackColor = false;
            this.debugBTN.Click += new System.EventHandler(this.debugBTN_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(5, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 30);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // debugRTB
            // 
            this.debugRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugRTB.Location = new System.Drawing.Point(4, 50);
            this.debugRTB.Name = "debugRTB";
            this.debugRTB.ReadOnly = true;
            this.debugRTB.Size = new System.Drawing.Size(948, 479);
            this.debugRTB.TabIndex = 1;
            this.debugRTB.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(964, 541);
            this.Controls.Add(this.debugRTB);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный дневник";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button debugBTN;
        private System.Windows.Forms.RichTextBox debugRTB;
        private System.Windows.Forms.Button debug2BTN;
        private System.Windows.Forms.ComboBox childCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDTP;
        private System.Windows.Forms.DateTimePicker fromDTP;
    }
}

