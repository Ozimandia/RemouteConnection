using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderDecoderMessages
{
    public class CoderDecoder
    {
        //-----------------------------------------------------------------------------
        // КОДИРОВКА ОДНОМЕРНОГО МАССИВА СТРОК

        public string CodMessage(string[] data)
        {
            string codstring = "";

            for (int i = 0; i < data.Length; i++)
            {
                if (i != data.Length - 1)
                {
                    codstring += data[i] + "#";
                }
                else
                {
                    codstring += data[i] + "&";
                }
            }

            return codstring;
        }
        //-----------------------------------------------------------------------------
        // КОДИРОВКА ДВУХМЕРНОГО МАССИВА СТРОК 

        public string CodMessage(string[,] data)
        {
            string codstring = "";

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (j != data.GetLength(1) - 1)
                    {
                        codstring += data[i, j] + "#";
                    }
                    else
                    {
                        codstring += data[i, j] + "&";
                    }
                }
            }

            return codstring;
        }
        //-----------------------------------------------------------------------------
        // РАСКОДИРОВАКА СТРОКИ В ОДНОМЕРНЫЙ МАССИВ
        public string[] DecodMessage1(string datastring)
        {
            // определение размерности выходного массива
            int length = 0;

            for (int i = 0; i < datastring.Length; i++)
            {
                if (datastring[i] == '#')
                {
                    length++;
                }
            }

            length++;

            // декодировка строки в одномерный массив
            string[] data = new string[length];

            length = 0;

            for (int i = 0; i < datastring.Length; i++)
            {
                if (datastring[i] == '#')
                {
                    data[length] = datastring.Substring(0, i);
                    datastring = datastring.Remove(0, i + 1);
                    length++;
                    i = 0;
                }

                if (datastring[i] == '&')
                {
                    data[length] = datastring.Substring(0, i);
                    datastring = datastring.Remove(0, i + 1);
                    length++;
                    i = 0;
                }
            }

            return data;
        }
        //-----------------------------------------------------------------------------
        // РАСКОДИРОВАКА СТРОКИ В ДВУХМЕРНЫЙ МАССИВ

        public string[,] DecodMessage2(string datastring)
        {
            int length0 = 0, length1 = 0;

            for (int i = 0; i < datastring.Length; i++)
            {
                if (datastring[i] == '&')
                {
                    length0++;
                }
            }

            for (int i = 0; i < datastring.Length; i++)
            {
                if (datastring[i] == '#')
                {
                    length1++;
                }

                if (datastring[i] == '&')
                {
                    length1++;
                    break;
                }
            }

            string[,] Data = new string[length0, length1];

            int j = 0;
            int t = 0;
            for (int i = 0; i < datastring.Length; i++)
            {
                if (datastring[i] == '#')
                {
                    Data[j, t] = datastring.Substring(0, i);
                    datastring = datastring.Remove(0, i + 1);
                    i = 0;
                    t++;
                }

                if (datastring[i] == '&')
                {
                    Data[j, t] = datastring.Substring(0, i);
                    datastring = datastring.Remove(0, i + 1);
                    i = 0;
                    t = 0;
                    j++;
                }
            }

            return Data;
        }
    }
}
