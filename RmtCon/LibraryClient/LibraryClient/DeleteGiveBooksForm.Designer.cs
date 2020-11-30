namespace LibraryClient
{
    partial class DeleteGiveBooksForm
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
            this.DeleteIDText = new System.Windows.Forms.TextBox();
            this.DeleteDateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteBooksCardText = new System.Windows.Forms.TextBox();
            this.DeleteReaderCardText = new System.Windows.Forms.TextBox();
            this.DeleteDateGiveText = new System.Windows.Forms.TextBox();
            this.DeleteDateTakeText = new System.Windows.Forms.TextBox();
            this.DeleteFactDateTakeText = new System.Windows.Forms.TextBox();
            this.InformationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные для их удаления:";
            // 
            // DeleteIDText
            // 
            this.DeleteIDText.Location = new System.Drawing.Point(197, 46);
            this.DeleteIDText.Name = "DeleteIDText";
            this.DeleteIDText.Size = new System.Drawing.Size(202, 20);
            this.DeleteIDText.TabIndex = 1;
            this.DeleteIDText.TextChanged += new System.EventHandler(this.DeleteIDText_TextChanged);
            // 
            // DeleteDateButton
            // 
            this.DeleteDateButton.Location = new System.Drawing.Point(135, 280);
            this.DeleteDateButton.Name = "DeleteDateButton";
            this.DeleteDateButton.Size = new System.Drawing.Size(107, 23);
            this.DeleteDateButton.TabIndex = 2;
            this.DeleteDateButton.Text = "Удалить данные";
            this.DeleteDateButton.UseVisualStyleBackColor = true;
            this.DeleteDateButton.Click += new System.EventHandler(this.DeleteDateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Шифр книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Читательский билет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата выдачи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата поступления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата фактического возвращения";
            // 
            // DeleteBooksCardText
            // 
            this.DeleteBooksCardText.Enabled = false;
            this.DeleteBooksCardText.Location = new System.Drawing.Point(197, 78);
            this.DeleteBooksCardText.Name = "DeleteBooksCardText";
            this.DeleteBooksCardText.Size = new System.Drawing.Size(202, 20);
            this.DeleteBooksCardText.TabIndex = 9;
            // 
            // DeleteReaderCardText
            // 
            this.DeleteReaderCardText.Enabled = false;
            this.DeleteReaderCardText.Location = new System.Drawing.Point(197, 114);
            this.DeleteReaderCardText.Name = "DeleteReaderCardText";
            this.DeleteReaderCardText.Size = new System.Drawing.Size(202, 20);
            this.DeleteReaderCardText.TabIndex = 10;
            // 
            // DeleteDateGiveText
            // 
            this.DeleteDateGiveText.Enabled = false;
            this.DeleteDateGiveText.Location = new System.Drawing.Point(197, 154);
            this.DeleteDateGiveText.Name = "DeleteDateGiveText";
            this.DeleteDateGiveText.Size = new System.Drawing.Size(202, 20);
            this.DeleteDateGiveText.TabIndex = 11;
            // 
            // DeleteDateTakeText
            // 
            this.DeleteDateTakeText.Enabled = false;
            this.DeleteDateTakeText.Location = new System.Drawing.Point(197, 193);
            this.DeleteDateTakeText.Name = "DeleteDateTakeText";
            this.DeleteDateTakeText.Size = new System.Drawing.Size(202, 20);
            this.DeleteDateTakeText.TabIndex = 12;
            // 
            // DeleteFactDateTakeText
            // 
            this.DeleteFactDateTakeText.Enabled = false;
            this.DeleteFactDateTakeText.Location = new System.Drawing.Point(197, 232);
            this.DeleteFactDateTakeText.Name = "DeleteFactDateTakeText";
            this.DeleteFactDateTakeText.Size = new System.Drawing.Size(202, 20);
            this.DeleteFactDateTakeText.TabIndex = 13;
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(12, 322);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(387, 95);
            this.InformationText.TabIndex = 14;
            // 
            // DeleteGiveBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 429);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.DeleteFactDateTakeText);
            this.Controls.Add(this.DeleteDateTakeText);
            this.Controls.Add(this.DeleteDateGiveText);
            this.Controls.Add(this.DeleteReaderCardText);
            this.Controls.Add(this.DeleteBooksCardText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteDateButton);
            this.Controls.Add(this.DeleteIDText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(427, 468);
            this.MinimumSize = new System.Drawing.Size(427, 468);
            this.Name = "DeleteGiveBooksForm";
            this.Text = "Удаление выданных книг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteIDText;
        private System.Windows.Forms.Button DeleteDateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DeleteBooksCardText;
        private System.Windows.Forms.TextBox DeleteReaderCardText;
        private System.Windows.Forms.TextBox DeleteDateGiveText;
        private System.Windows.Forms.TextBox DeleteDateTakeText;
        private System.Windows.Forms.TextBox DeleteFactDateTakeText;
        private System.Windows.Forms.TextBox InformationText;
    }
}