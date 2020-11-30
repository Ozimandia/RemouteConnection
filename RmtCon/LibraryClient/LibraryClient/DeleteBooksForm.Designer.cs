namespace LibraryClient
{
    partial class DeleteBooksForm
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
            this.DeleteBooksCardText = new System.Windows.Forms.TextBox();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteAvtorText = new System.Windows.Forms.TextBox();
            this.DeleteBooksNameText = new System.Windows.Forms.TextBox();
            this.DeleteYearText = new System.Windows.Forms.TextBox();
            this.DeleteCountBooksText = new System.Windows.Forms.TextBox();
            this.InformationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные для их удаления:";
            // 
            // DeleteBooksCardText
            // 
            this.DeleteBooksCardText.Location = new System.Drawing.Point(156, 43);
            this.DeleteBooksCardText.Name = "DeleteBooksCardText";
            this.DeleteBooksCardText.Size = new System.Drawing.Size(230, 20);
            this.DeleteBooksCardText.TabIndex = 1;
            this.DeleteBooksCardText.TextChanged += new System.EventHandler(this.DeleteBooksCardText_TextChanged);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(142, 247);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(110, 23);
            this.DeleteDataButton.TabIndex = 2;
            this.DeleteDataButton.Text = "Удалить данные";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шифр книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Название книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Год издания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Количество экземпляров";
            // 
            // DeleteAvtorText
            // 
            this.DeleteAvtorText.Enabled = false;
            this.DeleteAvtorText.Location = new System.Drawing.Point(156, 84);
            this.DeleteAvtorText.Name = "DeleteAvtorText";
            this.DeleteAvtorText.Size = new System.Drawing.Size(230, 20);
            this.DeleteAvtorText.TabIndex = 8;
            // 
            // DeleteBooksNameText
            // 
            this.DeleteBooksNameText.Enabled = false;
            this.DeleteBooksNameText.Location = new System.Drawing.Point(156, 125);
            this.DeleteBooksNameText.Name = "DeleteBooksNameText";
            this.DeleteBooksNameText.Size = new System.Drawing.Size(230, 20);
            this.DeleteBooksNameText.TabIndex = 9;
            // 
            // DeleteYearText
            // 
            this.DeleteYearText.Enabled = false;
            this.DeleteYearText.Location = new System.Drawing.Point(156, 163);
            this.DeleteYearText.Name = "DeleteYearText";
            this.DeleteYearText.Size = new System.Drawing.Size(230, 20);
            this.DeleteYearText.TabIndex = 10;
            // 
            // DeleteCountBooksText
            // 
            this.DeleteCountBooksText.Enabled = false;
            this.DeleteCountBooksText.Location = new System.Drawing.Point(156, 199);
            this.DeleteCountBooksText.Name = "DeleteCountBooksText";
            this.DeleteCountBooksText.Size = new System.Drawing.Size(230, 20);
            this.DeleteCountBooksText.TabIndex = 11;
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(16, 285);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(370, 92);
            this.InformationText.TabIndex = 12;
            // 
            // DeleteBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 389);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.DeleteCountBooksText);
            this.Controls.Add(this.DeleteYearText);
            this.Controls.Add(this.DeleteBooksNameText);
            this.Controls.Add(this.DeleteAvtorText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.DeleteBooksCardText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 428);
            this.MinimumSize = new System.Drawing.Size(414, 428);
            this.Name = "DeleteBooksForm";
            this.Text = "Удаление книг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteBooksCardText;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DeleteAvtorText;
        private System.Windows.Forms.TextBox DeleteBooksNameText;
        private System.Windows.Forms.TextBox DeleteYearText;
        private System.Windows.Forms.TextBox DeleteCountBooksText;
        private System.Windows.Forms.TextBox InformationText;
    }
}