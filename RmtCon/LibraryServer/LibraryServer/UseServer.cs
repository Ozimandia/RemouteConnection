using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using ServiceDataBase;
using CoderDecoderMessages;
using LibraryServer;

namespace TCPprotocol
{
    class UseServer
    {
        Socket server;               // Сокет сервера
        public bool sClose = true;   // Индикатор инициализации сервера
        public bool ExcelentConnect = false;
        string Send;                 // Массив ответов на запросы клиента
        Object DataSource;    // Источник данных для формирования ответа на запросы в массив Send
        UseDataBase dataBase;

        //-----------------------------------------------------------------------------------------------------
        //КОНСТРУКТОР 1

        public UseServer()
        {
            SeverInit();
        }
        //-----------------------------------------------------------------------------------------------------
        //КОНСТРУКТОР 2

        public UseServer(Object DataSource)
        {
            this.DataSource = DataSource;
            SeverInit();
        }

        //-----------------------------------------------------------------------------------------------------
        //ИНИЦИАЛИЗАЦИЯ СЕРВЕРА

        private void SeverInit()
        {
            sClose = false;

            if (server != null && server.Connected) // Если сервер не инициализорован, или уже работает, то перезагрузить его
            {
                server.Disconnect(false);
            }

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Создание сокита для работы сервера

            EndPoint endPoint = new IPEndPoint(IPAddress.Any, 12345); // Создание узла соединения

            try
            {
                server.Bind(endPoint); // Назначение узла соединения 
                server.Listen(100);    // Прослушивание порта
            }
            catch(Exception ex)
            {
                MessageBox.Show("Невозможно запустить сервер: " + ex.Message);
                return;
            }

            ExcelentConnect = true;

            server.BeginAccept(new AsyncCallback(ServerConnection), server); // Ожидание подключения клиента
        }
        //-----------------------------------------------------------------------------------------------------
        // ПОДКЛЮЧЕНИЕ КЛИЕНТА К СЕРВЕРУ

        private void ServerConnection(IAsyncResult result)
        {
            Socket serverSocket = (Socket)result.AsyncState; // Получаем объект server

            SocketData data = new SocketData(); // Объект для оперирования данными 

            try
            {
                data.ClientConnection = serverSocket.EndAccept(result); // Заканчиваем ожидание и получаем объект подключенного клиента
            }
            catch
            {
                return;
            }

            data.ClientConnection.BeginReceive(data.Buffer, 0, 1024, SocketFlags.None, new AsyncCallback(ReciveSend), data); // Ждем получения данных от клиента
        }
        //-----------------------------------------------------------------------------------------------------
        // ПОЛУЧЕНИЕ ДАННЫХ ОТ КЛИЕНТА И ОТВЕТ НА ЗАПРОС

        private void ReciveSend(IAsyncResult result)
        {
            SocketData data = (SocketData)result.AsyncState; // Получаем объект data 

            int bytes = data.ClientConnection.EndReceive(result); // Заканчиваем прием сообщений от клиента
            
            string s = ""; // Считываем данные

            if (bytes > 0)
            {
                s = Encoding.UTF8.GetString(data.Buffer, 0, bytes);

                GetSend(s);

                data.ClientConnection.Send(Encoding.UTF8.GetBytes(Send));

                data.ClientConnection.BeginReceive(data.Buffer, 0, 1024, SocketFlags.None, new AsyncCallback(ReciveSend), data); // Ждем получения данных от клиента
            }
            else
            {
                server.BeginAccept(new AsyncCallback(ServerConnection), server); // Ожидание подключения клиента
            }
        }
        //-----------------------------------------------------------------------------------------------------
        // ЗАКРЫТИЕ СЕРВЕРА

