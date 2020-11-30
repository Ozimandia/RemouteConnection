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
    public partial class FindAvtorForm : Form
    {
        DataBaseOperationForm form;

        public FindAvtorForm(DataBaseOperationForm form)
        {
            InitializeComponent();

            this.form = form;
        }

        private void FindBooksButton_Click(object sender, EventArgs e)
        {
            CoderDecoder decod = new CoderDecoder();
             
            string message = "FAVАвтор#" + AvtorNameText.Text + "&";
            message = form.client.SendMessage(message);

            form.listView1 = form.ShowDataListView(form.listView1, decod.DecodMessage2(message));

        }
    }
}
