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
    public partial class DeleteReaderForm : Form
    {
        DataBaseOperationForm form;

        public DeleteReaderForm(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("DDR{0}#{1}&", "Читательский билет", DeleteReaderCardText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}, {4}", DeleteReaderCardText.Text, DeleteLastNameText.Text, DeleteFirstNameText.Text, DeleteThirdNameText.Text,DeleteAdressText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "RADSELECT * FROM [Читатели]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }

        private void DeleteReaderCardText_TextChanged(object sender, EventArgs e)
        {
            DeleteLastNameText.Text = "";
            DeleteFirstNameText.Text = "";
            DeleteThirdNameText.Text = "";
            DeleteAdressText.Text = "";

            int num = 0;
            if (int.TryParse(DeleteReaderCardText.Text, out num))
            {
                CoderDecoder decod = new CoderDecoder();

                string message = String.Format("DID{0}#{1}#Читатели&", "[Читательский билет]", DeleteReaderCardText.Text);
                message = form.client.SendMessage(message);

                string[] data = decod.DecodMessage1(message);

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "#" || data[i] == "" || data[i] == null)
                    {
                        data[i] = "";
                    }
                }

                DeleteLastNameText.Text = data[1].TrimEnd();
                DeleteFirstNameText.Text = data[2].TrimEnd();
                DeleteThirdNameText.Text = data[3].TrimEnd();
                DeleteAdressText.Text = data[4].TrimEnd();
            }
        }
    }
}
