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
    public partial class DeleteGiveBooksForm : Form
    {
        DataBaseOperationForm form;

        public DeleteGiveBooksForm(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void DeleteDateButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("DGB{0}#{1}&", "ID", DeleteIDText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}, {4}, {5}", DeleteIDText.Text, DeleteBooksCardText.Text, DeleteReaderCardText.Text, DeleteDateGiveText.Text, DeleteDateTakeText.Text, DeleteFactDateTakeText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "VADSELECT * FROM [Выданные книги]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }

        private void DeleteIDText_TextChanged(object sender, EventArgs e)
        {
            DeleteBooksCardText.Text = "";
            DeleteReaderCardText.Text = "";
            DeleteDateGiveText.Text = "";
            DeleteDateTakeText.Text = "";
            DeleteFactDateTakeText.Text = "";

            int num = 0;
            if (int.TryParse(DeleteIDText.Text, out num))
            {
                CoderDecoder decod = new CoderDecoder();

                string message = String.Format("DID{0}#{1}#1&", "[ID]", DeleteIDText.Text);
                message = form.client.SendMessage(message);

                string[] data = decod.DecodMessage1(message);

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "#" || data[i] == "" || data[i] == null)
                    {
                        data[i] = "";
                    }
                }

                DeleteBooksCardText.Text = data[1].TrimEnd();
                DeleteReaderCardText.Text = data[2].TrimEnd();
                DeleteDateGiveText.Text = data[3].TrimEnd();
                DeleteDateTakeText.Text = data[4].TrimEnd();
                DeleteFactDateTakeText.Text = data[5].TrimEnd();
            }
        }
    }
}
