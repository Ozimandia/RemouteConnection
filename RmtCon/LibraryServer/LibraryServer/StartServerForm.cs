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
using ServiceDataBase;

namespace LibraryServer
{
    public partial class StartServerForm : Form
    {
        UseServer server;

        public StartServerForm()
        {
            InitializeComponent();
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            server = new UseServer();
            InformationText.Text += "Сервер запущен ..." + Environment.NewLine;
        }

        private void StartServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (server != null && server.ExcelentConnect)
            {
                server.CloseServer();
            }
        }

        private void StopServerButton_Click(object sender, EventArgs e)
        {
            if (server != null && server.ExcelentConnect)
            {
                server.CloseServer();
                InformationText.Text += "Сервер отключен ..." + Environment.NewLine;
            }
        }
    }
}
