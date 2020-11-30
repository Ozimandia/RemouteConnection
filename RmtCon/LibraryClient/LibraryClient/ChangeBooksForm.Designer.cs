namespace LibraryClient
{
    partial class ChangeBooksForm
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
            this.lable1 = new System.Windows.Forms.Label();
            this.ChangeBooksCardsText = new System.Windows.Forms.TextBox();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangeAvtorText = new System.Windows.Forms.TextBox();
            this.ChangeNameText = new System.Windows.Forms.TextBox();
            this.ChangeYearText = new System.Windows.Forms.TextBox();
            this.ChangeCountText = new System.Windows.Forms.TextBox();
            this.InformationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(12, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(187, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Введите данные для их изменения:";
            // 
            // ChangeBooksCardsText
            // 
            this.ChangeBooksCardsText.Location = new System.Drawing.Point(155, 41);
            this.ChangeBooksCardsText.Name = "ChangeBooksCardsText";
            this.ChangeBooksCardsText.Size = new System.Drawing.Size(221, 20);
            this.ChangeBooksCardsText.TabIndex = 1;
            this.ChangeBooksCardsText.TextChanged += new System.EventHandler(this.ChangeBooksCardsText_TextChanged);
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Location = new System.Drawing.Point(125, 235);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(119, 23);
            this.ChangeDataButton.TabIndex = 2;
            this.ChangeDataButton.Text = "Изменить данные";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Шифр книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор книги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Год издания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество экземпляров";
            // 
            // ChangeAvtorText
            // 
            this.ChangeAvtorText.Location = new System.Drawing.Point(155, 75);
            this.ChangeAvtorText.Name = "ChangeAvtorText";
            this.ChangeAvtorText.Size = new System.Drawing.Size(221, 20);
            this.ChangeAvtorText.TabIndex = 8;
            // 
            // ChangeNameText
            // 
            this.ChangeNameText.Location = new System.Drawing.Point(155, 113);
            this.ChangeNameText.Name = "ChangeNameText";
            this.ChangeNameText.Size = new System.Drawing.Size(221, 20);
            this.ChangeNameText.TabIndex = 9;
            // 
            // ChangeYearText
            // 
            this.ChangeYearText.Location = new System.Drawing.Point(155, 150);
            this.ChangeYearText.Name = "ChangeYearText";
            this.ChangeYearText.Size = new System.Drawing.Size(221, 20);
            this.ChangeYearText.TabIndex = 10;
            // 
            // ChangeCountText
            // 
            this.ChangeCountText.Location = new System.Drawing.Point(155, 186);
            this.ChangeCountText.Name = "ChangeCountText";
            this.ChangeCountText.Size = new System.Drawing.Size(221, 20);
            this.ChangeCountText.TabIndex = 11;
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(15, 274);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(361, 95);
            this.InformationText.TabIndex = 12;
            // 
            // ChangeBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 381);
            this.Controls.Add(this.InformationText);
            this.Controls.Add(this.ChangeCountText);
            this.Controls.Add(this.ChangeYearText);
            this.Controls.Add(this.ChangeNameText);
            this.Controls.Add(this.ChangeAvtorText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeDataButton);
            this.Controls.Add(this.ChangeBooksCardsText);
            this.Controls.Add(this.lable1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 420);
            this.MinimumSize = new System.Drawing.Size(404, 420);
            this.Name = "ChangeBooksForm";
            this.Text = "Изменение книг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox ChangeBooksCardsText;
        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ChangeAvtorText;
        private System.Windows.Forms.TextBox ChangeNameText;
        private System.Windows.Forms.TextBox ChangeYearText;
        private System.Windows.Forms.TextBox ChangeCountText;
        private System.Windows.Forms.TextBox InformationText;
    }
}