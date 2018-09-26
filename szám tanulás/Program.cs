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
        {/*
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
            }*/
            Console.WriteLine(get_string(222));
            Console.WriteLine(get_string(12));
            Console.ReadLine();
        }
        static string get_string(int num)
        {
            string correct = "";
            //if (num > 12) throw new Exception();
            if (num.ToString().Length > 3) throw new Exception();
            #region száz
            if (num.ToString().Length>2)switch(Convert.ToInt32(num.ToString()[num.ToString().Length-3]+""))
                {
                    case 1:
                        correct += "einhundert";
                        break;
                    case 2:
                        correct += "zweihundert";
                        break;
                    case 3:
                        correct += "dreihundert";
                        break;
                    case 4:
                        correct += "vierhundert";
                        break;
                    case 5:
                        correct += "fünfhundert";
                        break;
                    case 6:
                        correct += "sechshundert";
                        break;
                    case 7:
                        correct += "siebenhundert";
                        break;
                    case 8:
                        correct += "achthundert";
                        break;
                    case 9:
                        correct += "neunhundert";
                        break;
                }

            #endregion
            #region tíz és egy
            if (num < 10)
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
                }
            }
            else
            {
                if (Convert.ToInt32(num.ToString()[num.ToString().Length - 2]+""+ num.ToString()[num.ToString().Length - 1]) < 20)
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
                else // szám nagyobb vagy egyenéő mint húsz
                {
                    if (num.ToString()[num.ToString().Length - 2] != '0')
                    {

                    }
                    if (num.ToString()[num.ToString().Length - 1] == '0')
                    {

                    }
                }
            }
            #endregion
            return correct;
        }
    }
}
