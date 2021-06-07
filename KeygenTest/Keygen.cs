using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        string sample = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789";
        string sampleMinNum = "abcdefghijklmnopqrstuvwxyz0123456789";
        string sampleMaiNum = "ABCDEFGHIJKLMENOPQRSTUVWXYZ0123456789";
        string sampleA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string sampleB = "ABCDEFGHJKNPQRSTUVWXYZ123456789";

        private Random random;
        private void Keygen_Load(object sender, EventArgs e)
        {
            int validDays = (DateTime.Now.Date.AddMonths(1) - DateTime.Now.Date).Days;
            nudValidDays.Value = 30;
        }

        private string Generate()
        {
            DateTime creationDate = dtpCreation.Value.Date;
            int validDays = int.Parse(nudValidDays.Value.ToString());
            string cnpj = mtbCNPJ.Text;

            this.random = new Random();
            string key = "";
            string chunk = "";
            do
            {
                key = "";
                chunk = "";
                while (key.Length < 23)
                {
                    int index = random.Next(sampleMinNum.Length);
                    char an = sampleMinNum[index];
                    key += an;
                    chunk += an;
                    if (chunk.Length == 5 && key.Length < 23)
                    {
                        key += '-';
                        chunk = "";
                    }
                }
            }
            while (!VerifyKey(key, creationDate, validDays, cnpj));
            key = key.ToUpper();
            return key;
        }

        private bool Verify(string key)
        {
            if (key != "")
            {
                int score = 0;
                int checkDigit = key[0];
                int checkDigitCount = 0;
                string[] chunks = key.Split('-');
                foreach (string chunk in chunks)
                {
                    if (chunk.Length != 4)
                        return false;
                    foreach (char an in chunk)
                    {
                        int value = an;
                        if (value == checkDigit)
                            checkDigitCount++;
                        score += value;
                    }
                }
                if (score == 1882 && checkDigitCount == 4)
                {

                    return true;
                }
            }
            return false;
        }

        private bool VerifyKey(string key, DateTime creationDate, int validDays, string cnpj)
        {
            string creationYear = creationDate.Year.ToString().Substring(2,2);
            string creationDay = creationDate.DayOfYear.ToString();

            if (!string.IsNullOrWhiteSpace(key) && key.Length == 23)
            {
                string[] chunks = key.Split('-');
                //char[] keyValues = key.Replace("-", "").ToArray();

                int chunkCount = 0;
                int score = 0;
                int checkDigit = 0;
                int checkDigitCount = 0;

                foreach (string chunk in chunks)
                {
                    if (chunk.Length != 5)
                        return false;
                    
                    chunkCount++;
                    foreach (char charecter in chunk)
                    {
                        int value = charecter;
                        score += value;
                    }
                }

                if (GetDay(chunks[2],1) == validDays &&
                    GetDay(chunks[3], 2) == int.Parse(creationDay) &&
                    GetYear(chunks[3], 0) == int.Parse(creationYear))
                {
                    return true;
                }

                //if (score == 1882 && checkDigitCount == 4)
                //{

                //    return true;
                //}
            }
            return false;
        }

        private int GetDay(string chunk, int indexStart)
        {
            int firstDigit = chunk[indexStart];
            int secondDigit = chunk[indexStart + 1];
            int thirdDigit = chunk[indexStart + 2];

            string hundred = firstDigit.ToString().Substring(firstDigit.ToString().Length - 1);
            string dozen = secondDigit.ToString().Substring(secondDigit.ToString().Length - 1);
            string unit = thirdDigit.ToString().Substring(thirdDigit.ToString().Length - 1);

            return int.Parse(hundred + dozen + unit);
        }

        private int GetYear(string chunk, int indexStart)
        {
            int firstDigit = chunk[indexStart];
            int secondDigit = chunk[indexStart + 1];
            
            string dozen = firstDigit.ToString().Substring(firstDigit.ToString().Length - 1);
            string unit = secondDigit.ToString().Substring(secondDigit.ToString().Length - 1);

            return int.Parse(dozen + unit);
        }

        private bool VerifyNew(string key, int validDays, string CNPJ = "11222333000181")
        {
            string year = DateTime.Now.Year.ToString().Substring(2,2);
            string day = DateTime.Now.DayOfYear.ToString();
            MessageBox.Show(day + "|" + year);
            if (key != "")
            {
                //char[] chars = key.ToArray();
                int score = 0;
                //int checkDigit = key[0];
                int checkDigitCount = 0;
                string[] chunks = key.Split('-');
                //int chunkNum = 0;
                int[] chunkValue = new int[5];
                bool pickNumber = true;
                int firstNumber = 0;
                for (int i = 0; i < chunks.Length; i++)
                {
                    string chunk = chunks[i];
                    char[] chars = chunk.ToArray();
                    for (int j = 0; j < chars.Length; j++)
                    {
                        int value = chars[j];
                        chunkValue[i] += value;
                        score += value;
                        if (value < 97 && pickNumber)
                        {
                            pickNumber = false;
                            firstNumber = int.Parse(chars[j].ToString());
                        }
                    }
                }

                //foreach (string chunk in chunks)
                //{
                //    chunkNum++;
                //    if (chunk.Length != 4)
                //        return false;
                //    foreach (char an in chunk)
                //    {
                //        int value = an;
                //        if (value == checkDigit)
                //            checkDigitCount++;
                //        score += value;
                //        if (value < 97 && pickNumber)
                //        {
                //            pickNumber = false;
                //            firstNumber = int.Parse(an.ToString());
                //        }
                //    }

                if (/*score == 1882 && checkDigitCount == 3*/ true)
                {
                    MessageBox.Show(" | " + firstNumber);
                    return true;
                }
            }
            return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtKeys.Text = Generate();
        }

        private void btnGiveValues_Click(object sender, EventArgs e)
        {
            int valuea = 0;
            int valueb = 0;
            bool isValid = false;
            string cnpj = mtbCNPJ.Text.Replace(" ","");
            if (cnpj.Length == 14)
            {
                char[] chars = cnpj.Substring(0, 12).ToArray();
                int sum = 0;
                int mult = 1;
                for (int i = chars.Length -1 ; i >= 0; i--)
                {
                    if (mult == 9)
                        mult = 2;
                    else
                        mult++;
                    int valor = int.Parse(chars[i].ToString());
                    sum += (mult * valor);
                }
                valuea = sum;
                int resto = sum % 11;
                int eighth = int.Parse(cnpj.Substring(12, 1));
                if ((11 - resto) == eighth)
                {
                    chars = cnpj.Substring(0, 13).ToArray();
                    sum = 0;
                    mult = 1;
                    for (int i = chars.Length - 1; i >= 0; i--)
                    {
                        if (mult == 9)
                            mult = 2;
                        else
                            mult++;
                        int valor = int.Parse(chars[i].ToString());
                        sum += (mult * valor);
                    }
                    valueb = sum;
                    resto = sum % 11;
                    eighth = int.Parse(cnpj.Substring(13, 1));
                    if ((11 - resto) == eighth)
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                else
                {
                    isValid = false;
                }
            }

            if (isValid)
                lblValidOrNot.Text = "Valido";
            else
                lblValidOrNot.Text = "Inválido";

            if (cnpj.Length == 14)
            {
                int digitA = int.Parse(cnpj.Substring(12, 2));
                MessageBox.Show((valuea + valueb + digitA).ToString()); 
            }
        }

        private void Cheque()
        {

        }
    }
}
