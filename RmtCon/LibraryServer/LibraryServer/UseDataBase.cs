using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceDataBase
{
    public class UseDataBase // Класс для работы с базами данных
    {
        SqlConnection connection = new SqlConnection(); // Объект подключения к базе данных
        public SqlCommand command;                      // Объект запросов к таблицам базы данных
        public bool ExelentConnection;                  // Индикатор удачного подключения
        public string NameDataBase;
        public UseTable[] Tables;
        int TypeDataBase;

        //----------------------------------------------------------------------------------------------------------------
        // КОНСТРУКТОР ФОРМЫ ДЛЯ РАБОТЫ С MS SERVER
        public UseDataBase(string NameServer, string NameDataBase)
        {
            this.NameDataBase = NameDataBase;

            TypeDataBase = 0;

            ExelentConnection = ConnectionDataBase(String.Format(@"Data Source={0}\SQLEXPRESS;Initial Catalog={1};Integrated Security=True;Connect Timeout=2;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", NameServer, NameDataBase));

            if (ExelentConnection)
            {
                command = connection.CreateCommand(); // Создание объекта запросов

                string[,] TablesName = ReciveTablesName();

                Tables = new UseTable[TablesName.GetLength(0)];

                for (int i = 0; i < Tables.Length; i++)
                {
                    Tables[i] = new UseTable(TablesName[i, 0], command);
                    Tables[i].ReciveData();
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------
        // КОНСТРУКТОР ФОРМЫ ДЛЯ РАБОТЫ С БД VISUAL STUDIO
        public UseDataBase(string pathDB)
        {
            /*
            for (int i = pathDB.Length - 1; i >= 0; i--)
            {
                if (pathDB[i] == '\\')
                {
                    NameDataBase = pathDB.Substring(i + 1, pathDB.Length - i - 5);
                    break;
                }
            }
            */

            NameDataBase = pathDB;

            TypeDataBase = 1;

            ExelentConnection = ConnectionDataBase(String.Format(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + "{0}" + ";Integrated Security = True", pathDB));

            if (ExelentConnection)
            {
                command = connection.CreateCommand(); // Создание объекта запросов

                string[,] TablesName = ReciveTablesName();

                Tables = new UseTable[TablesName.GetLength(0)];

                for (int i = 0; i < Tables.Length; i++)
                {
                    Tables[i] = new UseTable(TablesName[i, 0], command);
                    Tables[i].ReciveData();
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------
        // ПОДКЛЮЧЕНИЕ К БАЗЕ ДАННЫХ
        private bool ConnectionDataBase(string ConnectionString)
        {
            connection.ConnectionString = ConnectionString; // Строка подключения

            try
            {
                connection.Open(); // Операция подключения к базе данных
            }
            catch
            {
                //MessageBox.Show("Ошибка соединения с базой данных");
                return false;
            }

            //MessageBox.Show("База данных подключена");
            return true;
        }
        //------------------------------------------------------------------------------------------------------
        // ПОКАЗЫВАЕТ ВСЕ ТАБЛИЦЫ
        public string[,] ReciveTablesName()
        {
                command.CommandText = String.Format("SELECT COUNT(*) FROM [{0}].information_schema.tables", NameDataBase);

                int num = (int)command.ExecuteScalar(); // Получение колличества строк в таблице

                command.CommandText = String.Format("SELECT TABLE_NAME FROM [{0}].information_schema.tables", NameDataBase);

            SqlDataReader reader = command.ExecuteReader(); // Получение результата запроса

            string[,] Data = new string[num, 1];

            object[] RowData = new object[reader.FieldCount]; // Массив для считывания одной строки таблицы

            int j = 0;

            while (reader.Read()) // Считывание данных
            {
                reader.GetValues(RowData);

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Data[j, i] = RowData[i].ToString();
                }

                j++;
            }

            reader.Close(); // Закрытие чтения

            return Data;
        }
    }
}

