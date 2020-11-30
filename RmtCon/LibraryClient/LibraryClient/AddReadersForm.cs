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
    public partial class AddReadersForm : Form
    {
        DataBaseOperationForm form;

        public AddReadersForm(DataBaseOperationForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void AddReaderDataButton_Click(object sender, EventArgs e)
        {
            string message = String.Format("ADR{0}#{1}#{2}#{3}&", AddReaderLastNameText.Text, AddFirstNameText.Text, AddThirdNameText.Text, AddAdressText.Text);
            message = form.client.SendMessage(message);

            InformationText.Text += message + String.Format(" {0}, {1}, {2}, {3}", AddReaderLastNameText.Text, AddFirstNameText.Text, AddThirdNameText.Text, AddAdressText.Text) + Environment.NewLine;

            CoderDecoder decod = new CoderDecoder();

            message = "RADSELECT * FROM [Читатели]";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));
        }
    }
}
