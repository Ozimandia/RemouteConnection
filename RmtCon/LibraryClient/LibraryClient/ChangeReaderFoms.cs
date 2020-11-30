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
    public partial class ChangeReaderFoms : Form
    {
        DataBaseOperationForm form;

        public ChangeReaderFoms(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ChangeReaderCardText_TextChanged(object sender, EventArgs e)
        {
            ChangeLastNameText.Text = "";
            ChangeFirstNameText.Text = "";
            ChangeThirdNameText.Text = "";
            ChangeAdressText.Text = "";

            int num = 0;
            if (int.TryParse(ChangeReaderCardText.Text, out num))
            {
                CoderDecoder decod = new CoderDecoder();

                string message = String.Format("DID{0}#{1}#0&", "[Читательский билет]", ChangeReaderCardText.Text);
                message = form.client.SendMessage(message);

                string[] data = decod.DecodMessage1(message);

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "#" || data[i] == "" || data[i] == null)
                    {
                        data[i] = "";
                    }
                }

                ChangeLastNameText.Text = data[1].TrimEnd();
                ChangeFirstNameText.Text = data[2].TrimEnd();
                ChangeThirdNameText.Text = data[3].TrimEnd();
                ChangeAdressText.Text = data[4].TrimEnd();
            }
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("CDRUPDATE Читатели SET [Фамилия] = N'{0}', [Имя] = N'{1}', [Отчество] = N'{2}', [Адрес] = N'{3}' WHERE [Читательский билет] = {4}", ChangeLastNameText.Text, ChangeFirstNameText.Text, ChangeThirdNameText.Text, ChangeAdressText.Text, ChangeReaderCardText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}, {4}", ChangeReaderCardText.Text, ChangeLastNameText.Text, ChangeFirstNameText.Text, ChangeThirdNameText.Text, ChangeAdressText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "RADSELECT * FROM [Читатели]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }
    }
}
