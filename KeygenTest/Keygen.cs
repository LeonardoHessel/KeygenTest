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
            mtbCNPJ.Text = "11222333000181";
            nudValidDays.Value = 30;
        }

        private void Generate()
        {
            DateTime creationDate = dtpCreation.Value.Date;
            string creatYear = creationDate.Year.ToString().Substring(2);
            string creatDay = creationDate.DayOfYear.ToString();
            if (creatDay.Length == 2)
                creatDay = "0" + creatDay;

            string validDays = nudValidDays.Value.ToString();
            if (validDays.Length == 2)
                validDays = "0" + validDays;

            string cnpj = mtbCNPJ.Text;

            this.random = new Random();
            string chunk = "";
            List<string> chunkList = new List<string>();

            do
            {
                chunk = GenKeyChunk();
            } while (!(GetYear(chunk, 0) == creatYear && GetDay(chunk, 2) == creatDay));

            chunkList.Add(chunk);

            do
            {
                chunk = GenKeyChunk();
            } while (!(GetDay(chunk, 2) == validDays));

            chunkList.Add(chunk);

            do
            {
                chunk = GenKeyChunk();
            } while (!(GetCNPJRef(chunk, 2) == RefCNPJ(cnpj)));

            chunkList.Add(chunk);

            do
            {
                chunk = GenKeyChunk();
                chunkList.Add(chunk);
            } while (chunkList.Count < 4);


            string key = $"{chunkList[3]}-{chunkList[2]}-{chunkList[1]}-{chunkList[0]}".ToUpper();
            txtKey.Text = key;
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


                //if (score == 1882 && checkDigitCount == 4)
                //{

                //    return true;
                //}
            }
            return false;
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
    }
}
