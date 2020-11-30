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
    public partial class AddBooksForm : Form
    {
        DataBaseOperationForm form;

        public AddBooksForm(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void AddDataBooksButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("ADB{0}#{1}#{2}#{3}&", AddAvtorBooksText.Text, AddNameBooksText.Text, AddYearBooksText.Text, AddCountBooksText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}", AddAvtorBooksText.Text, AddNameBooksText.Text, AddYearBooksText.Text, AddCountBooksText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "BADSELECT * FROM [Книги]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }
    }
}
