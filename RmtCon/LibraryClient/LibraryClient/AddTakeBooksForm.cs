using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoderDecoderMessages;

namespace LibraryClient
{
    public partial class AddTakeBooksForm : Form
    {
        DataBaseOperationForm form;

        public AddTakeBooksForm(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("ATB{0}#{1}#{2}#{3}#{4}&", AddBooksCardText.Text, AddReaderCardText.Text, AddGiveDateBooksText.Text, AddTakeDateBooksText.Text, AddFactDateTakeBooksText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}, {4}", AddBooksCardText.Text, AddReaderCardText.Text, AddGiveDateBooksText.Text, AddTakeDateBooksText.Text, AddFactDateTakeBooksText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "VADSELECT * FROM [Выданные книги]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }
    }
}
