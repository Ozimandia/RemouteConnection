namespace LibraryClient
{
    partial class AddReadersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddReaderDataButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddReaderLastNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddFirstNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddThirdNameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddAdressText = new System.Windows.Forms.TextBox();
            this.InformationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные о читателях для их добавления:";
            // 
            // AddReaderDataButton
            // 
            this.AddReaderDataButton.Location = new System.Drawing.Point(154, 215);
            this.AddReaderDataButton.Name = "AddReaderDataButton";
            this.AddReaderDataButton.Size = new System.Drawing.Size(111, 23);
            this.AddReaderDataButton.TabIndex = 2;
            this.AddReaderDataButton.Text = "Добавить данные";
            this.AddReaderDataButton.UseVisualStyleBackColor = true;
            this.AddReaderDataButton.Click += new System.EventHandler(this.AddReaderDataButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // AddReaderLastNameText
            // 
            this.AddReaderLastNameText.Location = new System.Drawing.Point(129, 35);
            this.AddReaderLastNameText.Name = "AddReaderLastNameText";
            this.AddReaderLastNameText.Size = new System.Drawing.Size(293, 20);
            this.AddReaderLastNameText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя";
            // 
            // AddFirstNameText
            // 
            this.AddFirstNameText.Location = new System.Drawing.Point(129, 83);
            this.AddFirstNameText.Name = "AddFirstNameText";
            this.AddFirstNameText.Size = new System.Drawing.Size(293, 20);
            this.AddFirstNameText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Отчество";
            // 
            // AddThirdNameText
            // 
            this.AddThirdNameText.Location = new System.Drawing.Point(129, 122);
            this.AddThirdNameText.Name = "AddThirdNameText";
            this.AddThirdNameText.Size = new System.Drawing.Size(293, 20);
            this.AddThirdNameText.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Адрес";
            // 
            // AddAdressText
            // 
            this.AddAdressText.Location = new System.Drawing.Point(129, 158);
            this.AddAdressText.Name = "AddAdressText";
            this.AddAdressText.Size = new System.Drawing.Size(293, 20);
            this.AddAdressText.TabIndex = 11;
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(15, 254);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(407, 108);
            this.InformationText.TabIndex = 12;
            // 
            // AddReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 371);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.AddAdressText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddThirdNameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddFirstNameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddReaderLastNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddReaderDataButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 410);
            this.MinimumSize = new System.Drawing.Size(450, 410);
            this.Name = "AddReadersForm";
            this.Text = "Добавить читателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddReaderDataButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddReaderLastNameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddFirstNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddThirdNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddAdressText;
        private System.Windows.Forms.TextBox InformationText;
    }
}