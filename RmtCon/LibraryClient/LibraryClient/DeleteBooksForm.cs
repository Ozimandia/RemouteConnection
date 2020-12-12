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
    public partial class DeleteBooksForm : Form
    {
        DataBaseOperationForm form;

        public DeleteBooksForm(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("DDB{0}#{1}&", "Шифр книги" ,DeleteBooksCardText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}", DeleteBooksCardText.Text, DeleteAvtorText.Text, DeleteYearText.Text, DeleteCountBooksText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "BADSELECT * FROM [Книги]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }

        private void DeleteBooksCardText_TextChanged(object sender, EventArgs e)
        {
            DeleteAvtorText.Text = "";
            DeleteBooksNameText.Text = "";
            DeleteYearText.Text = "";
            DeleteCountBooksText.Text = "";

            int num = 0;
            if (int.TryParse(DeleteBooksCardText.Text, out num))
            {
                CoderDecoder decod = new CoderDecoder();

                string message = String.Format("DID{0}#{1}#Книги&", "[Шифр книги]", DeleteBooksCardText.Text);
                message = form.client.SendMessage(message);

                string[] data = decod.DecodMessage1(message);

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "#" || data[i] == "" || data[i] == null)
                    {
                        data[i] = "";
                    }
                }

                DeleteAvtorText.Text = data[1].TrimEnd();
                DeleteBooksNameText.Text = data[2].TrimEnd();
                DeleteYearText.Text = data[3].TrimEnd();
                DeleteCountBooksText.Text = data[4].TrimEnd();
            }
        }
    }
}
