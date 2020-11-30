namespace LibraryClient
{
    partial class FindAvtorForm
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
            this.FindBooksButton = new System.Windows.Forms.Button();
            this.AvtorNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindBooksButton
            // 
            this.FindBooksButton.Location = new System.Drawing.Point(95, 62);
            this.FindBooksButton.Name = "FindBooksButton";
            this.FindBooksButton.Size = new System.Drawing.Size(79, 23);
            this.FindBooksButton.TabIndex = 0;
            this.FindBooksButton.Text = "Поиск книг";
            this.FindBooksButton.UseVisualStyleBackColor = true;
            this.FindBooksButton.Click += new System.EventHandler(this.FindBooksButton_Click);
            // 
            // AvtorNameText
            // 
            this.AvtorNameText.Location = new System.Drawing.Point(128, 15);
            this.AvtorNameText.Name = "AvtorNameText";
            this.AvtorNameText.Size = new System.Drawing.Size(146, 20);
            this.AvtorNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите имя автора:";
            // 
            // FindAvtorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvtorNameText);
            this.Controls.Add(this.FindBooksButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(302, 135);
            this.MinimumSize = new System.Drawing.Size(302, 135);
            this.Name = "FindAvtorForm";
            this.Text = "Поиск книг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindBooksButton;
        private System.Windows.Forms.TextBox AvtorNameText;
        private System.Windows.Forms.Label label1;
    }
}