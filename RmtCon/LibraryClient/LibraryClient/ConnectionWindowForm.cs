using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPprotocol;

namespace LibraryClient
{
    public partial class ConnectionWindowForm : Form
    {
        UseClient client;
        DataBaseOperationForm dataBaseOperationForm;

        public ConnectionWindowForm(DataBaseOperationForm dataBaseOperationForm)
        {
            InitializeComponent();

            this.dataBaseOperationForm = dataBaseOperationForm;
            ServerIPText.Text = "192.168.0.14";
            DataBaseNameText.Text = "LibraryDB";
        }

        private void ConnectServerButton_Click(object sender, EventArgs e)
        {
            client = new UseClient(ServerIPText.Text);

            if (client.ClientConnect)
            {
                InformationText.Text = "Подключение к серверу успешно" + Environment.NewLine;

                if (client.SendMessage("DBC" + DataBaseNameText.Text) == "База данных подключена")
                {
                    InformationText.Text += "База данных подключена" + Environment.NewLine;
                    dataBaseOperationForm.client = client;
                    dataBaseOperationForm.Show();
                    //this.Close();
                }
                else
                {
                    InformationText.Text += "Нет подключения к базе данных" + Environment.NewLine;
                }
            }
        }

        private void ConnectionWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null && client.ClientConnect)
            {
                client.CloseClient();
            }
        }
    }
}
