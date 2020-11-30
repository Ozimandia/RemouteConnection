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
    public partial class ChangeGiveBooksForm : Form
    {
        DataBaseOperationForm form;

        public ChangeGiveBooksForm(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ChangeIDText_TextChanged(object sender, EventArgs e)
        {
            ChangeBooksCardText.Text = "";
            ChangeReaderCardText.Text = "";
            ChangeDateGiveText.Text = "";
            ChangeDateTakeText.Text = "";
            ChangeFactTakeText.Text = "";

            int num = 0;
            if (int.TryParse(ChangeIDText.Text, out num))
            {
                CoderDecoder decod = new CoderDecoder();

                string message = String.Format("DID{0}#{1}#1&", "[ID]", ChangeIDText.Text);
                message = form.client.SendMessage(message);

                string[] data = decod.DecodMessage1(message);

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "#" || data[i] == "" || data[i] == null)
                    {
                        data[i] = "";
                    }
                }

                ChangeBooksCardText.Text = data[1].TrimEnd();
                ChangeReaderCardText.Text = data[2].TrimEnd();
                ChangeDateGiveText.Text = data[3].TrimEnd();
                ChangeDateTakeText.Text = data[4].TrimEnd();
                ChangeFactTakeText.Text = data[5].TrimEnd();
            }
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("CGBUPDATE [Выданные книги] SET [Шифр книги] = N'{0}', [Читательский билет] = N'{1}', [Дата выдачи] = N'{2}', [Дата возвращения] = N'{3}', [Дата фактического возвращения] = N'{4}' WHERE [ID] = {5}", ChangeBooksCardText.Text, ChangeReaderCardText.Text, ChangeDateGiveText.Text, ChangeDateTakeText.Text, ChangeFactTakeText.Text, ChangeIDText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}, {4}, {5}", ChangeIDText.Text, ChangeBooksCardText.Text, ChangeReaderCardText.Text, ChangeDateGiveText.Text, ChangeDateTakeText.Text, ChangeFactTakeText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "VADSELECT * FROM [Выданные книги]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }
    }
}
