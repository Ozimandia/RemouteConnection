using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPprotocol;
using CoderDecoderMessages;

namespace LibraryClient
{
    public partial class DataBaseOperationForm : Form
    {
        public UseClient client;

        public DataBaseOperationForm()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------------------
        // ОТОБРАЖЕНИЕ ДАННЫХ НА LISTVIEW

        public ListView ShowDataListView(ListView listView, string[,] Data)
        {
            if (Data == null) throw new Exception("Массив Data не инициализирован. Необходимо вызвать метод ReciveData, или ReciveDataID");

            // Set the view to show details.
            listView.View = View.Details;
            // Allow the user to edit item text.
            listView.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView.AllowColumnReorder = true;
            // Display check boxes.
            listView.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView.FullRowSelect = true;
            // Display grid lines.
            listView.GridLines = true;

            listView.Columns.Clear();
            listView.Items.Clear();

            ListViewItem[] items = new ListViewItem[Data.GetLength(0) - 1];

            for (int i = 1; i < Data.GetLength(0); i++)
            {
                items[i - 1] = new ListViewItem();

                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    items[i - 1].SubItems.Add(Data[i, j]);
                }
            }

            listView.Columns.Add("Column item", -2, HorizontalAlignment.Center);

            for (int i = 0; i < Data.GetLength(1); i++) // Создание колонок
            {
                listView.Columns.Add(Data[0, i], -2, HorizontalAlignment.Center);
                listView.Columns[i].Width = 70;
            }

            listView.Items.AddRange(items);

            return listView;
        }
        //---------------------------------------------------------------------------------------
        // ПОИСК КНИГ ДО ПОСЛЕ 2007 ГОДА

        private void книгиПосле2007ГToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoderDecoder decod = new CoderDecoder();

            string message = "BFDSELECT * FROM [Книги] WHERE [Год издания] >= 2007";
            message = client.SendMessage(message);

            listView1 = ShowDataListView(listView1, decod.DecodMessage2(message));
        }
        //---------------------------------------------------------------------------------------
        // ОТОБРЖАНИЕ ФОРМЫ ДЛЯ ПОИСКА КНИГ ПО ЗАДАННОМУ АВТОРУ

        private void книгиОпределенногоАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindAvtorForm form = new FindAvtorForm(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // ВЫВОД ВСЕХ КНИГ

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoderDecoder decod = new CoderDecoder();

            string message = "BADSELECT * FROM [Книги]";
            message = client.SendMessage(message);

            listView1 = ShowDataListView(listView1, decod.DecodMessage2(message));
        }
        //---------------------------------------------------------------------------------------
        // ВЫВОД ВСЕХ ЧИТАТЕЛЕЙ

        private void читателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoderDecoder decod = new CoderDecoder();

            string message = "RADSELECT * FROM [Читатели]";
            message = client.SendMessage(message);

            listView1 = ShowDataListView(listView1, decod.DecodMessage2(message));
        }
        //---------------------------------------------------------------------------------------
        // ВЫВОД ВСЕХ ВЫДАННЫХ КНИГ

        private void выданныеКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoderDecoder decod = new CoderDecoder();

            string message = "VADSELECT * FROM [Выданные книги]";
            message = client.SendMessage(message);

            listView1 = ShowDataListView(listView1, decod.DecodMessage2(message));
        }
        //---------------------------------------------------------------------------------------
        // ДОБАВЛЕНИЕ КНИГ

        private void книгиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddBooksForm form = new AddBooksForm(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // ДОБАВЛЕНИЕ ЧИТАТЕЛЕЙ

        private void читателиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddReadersForm form = new AddReadersForm(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // ДОБАВЛЕНИЕ ВЫДАННЫХ КНИГ

        private void выданныеКнигиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTakeBooksForm form = new AddTakeBooksForm(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // УДАЛЕНИЕ КНИГ

        private void книгиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteBooksForm form = new DeleteBooksForm(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // УДАЛЕНИЕ ЧИТАТЕЛЕЙ

        private void читателиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteReaderForm form = new DeleteReaderForm(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // УДАЛЕНИЕ ВЫДАННЫХ КНИГ

        private void выданныеКнигиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteGiveBooksForm form = new DeleteGiveBooksForm(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // ИЗМЕНЕНИЕ КНИГ

        private void книгиToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChangeBooksForm form = new ChangeBooksForm(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // ИЗМЕНЕНИЕ ЧИТАТЕЛЕЙ

        private void читателиToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChangeReaderFoms form = new ChangeReaderFoms(this);
            form.Show();
        }
        //---------------------------------------------------------------------------------------
        // ИЗМЕНЕНИЕ ВЫДАННЫХ КНИГ

        private void выданныеКнигиToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChangeGiveBooksForm form = new ChangeGiveBooksForm(this);
            form.Show();
        }
    }
}
