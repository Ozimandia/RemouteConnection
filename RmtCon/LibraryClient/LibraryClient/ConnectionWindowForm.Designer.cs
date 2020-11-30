namespace LibraryClient
{
    partial class ConnectionWindowForm
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
            this.InformationText = new System.Windows.Forms.TextBox();
            this.ServerIPText = new System.Windows.Forms.TextBox();
            this.DataBaseNameText = new System.Windows.Forms.TextBox();
            this.ConnectServerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(16, 175);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(256, 74);
            this.InformationText.TabIndex = 0;
            // 
            // ServerIPText
            // 
            this.ServerIPText.Location = new System.Drawing.Point(117, 42);
            this.ServerIPText.Name = "ServerIPText";
            this.ServerIPText.Size = new System.Drawing.Size(138, 20);
            this.ServerIPText.TabIndex = 1;
            // 
            // DataBaseNameText
            // 
            this.DataBaseNameText.Location = new System.Drawing.Point(117, 104);
            this.DataBaseNameText.Name = "DataBaseNameText";
            this.DataBaseNameText.Size = new System.Drawing.Size(138, 20);
            this.DataBaseNameText.TabIndex = 2;
            // 
            // ConnectServerButton
            // 
            this.ConnectServerButton.Location = new System.Drawing.Point(98, 140);
            this.ConnectServerButton.Name = "ConnectServerButton";
            this.ConnectServerButton.Size = new System.Drawing.Size(95, 23);
            this.ConnectServerButton.TabIndex = 3;
            this.ConnectServerButton.Text = "Подключиться";
            this.ConnectServerButton.UseVisualStyleBackColor = true;
            this.ConnectServerButton.Click += new System.EventHandler(this.ConnectServerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите данные для удаленного доступа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP сервера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя базы данных";
            // 
            // ConnectionWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectServerButton);
            this.Controls.Add(this.DataBaseNameText);
            this.Controls.Add(this.ServerIPText);
            this.Controls.Add(this.InformationText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ConnectionWindowForm";
            this.Text = "Окно подключения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectionWindowForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InformationText;
        private System.Windows.Forms.TextBox ServerIPText;
        private System.Windows.Forms.TextBox DataBaseNameText;
        private System.Windows.Forms.Button ConnectServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

