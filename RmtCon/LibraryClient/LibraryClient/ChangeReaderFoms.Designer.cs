namespace LibraryClient
{
    partial class ChangeReaderFoms
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
            this.ChangeReaderCardText = new System.Windows.Forms.TextBox();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeLastNameText = new System.Windows.Forms.TextBox();
            this.ChangeFirstNameText = new System.Windows.Forms.TextBox();
            this.ChangeThirdNameText = new System.Windows.Forms.TextBox();
            this.ChangeAdressText = new System.Windows.Forms.TextBox();
            this.InformationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные для их изменения:";
            // 
            // ChangeReaderCardText
            // 
            this.ChangeReaderCardText.Location = new System.Drawing.Point(129, 42);
            this.ChangeReaderCardText.Name = "ChangeReaderCardText";
            this.ChangeReaderCardText.Size = new System.Drawing.Size(270, 20);
            this.ChangeReaderCardText.TabIndex = 1;
            this.ChangeReaderCardText.TextChanged += new System.EventHandler(this.ChangeReaderCardText_TextChanged);
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Location = new System.Drawing.Point(129, 273);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(115, 23);
            this.ChangeDataButton.TabIndex = 2;
            this.ChangeDataButton.Text = "Изменить данные";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Читательский билет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Адрес";
            // 
            // ChangeLastNameText
            // 
            this.ChangeLastNameText.Location = new System.Drawing.Point(129, 78);
            this.ChangeLastNameText.Name = "ChangeLastNameText";
            this.ChangeLastNameText.Size = new System.Drawing.Size(270, 20);
            this.ChangeLastNameText.TabIndex = 8;
            // 
            // ChangeFirstNameText
            // 
            this.ChangeFirstNameText.Location = new System.Drawing.Point(129, 113);
            this.ChangeFirstNameText.Name = "ChangeFirstNameText";
            this.ChangeFirstNameText.Size = new System.Drawing.Size(270, 20);
            this.ChangeFirstNameText.TabIndex = 9;
            // 
            // ChangeThirdNameText
            // 
            this.ChangeThirdNameText.Location = new System.Drawing.Point(129, 147);
            this.ChangeThirdNameText.Name = "ChangeThirdNameText";
            this.ChangeThirdNameText.Size = new System.Drawing.Size(270, 20);
            this.ChangeThirdNameText.TabIndex = 10;
            // 
            // ChangeAdressText
            // 
            this.ChangeAdressText.Location = new System.Drawing.Point(129, 186);
            this.ChangeAdressText.Multiline = true;
            this.ChangeAdressText.Name = "ChangeAdressText";
            this.ChangeAdressText.Size = new System.Drawing.Size(270, 61);
            this.ChangeAdressText.TabIndex = 11;
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(12, 313);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(387, 105);
            this.InformationText.TabIndex = 12;
            // 
            // ChangeReaderFoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 430);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.ChangeAdressText);
            this.Controls.Add(this.ChangeThirdNameText);
            this.Controls.Add(this.ChangeFirstNameText);
            this.Controls.Add(this.ChangeLastNameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeDataButton);
            this.Controls.Add(this.ChangeReaderCardText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(427, 469);
            this.MinimumSize = new System.Drawing.Size(427, 469);
            this.Name = "ChangeReaderFoms";
            this.Text = "Изменение читателей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChangeReaderCardText;
        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ChangeLastNameText;
        private System.Windows.Forms.TextBox ChangeFirstNameText;
        private System.Windows.Forms.TextBox ChangeThirdNameText;
        private System.Windows.Forms.TextBox ChangeAdressText;
        private System.Windows.Forms.TextBox InformationText;
    }
}