namespace LibraryClient
{
    partial class DataBaseOperationForm
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вывестиДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вывестиДанныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выданныеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДанныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выданныеКнигиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.выданныеКнигиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.выданныеКнигиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.особыеЗапросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиПосле2007ГToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиОпределенногоАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(640, 729);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиДанныеToolStripMenuItem,
            this.добавитьДанныеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
            // 
            // вывестиДанныеToolStripMenuItem
            // 
            this.вывестиДанныеToolStripMenuItem.Name = "вывестиДанныеToolStripMenuItem";
            this.вывестиДанныеToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.вывестиДанныеToolStripMenuItem.Text = "Вывести данные";
            // 
            // добавитьДанныеToolStripMenuItem
            // 
            this.добавитьДанныеToolStripMenuItem.Name = "добавитьДанныеToolStripMenuItem";
            this.добавитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.добавитьДанныеToolStripMenuItem.Text = "Добавить данные";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиДанныеToolStripMenuItem1,
            this.добавитьДанныеToolStripMenuItem1,
            this.удалитьДанныеToolStripMenuItem,
            this.изменитьДанныеToolStripMenuItem,
            this.особыеЗапросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вывестиДанныеToolStripMenuItem1
            // 
            this.вывестиДанныеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.читателиToolStripMenuItem,
            this.выданныеКнигиToolStripMenuItem});
            this.вывестиДанныеToolStripMenuItem1.Name = "вывестиДанныеToolStripMenuItem1";
            this.вывестиДанныеToolStripMenuItem1.Size = new System.Drawing.Size(109, 20);
            this.вывестиДанныеToolStripMenuItem1.Text = "Вывести данные";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.книгиToolStripMenuItem.Text = "Книги";
            this.книгиToolStripMenuItem.Click += new System.EventHandler(this.книгиToolStripMenuItem_Click);
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.читателиToolStripMenuItem.Text = "Читатели";
            this.читателиToolStripMenuItem.Click += new System.EventHandler(this.читателиToolStripMenuItem_Click);
            // 
            // выданныеКнигиToolStripMenuItem
            // 
            this.выданныеКнигиToolStripMenuItem.Name = "выданныеКнигиToolStripMenuItem";
            this.выданныеКнигиToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.выданныеКнигиToolStripMenuItem.Text = "Выданные книги";
            this.выданныеКнигиToolStripMenuItem.Click += new System.EventHandler(this.выданныеКнигиToolStripMenuItem_Click);
            // 
            // добавитьДанныеToolStripMenuItem1
            // 
            this.добавитьДанныеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem1,
            this.читателиToolStripMenuItem1,
            this.выданныеКнигиToolStripMenuItem1});
            this.добавитьДанныеToolStripMenuItem1.Name = "добавитьДанныеToolStripMenuItem1";
            this.добавитьДанныеToolStripMenuItem1.Size = new System.Drawing.Size(115, 20);
            this.добавитьДанныеToolStripMenuItem1.Text = "Добавить данные";
            // 
            // книгиToolStripMenuItem1
            // 
            this.книгиToolStripMenuItem1.Name = "книгиToolStripMenuItem1";
            this.книгиToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.книгиToolStripMenuItem1.Text = "Книги ";
            this.книгиToolStripMenuItem1.Click += new System.EventHandler(this.книгиToolStripMenuItem1_Click);
            // 
            // читателиToolStripMenuItem1
            // 
            this.читателиToolStripMenuItem1.Name = "читателиToolStripMenuItem1";
            this.читателиToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.читателиToolStripMenuItem1.Text = "Читатели";
            this.читателиToolStripMenuItem1.Click += new System.EventHandler(this.читателиToolStripMenuItem1_Click);
            // 
            // выданныеКнигиToolStripMenuItem1
            // 
            this.выданныеКнигиToolStripMenuItem1.Name = "выданныеКнигиToolStripMenuItem1";
            this.выданныеКнигиToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.выданныеКнигиToolStripMenuItem1.Text = "Выданные книги";
            this.выданныеКнигиToolStripMenuItem1.Click += new System.EventHandler(this.выданныеКнигиToolStripMenuItem1_Click);
            // 
            // удалитьДанныеToolStripMenuItem
            // 
            this.удалитьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem2,
            this.читателиToolStripMenuItem2,
            this.выданныеКнигиToolStripMenuItem2});
            this.удалитьДанныеToolStripMenuItem.Name = "удалитьДанныеToolStripMenuItem";
            this.удалитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.удалитьДанныеToolStripMenuItem.Text = "Удалить данные";
            // 
            // книгиToolStripMenuItem2
            // 
            this.книгиToolStripMenuItem2.Name = "книгиToolStripMenuItem2";
            this.книгиToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.книгиToolStripMenuItem2.Text = "Книги";
            this.книгиToolStripMenuItem2.Click += new System.EventHandler(this.книгиToolStripMenuItem2_Click);
            // 
            // читателиToolStripMenuItem2
            // 
            this.читателиToolStripMenuItem2.Name = "читателиToolStripMenuItem2";
            this.читателиToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.читателиToolStripMenuItem2.Text = "Читатели";
            this.читателиToolStripMenuItem2.Click += new System.EventHandler(this.читателиToolStripMenuItem2_Click);
            // 
            // выданныеКнигиToolStripMenuItem2
            // 
            this.выданныеКнигиToolStripMenuItem2.Name = "выданныеКнигиToolStripMenuItem2";
            this.выданныеКнигиToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
            this.выданныеКнигиToolStripMenuItem2.Text = "Выданные книги";
            this.выданныеКнигиToolStripMenuItem2.Click += new System.EventHandler(this.выданныеКнигиToolStripMenuItem2_Click);
            // 
            // изменитьДанныеToolStripMenuItem
            // 
            this.изменитьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem3,
            this.читателиToolStripMenuItem3,
            this.выданныеКнигиToolStripMenuItem3});
            this.изменитьДанныеToolStripMenuItem.Name = "изменитьДанныеToolStripMenuItem";
            this.изменитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.изменитьДанныеToolStripMenuItem.Text = "Изменить данные";
            // 
            // книгиToolStripMenuItem3
            // 
            this.книгиToolStripMenuItem3.Name = "книгиToolStripMenuItem3";
            this.книгиToolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
            this.книгиToolStripMenuItem3.Text = "Книги";
            this.книгиToolStripMenuItem3.Click += new System.EventHandler(this.книгиToolStripMenuItem3_Click);
            // 
            // читателиToolStripMenuItem3
            // 
            this.читателиToolStripMenuItem3.Name = "читателиToolStripMenuItem3";
            this.читателиToolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
            this.читателиToolStripMenuItem3.Text = "Читатели";
            this.читателиToolStripMenuItem3.Click += new System.EventHandler(this.читателиToolStripMenuItem3_Click);
            // 
            // выданныеКнигиToolStripMenuItem3
            // 
            this.выданныеКнигиToolStripMenuItem3.Name = "выданныеКнигиToolStripMenuItem3";
            this.выданныеКнигиToolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
            this.выданныеКнигиToolStripMenuItem3.Text = "Выданные книги";
            this.выданныеКнигиToolStripMenuItem3.Click += new System.EventHandler(this.выданныеКнигиToolStripMenuItem3_Click);
            // 
            // особыеЗапросыToolStripMenuItem
            // 
            this.особыеЗапросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиПосле2007ГToolStripMenuItem,
            this.книгиОпределенногоАвтораToolStripMenuItem});
            this.особыеЗапросыToolStripMenuItem.Name = "особыеЗапросыToolStripMenuItem";
            this.особыеЗапросыToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.особыеЗапросыToolStripMenuItem.Text = "Особые запросы";
            // 
            // книгиПосле2007ГToolStripMenuItem
            // 
            this.книгиПосле2007ГToolStripMenuItem.Name = "книгиПосле2007ГToolStripMenuItem";
            this.книгиПосле2007ГToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.книгиПосле2007ГToolStripMenuItem.Text = "Книги после 2007 г.";
            this.книгиПосле2007ГToolStripMenuItem.Click += new System.EventHandler(this.книгиПосле2007ГToolStripMenuItem_Click);
            // 
            // книгиОпределенногоАвтораToolStripMenuItem
            // 
            this.книгиОпределенногоАвтораToolStripMenuItem.Name = "книгиОпределенногоАвтораToolStripMenuItem";
            this.книгиОпределенногоАвтораToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.книгиОпределенногоАвтораToolStripMenuItem.Text = "Книги определенного автора";
            this.книгиОпределенногоАвтораToolStripMenuItem.Click += new System.EventHandler(this.книгиОпределенногоАвтораToolStripMenuItem_Click);
            // 
            // DataBaseOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 768);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 807);
            this.MinimumSize = new System.Drawing.Size(680, 807);
            this.Name = "DataBaseOperationForm";
            this.Text = "Окно пользователя";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вывестиДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДанныеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вывестиДанныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выданныеКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДанныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выданныеКнигиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выданныеКнигиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem выданныеКнигиToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem особыеЗапросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиПосле2007ГToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиОпределенногоАвтораToolStripMenuItem;
    }
}