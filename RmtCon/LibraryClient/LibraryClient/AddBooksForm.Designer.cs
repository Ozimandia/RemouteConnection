namespace LibraryClient
{
    partial class AddBooksForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddAvtorBooksText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNameBooksText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddYearBooksText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddCountBooksText = new System.Windows.Forms.TextBox();
            this.AddDataBooksButton = new System.Windows.Forms.Button();
            this.InformationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные для их добавления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор книги";
            // 
            // AddAvtorBooksText
            // 
            this.AddAvtorBooksText.Location = new System.Drawing.Point(155, 44);
            this.AddAvtorBooksText.Name = "AddAvtorBooksText";
            this.AddAvtorBooksText.Size = new System.Drawing.Size(221, 20);
            this.AddAvtorBooksText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название книги";
            // 
            // AddNameBooksText
            // 
            this.AddNameBooksText.Location = new System.Drawing.Point(155, 86);
            this.AddNameBooksText.Name = "AddNameBooksText";
            this.AddNameBooksText.Size = new System.Drawing.Size(221, 20);
            this.AddNameBooksText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Год издания";
            // 
            // AddYearBooksText
            // 
            this.AddYearBooksText.Location = new System.Drawing.Point(155, 133);
            this.AddYearBooksText.Name = "AddYearBooksText";
            this.AddYearBooksText.Size = new System.Drawing.Size(221, 20);
            this.AddYearBooksText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество экземпляров";
            // 
            // AddCountBooksText
            // 
            this.AddCountBooksText.Location = new System.Drawing.Point(155, 175);
            this.AddCountBooksText.Name = "AddCountBooksText";
            this.AddCountBooksText.Size = new System.Drawing.Size(221, 20);
            this.AddCountBooksText.TabIndex = 8;
            // 
            // AddDataBooksButton
            // 
            this.AddDataBooksButton.Location = new System.Drawing.Point(129, 232);
            this.AddDataBooksButton.Name = "AddDataBooksButton";
            this.AddDataBooksButton.Size = new System.Drawing.Size(121, 23);
            this.AddDataBooksButton.TabIndex = 9;
            this.AddDataBooksButton.Text = "Добавить данные";
            this.AddDataBooksButton.UseVisualStyleBackColor = true;
            this.AddDataBooksButton.Click += new System.EventHandler(this.AddDataBooksButton_Click);
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(16, 276);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(360, 104);
            this.InformationText.TabIndex = 10;
            // 
            // AddBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 392);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.AddDataBooksButton);
            this.Controls.Add(this.AddCountBooksText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddYearBooksText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddNameBooksText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddAvtorBooksText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 431);
            this.MinimumSize = new System.Drawing.Size(404, 431);
            this.Name = "AddBooksForm";
            this.Text = "Добать книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddAvtorBooksText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddNameBooksText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddYearBooksText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddCountBooksText;
        private System.Windows.Forms.Button AddDataBooksButton;
        private System.Windows.Forms.TextBox InformationText;
    }
}