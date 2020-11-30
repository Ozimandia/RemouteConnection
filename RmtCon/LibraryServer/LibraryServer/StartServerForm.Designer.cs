namespace LibraryServer
{
    partial class StartServerForm
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
            this.InformationText = new System.Windows.Forms.TextBox();
            this.StartServerButton = new System.Windows.Forms.Button();
            this.StopServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InformationText
            // 
            this.InformationText.Enabled = false;
            this.InformationText.Location = new System.Drawing.Point(12, 55);
            this.InformationText.Multiline = true;
            this.InformationText.Name = "InformationText";
            this.InformationText.Size = new System.Drawing.Size(260, 120);
            this.InformationText.TabIndex = 0;
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(12, 12);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(136, 37);
            this.StartServerButton.TabIndex = 2;
            this.StartServerButton.Text = "Запустить работу сервера";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // StopServerButton
            // 
            this.StopServerButton.Location = new System.Drawing.Point(154, 12);
            this.StopServerButton.Name = "StopServerButton";
            this.StopServerButton.Size = new System.Drawing.Size(118, 37);
            this.StopServerButton.TabIndex = 3;
            this.StopServerButton.Text = "Прекратить работу сервера";
            this.StopServerButton.UseVisualStyleBackColor = true;
            this.StopServerButton.Click += new System.EventHandler(this.StopServerButton_Click);
            // 
            // StartServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.StopServerButton);
            this.Controls.Add(this.StartServerButton);
            this.Controls.Add(this.InformationText);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 223);
            this.MinimumSize = new System.Drawing.Size(300, 223);
            this.Name = "StartServerForm";
            this.Text = "Сервер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartServerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InformationText;
        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.Button StopServerButton;
    }
}