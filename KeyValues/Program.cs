using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace KeyValues
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Key> Keys = ConectAndQueryKeys();
            foreach (Key key in Keys)
            {
                string valid = IsValid(key.KeyValue) ? "Valida | " : "Invalida | ";
                Console.WriteLine(valid + key.KeyValue);
            }
            Console.ReadKey();
        }
        
        private static bool IsValid(string key)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            key = regex.Replace(key, "");
            key = key.ToLower();
            int keyValue = 0;
            for (int i = 0; i < key.Length; i++)
            {
                int value = key[i];
                keyValue += value;
            }
            char verifChar = key[9];
            int verifDigit = verifChar;
            string verifString = verifDigit.ToString();
            verifDigit = int.Parse(verifString.Substring(verifString.Length - 1));
            return keyValue % 100 == verifDigit;
        }

        private static List<Key> ConectAndQueryKeys(string cmd = "Select `keyValue` from `key`")
        {
            string connection = "SERVER = localhost;";
            connection += "DATABASE = xmlsender;";
            connection += "UID = user;";
            connection += "PASSWORD = user;";
            connection += "PORT = 3306;";
            //connection += "CHARSET = UTF-8;";

            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            DataTable table = new DataTable();

            MySqlCommand myCMD = new MySqlCommand(cmd);
            myCMD.Connection = new MySqlConnection(connection);

            MySqlDataAdapter data = new MySqlDataAdapter(myCMD);
            data.Fill(table);
            List<Key> keys = (from DataRow row in table.Rows
             select new Key()
             {
                 KeyValue = row["keyValue"].ToString()
             }).ToList();
            return keys;
        }
    }

    public class Key
    {
        public string KeyValue { get; set; }
    }
}
