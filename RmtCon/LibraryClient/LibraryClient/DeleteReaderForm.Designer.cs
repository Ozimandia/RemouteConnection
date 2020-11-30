namespace LibraryClient
{
    partial class DeleteReaderForm
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
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.DeleteReaderCardText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteLastNameText = new System.Windows.Forms.TextBox();
            this.DeleteFirstNameText = new System.Windows.Forms.TextBox();
            this.DeleteThirdNameText = new System.Windows.Forms.TextBox();
            this.DeleteAdressText = new System.Windows.Forms.TextBox();
            this.InformationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(126, 298);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteDataButton.TabIndex = 0;
            this.DeleteDataButton.Text = "Удалить данные";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // DeleteReaderCardText
            // 
            this.DeleteReaderCardText.Location = new System.Drawing.Point(129, 42);
            this.DeleteReaderCardText.Name = "DeleteReaderCardText";
            this.DeleteReaderCardText.Size = new System.Drawing.Size(237, 20);
            this.DeleteReaderCardText.TabIndex = 1;
            this.DeleteReaderCardText.TextChanged += new System.EventHandler(this.DeleteReaderCardText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите данные для их удаления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Читаетльский билет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Адрес";
            // 
            // DeleteLastNameText
            // 
            this.DeleteLastNameText.Enabled = false;
            this.DeleteLastNameText.Location = new System.Drawing.Point(129, 78);
            this.DeleteLastNameText.Name = "DeleteLastNameText";
            this.DeleteLastNameText.Size = new System.Drawing.Size(237, 20);
            this.DeleteLastNameText.TabIndex = 8;
            // 
            // DeleteFirstNameText
            // 
            this.DeleteFirstNameText.Enabled = false;
            this.DeleteFirstNameText.Location = new System.Drawing.Point(129, 115);
            this.DeleteFirstNameText.Name = "DeleteFirstNameText";
            this.DeleteFirstNameText.Size = new System.Drawing.Size(237, 20);
            this.DeleteFirstNameText.TabIndex = 9;
            // 
            // DeleteThirdNameText
            // 
            this.DeleteThirdNameText.Enabled = false;
            this.DeleteThirdNameText.Location = new System.Drawing.Point(129, 144);
            this.DeleteThirdNameText.Name = "DeleteThirdNameText";
            this.DeleteThirdNameText.Size = new System.Drawing.Size(237, 20);
            this.DeleteThirdNameText.TabIndex = 10;
            // 
            // DeleteAdressText
            // 
            this.DeleteAdressText.Enabled = false;
            this.DeleteAdressText.Location = new System.Drawing.Point(129, 174);
            this.DeleteAdressText.Multiline = true;
            this.DeleteAdressText.Name = "DeleteAdressText";
            this.DeleteAdressText.Size = new System.Drawing.Size(237, 101);
            this.DeleteAdressText.TabIndex = 11;
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(15, 338);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(351, 76);
            this.InformationText.TabIndex = 12;
            // 
            // DeleteReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 425);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.DeleteAdressText);
            this.Controls.Add(this.DeleteThirdNameText);
            this.Controls.Add(this.DeleteFirstNameText);
            this.Controls.Add(this.DeleteLastNameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteReaderCardText);
            this.Controls.Add(this.DeleteDataButton);
            this.MaximizeBox = false;
            this.Name = "DeleteReaderForm";
            this.Text = "Удалить читателей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.TextBox DeleteReaderCardText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DeleteLastNameText;
        private System.Windows.Forms.TextBox DeleteFirstNameText;
        private System.Windows.Forms.TextBox DeleteThirdNameText;
        private System.Windows.Forms.TextBox DeleteAdressText;
        private System.Windows.Forms.TextBox InformationText;
    }
}