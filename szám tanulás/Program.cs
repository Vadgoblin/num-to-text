using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szám_tanulás
{
    class Program
    {
        static void Main(string[] args)
        {
            int last = 0;
            Random r = new Random();
            while (true)
            {
                r:
                int num = r.Next(1, 13);
                if (last == num) goto r;
                last = num;
                Console.WriteLine(num);
                string _try = Console.ReadLine();
                if(get_string(num)==_try)
                {
                    Console.WriteLine("jó");
                }
                else
                    Console.WriteLine("Rossz! "+ get_string(num));
                Console.ReadLine();
                Console.Clear();
            }
        }
        static string get_string(int num)
        {
            string correct = "";
            /*
            switch (num)
            {
                case 1:
                    correct = "eins";
                    break;
                case 2:
                    correct = "zwei";
                    break;
                case 3:
                    correct = "drei";
                    break;
                case 4:
                    correct = "vier";
                    break;

                case 5:
                    correct = "fünf";
                    break;
                case 6:
                    correct = "sechs";
                    break;
                case 7:
                    correct = "sieben";
                    break;
                case 8:
                    correct = "acht";
                    break;
                case 9:
                    correct = "neun";
                    break;
                case 10:
                    correct = "zehn";
                    break;
                case 11:
                    correct = "elf";
                    break;
                case 12:
                    correct = "zwölf";
                    break;
            }
            */
            if (num > 12) throw new Exception();


            if(num<20)
            {
                switch (num)
                {
                    case 1:
                        correct += "eins";
                        break;
                    case 2:
                        correct += "zwei";
                        break;
                    case 3:
                        correct += "drei";
                        break;
                    case 4:
                        correct += "vier";
                        break;

                    case 5:
                        correct += "fünf";
                        break;
                    case 6:
                        correct += "sechs";
                        break;
                    case 7:
                        correct += "sieben";
                        break;
                    case 8:
                        correct += "acht";
                        break;
                    case 9:
                        correct += "neun";
                        break;
                    case 10:
                        correct += "zehn";
                        break;
                    case 11:
                        correct += "elf";
                        break;
                    case 12:
                        correct += "zwölf";
                        break;
                    case 13:
                        correct += "dreizehn";
                        break;
                    case 14:
                        correct += "vierzehn";
                        break;
                    case 15:
                        correct += "fünfzehn";
                        break;
                    case 16:
                        correct += "sechzehn";
                        break;
                    case 17:
                        correct += "siebzehn";
                        break;
                    case 18:
                        correct += "achtzehn";
                        break;
                    case 19:
                        correct += "neunzehn";
                        break;
                }
            }
            return correct;
        }
    }
}
