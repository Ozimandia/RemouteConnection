using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace ServiceDataBase
{
    public class UseTable
    {
        public string Name;     // Имя таблицы 
        public string[] Fields; // Поля таблицы
        public string[,] Data;  // Данные таблицы
        public SqlCommand command; // Объект команд

        //------------------------------------------------------------------------------------------------------
        // КОНСТРУКТОР КЛАССА 1
        public UseTable(string Name, SqlCommand command)
        {
            this.Name = Name;
            this.command = command;

            command.CommandText = String.Format("SELECT * FROM [{0}]", Name); // Присвоение запроса команде

            SqlDataReader reader = command.ExecuteReader(); // Получение результата запроса

            Fields = new string[reader.FieldCount]; // Инициализация массива полей таблицы

            for (int i = 0; i < reader.FieldCount; i++) // Заполнение полей таблицы
            {
                Fields[i] = reader.GetName(i);
            }

            reader.Close();
        }
        //------------------------------------------------------------------------------------------------------
        // КОНСТРУКТОР КЛАССА 2

        public UseTable()
        {

        }
        //------------------------------------------------------------------------------------------------------
        // КОНСТРУКТОР КЛАССА 3
        public UseTable(string[] Fields)
        {
            this.Fields = Fields;
        }

        //------------------------------------------------------------------------------------------------------
        // ВЫВОД ВСЕХ ДАННЫХ В ТАБЛИЦЕ
        public void ReciveData()
        {
            if (command == null) throw new Exception("Строка подключения не инициализированна.");

            command.CommandText = String.Format("SELECT COUNT(*) FROM [{0}]", Name); // Присвоение запроса команде

            int num = (int)command.ExecuteScalar(); // Получение колличества строк в таблице

            command.CommandText = String.Format("SELECT * FROM [{0}]", Name); // Присвоение запроса команде

            SqlDataReader reader = command.ExecuteReader(); // Получение результата запроса

            Data = new string[num, reader.FieldCount]; // Инициализация массива данных

            object[] RowData = new object[reader.FieldCount]; // Массив для считывания одной строки таблицы

            int j = 0;
            while (reader.Read()) // Считывание данных
            {
                reader.GetValues(RowData);

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Data[j, i] = RowData[i].ToString().TrimEnd();
                }

                j++;
            }

            reader.Close(); // Закрытие чтения
        }
        //------------------------------------------------------------------------------------------------------
        // ПОЛУЧЕНИЕ ДАННЫХ ПО ID

        public void ReciveDataID(string nameid, string id)
        {
            if (command == null) throw new Exception("Строка подключения не инициализированна.");

            command.CommandText = String.Format("SELECT * FROM [{0}] WHERE {1} = {2}", Name, nameid ,id); // Присвоение запроса команде

            SqlDataReader reader = command.ExecuteReader(); // Получение результата запроса

            Data = new string[1, Fields.Length];

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
        }

        //------------------------------------------------------------------------------------------------------
        // ДОБАВЛЕНИЕ ДАННЫХ В ТАБЛИЦУ

        public void AddData(string[] evenArgs)
        {
            if (command == null) throw new Exception("Строка подключения не инициализированна.");

            if (evenArgs.Length != Fields.Length - 1) throw new Exception("Количество аргументов не совпадает с количеством полей таблицы");

            command.CommandText = String.Format("SELECT COUNT(*) FROM [{0}]", Name); // Присвоение запроса команде

            int num = (int)command.ExecuteScalar(); // Получение колличества строк в таблице

            string sFields = "";

            for (int i = 0; i < Fields.Length; i++) // Формирование строки полей таблицы
            {
                if (i != Fields.Length - 1)
                {
                    sFields += "[" + Fields[i] + "], ";
                }
                else
                    sFields += "[" + Fields[i] + "]";
            }

            string sArg = (num + 1).ToString() + ", ";

            for (int i = 0; i < evenArgs.Length; i++) // Формирование строки аргументов
            {
                if (i != evenArgs.Length - 1)
                {
                    sArg += "N'" + evenArgs[i] + "', ";
                }
                else
                    sArg += "N'" + evenArgs[i] + "'";
            }

            command.CommandText = String.Format("INSERT INTO [{0}]({1}) VALUES({2})",
               Name, sFields, sArg);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
        }
        //------------------------------------------------------------------------------------------------------
        // УДАЛЕНИЕ ДАННЫХ ИЗ ТАБЛИЦЫ

        public void DeleteData(string nameid, string ID)
        {
            if (command == null) throw new Exception("Строка подключения не инициализированна.");

            command.CommandText = String.Format("SELECT COUNT(*) FROM [{0}]", Name); // Присвоение запроса команде

            int num = (int)command.ExecuteScalar(); // Получение колличества строк в таблице

            command.CommandText = String.Format("DELETE FROM [{0}] WHERE [{1}] = {2}", Name, nameid ,ID); // Присвоение запроса команде

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();

            for (int i = int.Parse(ID); i <= num - 1; i++) // Конттроль ID, чтобы не повторялся
            {
                command.CommandText = String.Format("UPDATE [{0}] SET [{1}] = {2} WHERE [{3}] = {4}", Name, nameid ,i.ToString(), nameid, (i + 1).ToString());
                reader = command.ExecuteReader();
                reader.Close();
            }

            reader.Close();
        }
        //------------------------------------------------------------------------------------------------------
        // ИЗМЕНЕНИЕ ДАННЫХ ТАБЛИЦЫ

        public void ChangeData(string[] evenArgs) // Пишется название полей и ID пишится последним
        {
            if (command == null) throw new Exception("Строка подключения не инициализированна.");

            if (evenArgs.Length != Fields.Length) throw new Exception("Количество аргументов не совпадает с количеством полей таблицы");

            string sFields = "";

            for (int i = 0; i < evenArgs.Length - 1; i++) // Формирование строки полей изменения
            {
                if (i != evenArgs.Length - 2)
                {
                    sFields += "[" + Fields[i + 1] + "] = N'" + evenArgs[i] + "', ";
                }
                else
                    sFields += "[" + Fields[i + 1] + "] = N'" + evenArgs[i] + "'";
            }

            command.CommandText = String.Format("UPDATE [{0}] SET {1} WHERE ID = {3}", // Присвоение запроса команде
                    Name, sFields, evenArgs[evenArgs.Length - 1]);

            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
        }
        //------------------------------------------------------------------------------------------------------
        // ПОИСК УСЛОВНЫХ ДАННЫХ И
        public void FindDataAnd(string[] eventArgs) // Педаются поочередно поле таблицы и занчение
        {
            if (command == null) throw new Exception("Строка подключения не инициализированна.");

            // проверка полей 
            bool exelent = false;

            for (int i = 0; i < eventArgs.Length; i += 2)
            {
                for (int j = 0; j < Fields.Length; j++)
                {
                    if (eventArgs[i] == Fields[j])
                    {
                        exelent = true;
                        break;
                    }
                }

                if (!exelent) throw new Exception("Указанное поле не найдено в таблице");

                exelent = false;
            }

            // создание строки аргументов WHERE
            string sArg = "";

            for (int i = 0; i < eventArgs.Length; i += 2)
            {
                if (i != eventArgs.Length - 2)
                {
                    sArg += "[" + eventArgs[i] + "] = N'" + eventArgs[i + 1] + "' and ";
                }
                else
                {
                    sArg += "[" + eventArgs[i] + "] = N'" + eventArgs[i + 1] + "'";
                }
            }

            // создание запроса
            command.CommandText = String.Format("SELECT * FROM [{0}] WHERE {1}", // Присвоение запроса команде
                    Name, sArg);

            SqlDataReader reader = command.ExecuteReader();

            object[] RowData = new object[reader.FieldCount]; // Массив для считывания одной строки таблицы

            int t = 0;

            while (reader.Read())
            {
                t++;
            }

            Data = new string[t, reader.FieldCount];
            reader.Close();

            reader = command.ExecuteReader();
            t = 0;

            while (reader.Read()) // Считывание данных
            {
                reader.GetValues(RowData);

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Data[t, i] = RowData[i].ToString().TrimEnd();
                }

                t++;
            }

            reader.Close();

        }
        //------------------------------------------------------------------------------------------------------
        // ПОИСК УСЛОВНЫХ ДАННЫХ ИЛИ
        public void FindDataOr(string[] eventArgs) // Педаются поочередно поле таблицы и занчение
        {
            if (command == null) throw new Exception("Строка подключения не инициализированна.");

            // проверка полей 
            bool exelent = false;

            for (int i = 0; i < eventArgs.Length; i += 2)
            {
                for (int j = 0; j < Fields.Length; j++)
                {
                    if (eventArgs[i] == Fields[j])
                    {
                        exelent = true;
                        break;
                    }
                }

                if (!exelent) throw new Exception("Указанное поле не найдено в таблице");

                exelent = false;
            }

            // создание строки аргументов WHERE
            string sArg = "";

            for (int i = 0; i < eventArgs.Length; i += 2)
            {
                if (i != eventArgs.Length - 2)
                {
                    sArg += "[" + eventArgs[i] + "] = N'" + eventArgs[i + 1] + "' or ";
                }
                else
                {
                    sArg += "[" + eventArgs[i] + "] = N'" + eventArgs[i + 1] + "'";
                }
            }

            // создание запроса
            command.CommandText = String.Format("SELECT * FROM [{0}] WHERE {1}", // Присвоение запроса команде
                    Name, sArg);

            SqlDataReader reader = command.ExecuteReader();

            object[] RowData = new object[reader.FieldCount]; // Массив для считывания одной строки таблицы

            int t = 0;

            while (reader.Read())
            {
                t++;
            }

            Data = new string[t, reader.FieldCount];
            reader.Close();

            reader = command.ExecuteReader();
            t = 0;

            while (reader.Read()) // Считывание данных
            {
                reader.GetValues(RowData);

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Data[t, i] = RowData[i].ToString().TrimEnd();
                }

                t++;
            }

            reader.Close();

        }
        //------------------------------------------------------------------------------------------------------
        // ПОИСК ДАННЫХ ПО SQL ЗАПРОСУ

        public void FindDataCommand(bool read, string com) // Педаются поочередно поле таблицы и занчение
        {
            if (command == null) throw new Exception("Строка подключения не инициализированна.");

            // создание запроса
            command.CommandText = com;


            SqlDataReader reader = command.ExecuteReader();

            if (read)
            {
                object[] RowData = new object[reader.FieldCount]; // Массив для считывания одной строки таблицы

                int t = 0;

                while (reader.Read())
                {
                    t++;
                }

                Data = new string[t, reader.FieldCount];
                reader.Close();

                reader = command.ExecuteReader();
                t = 0;

                while (reader.Read()) // Считывание данных
                {
                    reader.GetValues(RowData);

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Data[t, i] = RowData[i].ToString().TrimEnd();
                    }

                    t++;
                }
            }

            reader.Close();

        }
        //------------------------------------------------------------------------------------------------------
        // ОТОБРАЖЕНИЕ ДАННЫХ НА LISTVIEW

        public ListView ShowDataListView(ListView listView)
        {
            if (Data == null) throw new Exception("Массив Data не инициализирован. Необходимо вызвать метод ReciveData, или ReciveDataID");

            // Set the view to show details.
            listView.View = View.Details;
            // Allow the user to edit item text.
            listView.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView.AllowColumnReorder = true;
            // Display check boxes.
            listView.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView.FullRowSelect = true;
            // Display grid lines.
            listView.GridLines = true;

            ListViewItem[] items = new ListViewItem[Data.GetLength(0)];

            for (int i = 0; i < Data.GetLength(0); i++)
            {
                items[i] = new ListViewItem();

                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    items[i].SubItems.Add(Data[i, j]);
                }
            }

            listView.Columns.Add("Column item", -2, HorizontalAlignment.Center);

            for (int i = 0; i < Fields.Length; i++) // Создание колонок
            {
                listView.Columns.Add(Fields[i], -2, HorizontalAlignment.Center);
                listView.Columns[i].Width = 70;
            }

            listView.Items.AddRange(items);

            return listView;
        }
    }
}