        public void CloseServer()
        {
            if (!sClose) // Если сервер не закрыт
            {
                sClose = true; 

                if (server == null)
                {
                    throw new Exception("Сервер не инициализирован.");
                }

                server.Close();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        // ИНИЦИАЛИЗАЦИЯ ОТВЕТА СЕРВЕРА

        private void GetSend(string command)
        {
            Send = "Команда не найдена";
            CoderDecoder coder = new CoderDecoder();
            string[] data1;

            switch (command.Substring(0, 3))
            {
                case "DBC":
                    command = command.Remove(0, 3);
                    dataBase = new UseDataBase(System.Net.Dns.GetHostName(), command);

                    if (dataBase.ExelentConnection)
                    {
                        Send = "База данных подключена";
                    }
                    else
                    {
                        Send = "Нет подключения к базе данных";
                    }
                    break;
                case "FAV":
                    command = command.Remove(0, 3);
                    data1 = coder.DecodMessage1(command);
                    dataBase.Tables[2].FindDataAnd(data1);
                    Send = coder.CodMessage(dataBase.Tables[2].Fields);
                    Send += coder.CodMessage(dataBase.Tables[2].Data);
                    break;
                case "BFD":
                    command = command.Remove(0, 3);
                    dataBase.Tables[2].FindDataCommand(true, command);
                    Send = coder.CodMessage(dataBase.Tables[2].Fields);
                    Send += coder.CodMessage(dataBase.Tables[2].Data);
                    break;
                case "BAD":
                    command = command.Remove(0, 3);
                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Книги")
                        {
                            dataBase.Tables[i].FindDataCommand(true, command);
                            Send = coder.CodMessage(dataBase.Tables[i].Fields);
                            Send += coder.CodMessage(dataBase.Tables[i].Data);
                            break;
                        }
                    }
                    break;
                case "RAD":
                    command = command.Remove(0, 3);
                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Читатели")
                        {
                            dataBase.Tables[i].FindDataCommand(true, command);
                            Send = coder.CodMessage(dataBase.Tables[i].Fields);
                            Send += coder.CodMessage(dataBase.Tables[i].Data);
                            break;
                        }
                    }
                    break;
                case "VAD":
                    command = command.Remove(0, 3);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Выданные книги")
                        {
                            dataBase.Tables[i].FindDataCommand(true, command);
                            Send = coder.CodMessage(dataBase.Tables[i].Fields);
                            Send += coder.CodMessage(dataBase.Tables[i].Data);
                            break;
                        }
                    }

                    break;
                case "ADB":
                    command = command.Remove(0, 3);
                    data1 = coder.DecodMessage1(command);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Книги")
                        {
                            dataBase.Tables[i].AddData(data1);
                            break;
                        }
                    }

                    Send = "Данные добавлены:";
                    break;
                case "ADR":
                    command = command.Remove(0, 3);
                    data1 = coder.DecodMessage1(command);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Читатели")
                        {
                            dataBase.Tables[i].AddData(data1);
                            break;
                        }
                    }
                    Send = "Данные добавлены:";
                    break;
                case "ATB":
                    command = command.Remove(0, 3);
                    data1 = coder.DecodMessage1(command);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Выданные книги")
                        {
                            dataBase.Tables[i].AddData(data1);
                            break;
                        }
                    }

                    Send = "Данные добавлены:";
                    break;
                case "DID":
                    command = command.Remove(0, 3);
                    data1 = coder.DecodMessage1(command);
                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == data1[2])
                        {
                            dataBase.Tables[i].ReciveDataID(data1[0], data1[1]);
                            Send = coder.CodMessage(dataBase.Tables[i].Data);
                            break;
                        }
                    }
                    break;
                case "DDB":
                    command = command.Remove(0, 3);
                    data1 = coder.DecodMessage1(command);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Книги")
                        {
                            dataBase.Tables[i].DeleteData(data1[0], data1[1]);
                            break;
                        }
                    }

                    Send = "Данные удалены:";
                    break;
                case "DDR":
                    command = command.Remove(0, 3);
                    data1 = coder.DecodMessage1(command);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Читатели")
                        {
                            dataBase.Tables[i].DeleteData(data1[0], data1[1]);
                            break;
                        }
                    }

                    Send = "Данные удалены:";
                    break;
                case "DGB":
                    command = command.Remove(0, 3);
                    data1 = coder.DecodMessage1(command);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Выданные книги")
                        {
                            dataBase.Tables[i].DeleteData(data1[0], data1[1]);
                            break;
                        }
                    }

                    Send = "Данные удалены:";
                    break;
                case "CDB":
                    command = command.Remove(0, 3);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Книги")
                        {
                            dataBase.Tables[i].FindDataCommand(false, command);
                            break;
                        }
                    }

                    dataBase.Tables[2].FindDataCommand(false, command);
                    Send = "Данные изменены:";
                    break;
                case "CDR":
                    command = command.Remove(0, 3);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Читатели")
                        {
                            dataBase.Tables[i].FindDataCommand(false, command);
                            break;
                        }
                    }

                    Send = "Данные изменены:";
                    break;
                case "CGB":
                    command = command.Remove(0, 3);

                    for (int i = 0; i < dataBase.Tables.Length; i++)
                    {
                        if (dataBase.Tables[i].Name == "Выданные книги")
                        {
                            dataBase.Tables[i].FindDataCommand(false, command);
                            break;
                        }
                    }

                    Send = "Данные изменены:";
                    break;
            }
        }
    }
}
