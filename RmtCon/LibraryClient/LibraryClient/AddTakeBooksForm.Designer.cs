namespace LibraryClient
{
    partial class AddTakeBooksForm
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
            this.AddDataButton = new System.Windows.Forms.Button();
            this.AddBooksCardText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddReaderCardText = new System.Windows.Forms.TextBox();
            this.AddGiveDateBooksText = new System.Windows.Forms.TextBox();
            this.AddTakeDateBooksText = new System.Windows.Forms.TextBox();
            this.AddFactDateTakeBooksText = new System.Windows.Forms.TextBox();
            this.InformationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные выданных книг для их добаления:";
            // 
            // AddDataButton
            // 
            this.AddDataButton.Location = new System.Drawing.Point(150, 248);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(114, 23);
            this.AddDataButton.TabIndex = 1;
            this.AddDataButton.Text = "Добавить данные";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // AddBooksCardText
            // 
            this.AddBooksCardText.Location = new System.Drawing.Point(197, 40);
            this.AddBooksCardText.Name = "AddBooksCardText";
            this.AddBooksCardText.Size = new System.Drawing.Size(195, 20);
            this.AddBooksCardText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шифр книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Читательский билет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата выдачи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата возвращения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата фактического возвращения";
            // 
            // AddReaderCardText
            // 
            this.AddReaderCardText.Location = new System.Drawing.Point(197, 81);
            this.AddReaderCardText.Name = "AddReaderCardText";
            this.AddReaderCardText.Size = new System.Drawing.Size(195, 20);
            this.AddReaderCardText.TabIndex = 8;
            // 
            // AddGiveDateBooksText
            // 
            this.AddGiveDateBooksText.Location = new System.Drawing.Point(197, 120);
            this.AddGiveDateBooksText.Name = "AddGiveDateBooksText";
            this.AddGiveDateBooksText.Size = new System.Drawing.Size(195, 20);
            this.AddGiveDateBooksText.TabIndex = 9;
            // 
            // AddTakeDateBooksText
            // 
            this.AddTakeDateBooksText.Location = new System.Drawing.Point(197, 157);
            this.AddTakeDateBooksText.Name = "AddTakeDateBooksText";
            this.AddTakeDateBooksText.Size = new System.Drawing.Size(195, 20);
            this.AddTakeDateBooksText.TabIndex = 10;
            // 
            // AddFactDateTakeBooksText
            // 
            this.AddFactDateTakeBooksText.Location = new System.Drawing.Point(197, 195);
            this.AddFactDateTakeBooksText.Name = "AddFactDateTakeBooksText";
            this.AddFactDateTakeBooksText.Size = new System.Drawing.Size(195, 20);
            this.AddFactDateTakeBooksText.TabIndex = 11;
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(12, 284);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(380, 97);
            this.InformationText.TabIndex = 12;
            // 
            // AddTakeBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 393);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.AddFactDateTakeBooksText);
            this.Controls.Add(this.AddTakeDateBooksText);
            this.Controls.Add(this.AddGiveDateBooksText);
            this.Controls.Add(this.AddReaderCardText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBooksCardText);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 432);
            this.MinimumSize = new System.Drawing.Size(420, 432);
            this.Name = "AddTakeBooksForm";
            this.Text = "Добавить выданные книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.TextBox AddBooksCardText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddReaderCardText;
        private System.Windows.Forms.TextBox AddGiveDateBooksText;
        private System.Windows.Forms.TextBox AddTakeDateBooksText;
        private System.Windows.Forms.TextBox AddFactDateTakeBooksText;
        private System.Windows.Forms.TextBox InformationText;
    }
}