using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace TCPprotocol
{
    public class UseClient
    {
        public Socket client;     // Объект сокета клиента
        string ipServer;   // ip-серера для подключения
        public bool ClientConnect = false; // Индикатор успешного подключения

        //------------------------------------------------------------------------
        // КОНСТРУКТОР КЛАССА
        public UseClient(string ipServer)
        {
            this.ipServer = ipServer;

            ClientInit(); // Инициализация клиентского подключения
        }

        //------------------------------------------------------------------------
        // ИНИЦИАЛИЗАЦИЯ КЛИЕНТСКОГО ПОДКЛЮЧЕНИЯ
        private void ClientInit()
        {
            if (client != null && client.Connected) // Переподключение
            {
                client.Disconnect(false);
            }

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Инициализация сокета клиента

            IPAddress addr = GetAddress(ipServer); // Получение ip-адреса сервера

            if (addr == null)
            {
                MessageBox.Show("Адресс не разобран");
                return;
            }

            EndPoint point = new IPEndPoint(addr, 12345); // Создание узла подключения

            try
            {
                client.Connect(point); // Подключение клиента
                ClientConnect = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошика соеденения: " + ex.Message);
                return;
            }
        }

        //------------------------------------------------------------------------
        // ОТПРАВКА СООБЩЕНИЙ СЕРВЕРУ ЧЕРЕЗ СТРОКУ
        public string SendMessage(string message)
        {
            if (client == null || !client.Connected) // Проверка клиента на подключение
            {
                MessageBox.Show("Сначала соеденитесь с сервером");
                return "";
            }

            try
            {
                client.Send(Encoding.UTF8.GetBytes(message)); // Отправка сообщения серверу
            }
            catch(SocketException)
            {
                MessageBox.Show("Соеденение с сервером разорвано");
                ClientConnect = false;
                return "";
            }

            byte[] buffer = new byte[1024]; // Буфер приходящи байтов

            int bytes = client.Receive(buffer); // Полчение количество байтов

            string s = "";

            if (bytes > 0) // Запись полученных битов в строку
            {
                s = Encoding.UTF8.GetString(buffer, 0, bytes);
            }

            return s;
        }
        //------------------------------------------------------------------------
        // ПРИВЕДЕНИЕ IP-АДРЕСА К НУЖНОМУ ФОМАТУ
        private IPAddress GetAddress(string addr)
        {
            IPAddress ipAddress = null;

            try
            {
                ipAddress = IPAddress.Parse(addr);
            }
            catch(Exception)
            {
                IPHostEntry heserver;

                try
                {
                    heserver = Dns.GetHostEntry(addr);
                    if (heserver.AddressList.Length == 0)
                    {
                        return null;
                    }

                    ipAddress = heserver.AddressList[0];
                }
                catch
                {
                    return null;
                }
            }

            return ipAddress;
        }

        //------------------------------------------------------------------------
        // ЗАКРЫТИЕ СОЕДИНЕНИЯ
        public void CloseClient()
        {
            if (ClientConnect)
            {
                ClientConnect = false;

                if (client == null)
                {
                    throw new Exception("Клиент не инициализирован.");
                }
                client.Close();
            }
        }
    }
}
