using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValues
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcValues();
        }

        private static void GenerateAll()
        {
            Console.ReadKey();
        }

        private bool VerifyCNPJ(string rawcnpj)
        {
            int valuea = 0;
            int valueb = 0;
            bool isValid = false;
            string cnpj = rawcnpj.Replace(" ", "");
            if (cnpj.Length == 14)
            {
                char[] chars = cnpj.Substring(0, 12).ToArray();
                int sum = 0;
                int mult = 1;
                for (int i = chars.Length - 1; i >= 0; i--)
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


                if (isValid)
                {
                    int digitA = int.Parse(cnpj.Substring(12, 2));
                    Console.WriteLine((valuea + valueb + digitA).ToString());
                }
            }
            return false;
        }

        private static void CalcValues()
        {
            //string sample = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789";
            //string sampleMin = "abcdefghijklmnopqrstuvwxyz";
            string sampleMinNum = "abcdefghijklmnopqrstuvwxyz0123456789";
            //string sampleMai = "ABCDEFGHIJKLMENOPQRSTUVWXYZ";
            //string sampleMaiNum = "ABCDEFGHIJKLMENOPQRSTUVWXYZ0123456789";
            //string sampleNum = "0123456789";

            //Console.WriteLine("Amostra Geral");
            //char[] chars = sample.ToArray();
            //int total = 0;
            //int quantidade = chars.Length;
            //foreach (char an in chars)
            //{
            //    int value = an;
            //    Console.WriteLine(an + " = " + value);
            //    total += value;
            //}
            //Console.WriteLine("Soma: " + total);
            //Console.WriteLine("Metade do total: " + total / 2);
            //Console.WriteLine("Média: " + total / quantidade);

            //Console.WriteLine();
            //Console.WriteLine("Amostra Minusculo");
            //chars = sampleMin.ToArray();
            //total = 0;
            //quantidade = chars.Length;
            //foreach (char an in chars)
            //{
            //    int value = an;
            //    Console.WriteLine(an + " = " + value);
            //    total += value;
            //}
            //Console.WriteLine("Soma: " + total);
            //Console.WriteLine("Metade do total: " + total / 2);
            //Console.WriteLine("Média: " + total / quantidade);

            //Console.WriteLine();
            //Console.WriteLine("Amostra Maiusculo");
            //chars = sampleMai.ToArray();
            //total = 0;
            //quantidade = chars.Length;
            //foreach (char an in chars)
            //{
            //    int value = an;
            //    Console.WriteLine(an + " = " + value);
            //    total += value;
            //}
            //Console.WriteLine("Soma: " + total);
            //Console.WriteLine("Metade do total: " + total / 2);
            //Console.WriteLine("Média: " + total / quantidade);

            //Console.WriteLine();
            //Console.WriteLine("Amostra Numeros");
            //chars = sampleNum.ToArray();
            //total = 0;
            //quantidade = chars.Length;
            //foreach (char an in chars)
            //{
            //    int value = an;
            //    Console.WriteLine(an + " = " + value);
            //    total += value;
            //}
            //Console.WriteLine("Soma: " + total);
            //Console.WriteLine("Metade do total: " + total / 2);
            //Console.WriteLine("Média: " + total / quantidade);

            Console.WriteLine();
            Console.WriteLine("Amostra Min Num");
            char[] chars = sampleMinNum.ToArray();
            int total = 0;
            int quantidade = chars.Length;
            foreach (char an in chars)
            {
                int value = an;
                Console.WriteLine(an + " = " + value);
                total += value;
            }
            Console.WriteLine("Soma: " + total);
            Console.WriteLine("Metade do total: " + total / 2);
            Console.WriteLine("Média: " + total / quantidade);

            //Console.WriteLine();
            //Console.WriteLine("Amostra Mai Num");
            //chars = sampleMaiNum.ToArray();
            //total = 0;
            //quantidade = chars.Length;
            //foreach (char an in chars)
            //{
            //    int value = an;
            //    Console.WriteLine(an + " = " + value);
            //    total += value;
            //}
            //Console.WriteLine("Soma: " + total);
            //Console.WriteLine("Metade do total: " + total / 2);
            //Console.WriteLine("Média: " + total / quantidade);

            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine();

            //for (int i = 0; i <= 9; i++)
            //{
            //    for (int j = 0; j <= 9; j++)
            //    {
            //        for (int k = 0; k <= 9; k++)
            //        {
            //            char[] nums = (i.ToString() + j.ToString() + k.ToString()).ToArray();
                        
            //            int numA = nums[0];
            //            int numB = nums[1];
            //            int numC = nums[2];

            //            int num = int.Parse($"{nums[0]}{nums[1]}{nums[2]}");
            //            if (num <=  365 && num > 0)
            //            {
            //                Console.WriteLine($"{num} | Total: {numA + numB + numC}");
            //            } 
            //        }
            //    }
            //}

            Console.ReadKey();




            //bool exit = false;
            //do
            //{
            //    Console.WriteLine("Digite um ou mais caracteres para testar o valor corespondente!");
            //    char[] vs = Console.ReadLine().ToArray();
            //    int sum = 0;
            //    foreach (char carac in vs)
            //    {
            //        int value = carac;
            //        Console.WriteLine(carac + ": " + value);
            //        sum += value;
            //    }
            //    Console.WriteLine("Soma: "+ sum + " , Média: "+ sum / (vs.Length));

            //    Console.ReadKey();

            //    Console.WriteLine("Deseja sair? (S ou N)");
            //    if (Console.ReadLine() == "S")
            //    {
            //        exit = true;
            //    }
            //} while (!exit);
        }
    }
}
