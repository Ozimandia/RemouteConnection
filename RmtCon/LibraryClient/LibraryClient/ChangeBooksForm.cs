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
    public partial class ChangeBooksForm : Form
    {
        DataBaseOperationForm form;

        public ChangeBooksForm(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ChangeBooksCardsText_TextChanged(object sender, EventArgs e)
        {
            ChangeAvtorText.Text = "";
            ChangeNameText.Text = "";
            ChangeYearText.Text = "";
            ChangeCountText.Text = "";

            int num = 0;
            if (int.TryParse(ChangeBooksCardsText.Text, out num))
            {
                CoderDecoder decod = new CoderDecoder();

                string message = String.Format("DID{0}#{1}#Книги&", "[Шифр книги]", ChangeBooksCardsText.Text);
                message = form.client.SendMessage(message);

                string[] data = decod.DecodMessage1(message);

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "#" || data[i] == "" || data[i] == null)
                    {
                        data[i] = "";
                    }
                }

                ChangeAvtorText.Text = data[1].TrimEnd();
                ChangeNameText.Text = data[2].TrimEnd();
                ChangeYearText.Text = data[3].TrimEnd();
                ChangeCountText.Text = data[4].TrimEnd();
            }
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("CDBUPDATE Книги SET [Автор] = N'{0}', [Название] = N'{1}', [Год издания] = N'{2}', [Количество экземпляров] = {3} WHERE [Шифр книги] = {4}", ChangeAvtorText.Text, ChangeNameText.Text, ChangeYearText.Text, ChangeCountText.Text, ChangeBooksCardsText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}, {4}", ChangeBooksCardsText.Text, ChangeAvtorText.Text, ChangeNameText.Text, ChangeYearText.Text, ChangeCountText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "BADSELECT * FROM [Книги]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }
    }
}
