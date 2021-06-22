using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeygenTest
{
    public partial class Keygen : Form
    {
        public Keygen()
        {
            InitializeComponent();
        }

        string sampleMinNum = "abcdefghijklmnopqrstuvwxyz0123456789";

        private Random random;
        private void Keygen_Load(object sender, EventArgs e)
        {
            int validDays = (DateTime.Now.Date.AddMonths(1) - DateTime.Now.Date).Days;
            mtbCNPJ.Text = "11222333000181";
            nudValidDays.Value = 30;
        }

        private void Generate()
        {
            string cnpj = mtbCNPJ.Text;
            DateTime creationDate = dtpCreation.Value.Date;
            string year = creationDate.Year.ToString().Substring(2);
            string dayOfYear = creationDate.DayOfYear.ToString();
            dayOfYear = dayOfYear.Length == 2 ? "0" + dayOfYear : dayOfYear;
            string validDays = nudValidDays.Value.ToString();
            validDays = validDays.Length == 2 ? "0" + validDays : validDays;

            string refFirst = year + dayOfYear;
            string refSecond = RefCNPJ(cnpj).Substring(1, 2) + validDays;
            string refThird = RefCNPJ(cnpj).Substring(0, 1);

            this.random = new Random();
            string chunk = "";
            string[] chunks = new string[4];
            string key = "";

            do
            {
                chunk = GenKeyChunk();
            } while (!(GetRef(chunk, 0, 4) == refFirst));
            chunks[0] = chunk;

            do
            {
                chunk = GenKeyChunk();
            } while (!(GetRef(chunk, 0, 4) == refSecond));
            chunks[1] = chunk;

            do
            {
                do
                {
                    chunk = GenKeyChunk();
                } while (!(GetRef(chunk, 4,4) == refThird));
                chunks[2] = chunk;
                
                chunk = GenKeyChunk();
                chunks[3] = chunk;
                key = $"{chunks[3]}-{chunks[2]}-{chunks[1]}-{chunks[0]}".ToUpper();
            } while (!(Verify(key)));
            txtKey.Text = key;
        }

        private string GetRef(string chunk, int indexStart, int indexEnd)
        {
            string refence = "";
            for (int i = indexStart; i <= indexEnd; i++)
            {
                char character = chunk[i];
                int digit = character;
                string value = digit.ToString().Substring(digit.ToString().Length - 1);
                refence += value;
            }
            return refence;
        }

        private string GenKeyChunk()
        {
            string chunk= "";
            do
            {
                int index = random.Next(sampleMinNum.Length);
                char an = sampleMinNum[index];
                chunk += an;
            } while (chunk.Length != 5);
            return chunk;
        }


        private bool Verify(string key)
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

        private string GetDay(string keyChunk, int indexStart)
        {
            int firstDigit = keyChunk[indexStart];
            int secondDigit = keyChunk[indexStart + 1];
            int thirdDigit = keyChunk[indexStart + 2];

            string hundred = firstDigit.ToString().Substring(firstDigit.ToString().Length - 1);
            string dozen = secondDigit.ToString().Substring(secondDigit.ToString().Length - 1);
            string unit = thirdDigit.ToString().Substring(thirdDigit.ToString().Length - 1);

            return hundred + dozen + unit;
        }

        private string GetYear(string keyChunk, int indexStart)
        {
            int firstDigit = keyChunk[indexStart];
            int secondDigit = keyChunk[indexStart + 1];
            
            string dozen = firstDigit.ToString().Substring(firstDigit.ToString().Length - 1);
            string unit = secondDigit.ToString().Substring(secondDigit.ToString().Length - 1);

            return dozen + unit;
        }

        private string GetCNPJRef(string keyChunk, int indexStart)
        {
            int firstDigit = keyChunk[indexStart];
            int secondDigit = keyChunk[indexStart + 1];
            int thirdDigit = keyChunk[indexStart + 2];

            string hundred = firstDigit.ToString().Substring(firstDigit.ToString().Length - 1);
            string dozen = secondDigit.ToString().Substring(secondDigit.ToString().Length - 1);
            string unit = thirdDigit.ToString().Substring(thirdDigit.ToString().Length - 1);

            return hundred + dozen + unit;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private string RefCNPJ(string cnpj)
        {
            int firstValue = 0;
            int secondValue = 0;

            char[] chars = cnpj.Substring(0, 12).ToArray();
            int mult = 1;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (mult == 9)
                    mult = 2;
                else
                    mult++;

                int valor = int.Parse(chars[i].ToString());
                firstValue += (mult * valor);
            }
            chars = cnpj.Substring(0, 13).ToArray();
            mult = 1;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (mult == 9)
                    mult = 2;
                else
                    mult++;

                int valor = int.Parse(chars[i].ToString());
                secondValue += (mult * valor);
            }
            return ((firstValue + secondValue) % 1000).ToString();
        }

        private void CheckCNPJ(string cnpj)
        {
            cnpj = cnpj.Replace(" ", "");
            cnpj = cnpj.Replace(".", "");
            cnpj = cnpj.Replace("/", "");
            cnpj = cnpj.Replace("-", "");

            int firstValue = 0;
            int secondValue = 0;

            char[] chars = cnpj.Substring(0, 12).ToArray();
            int mult = 1;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (mult == 9)
                    mult = 2;
                else
                    mult++;

                int valor = int.Parse(chars[i].ToString());
                firstValue += (mult * valor);
            }
            chars = cnpj.Substring(0, 13).ToArray();
            mult = 1;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (mult == 9)
                    mult = 2;
                else
                    mult++;

                int valor = int.Parse(chars[i].ToString());
                secondValue += (mult * valor);
            }
            int fristDigit = int.Parse(cnpj.Substring(12, 1));
            int secondDigit = int.Parse(cnpj.Substring(13, 1));
            firstValue = firstValue % 11;
            secondValue = secondValue % 11;
        }


        private void btnGiveValues_Click(object sender, EventArgs e)
        {
            CheckCNPJ(mtbCNPJ.Text);
        }

        private void mtbCNPJ_TextChanged(object sender, EventArgs e)
        {
            string cnpj = mtbCNPJ.Text;
            if (cnpj.Length == 14)
            {
                txtRefCNPJ.Text = RefCNPJ(cnpj);
            }
        }

        private void btnCheckValues_Click(object sender, EventArgs e)
        {
            string[] keyChunks = txtKey.Text.ToLower().Split('-');

            string refCNPJ = GetCNPJRef(keyChunks[1], 2);
            txtKeyRefCHPJ.Text = refCNPJ;

            int year = int.Parse("20" + GetYear(keyChunks[3], 0));
            int yearDays = int.Parse(GetDay(keyChunks[3], 2));
            DateTime date = new DateTime(year, 1, 1);
            date = date.AddDays(yearDays-1);
            dtpKeyRefCreation.Value = date;

            int validDays = int.Parse(GetDay(keyChunks[2], 2));
            nudKeyRefValidDays.Value = validDays;

        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            string cmd = "INSERT INTO `key` VALUES (0, 1, '" + txtKey.Text + "', NOW(),DATE_ADD(NOW(),INTERVAL 30 DAY), 30)";
            InsertKey(cmd);
        }

        private void InsertKey(string cmd)
        {
            string connection = "SERVER = localhost;";
            connection += "DATABASE = xmlsender;";
            connection += "UID = user;";
            connection += "PASSWORD = user;";
            connection += "PORT = 3306;";

            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                conn.Open();
                DataTable table = new DataTable();

                MySqlCommand myCMD = new MySqlCommand(cmd);
                myCMD.Connection = new MySqlConnection(connection);
                myCMD.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
