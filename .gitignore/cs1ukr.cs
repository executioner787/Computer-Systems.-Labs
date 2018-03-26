﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cslab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //text file directories
            string dir1 = "text1.txt";
            int[] textarray1 = new int[51];
            string dir2 = "text2.txt";
            int[] textarray2 = new int[51];
            string dir3 = "text3.txt";
            int[] textarray3 = new int[51];
            //proccessing
            CalculateText(dir1, textarray1);
            ShowResult(dir1, textarray1);

            CalculateText(dir2, textarray2);
            ShowResult(dir2, textarray2);

            CalculateText(dir3, textarray3);
            ShowResult(dir3, textarray3);

            Console.ReadLine();
        }
        //calculates entropy of the text
        static double Entropy(int[] textarray)
        {
            double result = 0;
            double p = 0;
            //result = sum (1 to m) p*log2(1/p)
            for (int i = 1; i < 46; i++)
            {
                p = (double)textarray[i] / (double)textarray[0];
                if (p != 0)
                {
                    result += p * Math.Log((double)1 / p, 2);
                }
            }
            return result;
        }
        static int AmountOfInformation(double entropy, int amount)
        {
            int am_bits = (int)Math.Ceiling(entropy * amount);
            return (int)Math.Ceiling((double)am_bits / (double)8);//returns result in bytes
        }
        //prints the result of calculations
        static void ShowResult(string dir, int[] textarray)
        {
            Console.WriteLine();
            Console.WriteLine("Textfile: " + dir);
            Console.WriteLine("Overall number of symbols: {0}", textarray[0]);
            Console.WriteLine("Number of letters:");
            Console.WriteLine("  а - {0} ({1}%)", textarray[1], ((double)textarray[1] / (double)textarray[0]) * 100);
            Console.WriteLine("  б - {0} ({1}%)", textarray[2], ((double)textarray[2] / (double)textarray[0]) * 100);
            Console.WriteLine("  в - {0} ({1}%)", textarray[3], ((double)textarray[3] / (double)textarray[0]) * 100);
            Console.WriteLine("  г - {0} ({1}%)", textarray[4], ((double)textarray[4] / (double)textarray[0]) * 100);
            Console.WriteLine("  д - {0} ({1}%)", textarray[5], ((double)textarray[5] / (double)textarray[0]) * 100);
            Console.WriteLine("  е - {0} ({1}%)", textarray[6], ((double)textarray[6] / (double)textarray[0]) * 100);
            Console.WriteLine("  є - {0} ({1}%)", textarray[7], ((double)textarray[7] / (double)textarray[0]) * 100);
            Console.WriteLine("  ж - {0} ({1}%)", textarray[8], ((double)textarray[8] / (double)textarray[0]) * 100);
            Console.WriteLine("  з - {0} ({1}%)", textarray[9], ((double)textarray[9] / (double)textarray[0]) * 100);
            Console.WriteLine("  и - {0} ({1}%)", textarray[10], ((double)textarray[10] / (double)textarray[0]) * 100);
            Console.WriteLine("  і - {0} ({1}%)", textarray[11], ((double)textarray[11] / (double)textarray[0]) * 100);
            Console.WriteLine("  ї - {0} ({1}%)", textarray[12], ((double)textarray[12] / (double)textarray[0]) * 100);
            Console.WriteLine("  й - {0} ({1}%)", textarray[13], ((double)textarray[13] / (double)textarray[0]) * 100);
            Console.WriteLine("  к - {0} ({1}%)", textarray[14], ((double)textarray[14] / (double)textarray[0]) * 100);
            Console.WriteLine("  л - {0} ({1}%)", textarray[15], ((double)textarray[15] / (double)textarray[0]) * 100);
            Console.WriteLine("  м - {0} ({1}%)", textarray[16], ((double)textarray[16] / (double)textarray[0]) * 100);
            Console.WriteLine("  н - {0} ({1}%)", textarray[17], ((double)textarray[17] / (double)textarray[0]) * 100);
            Console.WriteLine("  о - {0} ({1}%)", textarray[18], ((double)textarray[18] / (double)textarray[0]) * 100);
            Console.WriteLine("  п - {0} ({1}%)", textarray[19], ((double)textarray[19] / (double)textarray[0]) * 100);
            Console.WriteLine("  р - {0} ({1}%)", textarray[20], ((double)textarray[20] / (double)textarray[0]) * 100);
            Console.WriteLine("  с - {0} ({1}%)", textarray[21], ((double)textarray[21] / (double)textarray[0]) * 100);
            Console.WriteLine("  т - {0} ({1}%)", textarray[22], ((double)textarray[22] / (double)textarray[0]) * 100);
            Console.WriteLine("  у - {0} ({1}%)", textarray[23], ((double)textarray[23] / (double)textarray[0]) * 100);
            Console.WriteLine("  ф - {0} ({1}%)", textarray[24], ((double)textarray[24] / (double)textarray[0]) * 100);
            Console.WriteLine("  х - {0} ({1}%)", textarray[25], ((double)textarray[25] / (double)textarray[0]) * 100);
            Console.WriteLine("  ц - {0} ({1}%)", textarray[26], ((double)textarray[26] / (double)textarray[0]) * 100);
            Console.WriteLine("  ч - {0} ({1}%)", textarray[46], ((double)textarray[46] / (double)textarray[0]) * 100);
            Console.WriteLine("  ш - {0} ({1}%)", textarray[47], ((double)textarray[47] / (double)textarray[0]) * 100);
            Console.WriteLine("  щ - {0} ({1}%)", textarray[48], ((double)textarray[48] / (double)textarray[0]) * 100);
            Console.WriteLine("  ь - {0} ({1}%)", textarray[49], ((double)textarray[49] / (double)textarray[0]) * 100);
            Console.WriteLine("  ю - {0} ({1}%)", textarray[50], ((double)textarray[50] / (double)textarray[0]) * 100);
            Console.WriteLine("  я - {0} ({1}%)", textarray[44], ((double)textarray[44] / (double)textarray[0]) * 100);
            Console.WriteLine("Number of special symbols:");
            Console.WriteLine("  1 - {0} ({1}%)", textarray[27], ((double)textarray[27] / (double)textarray[0]) * 100);
            Console.WriteLine("  2 - {0} ({1}%)", textarray[28], ((double)textarray[28] / (double)textarray[0]) * 100);
            Console.WriteLine("  3 - {0} ({1}%)", textarray[29], ((double)textarray[29] / (double)textarray[0]) * 100);
            Console.WriteLine("  4 - {0} ({1}%)", textarray[30], ((double)textarray[30] / (double)textarray[0]) * 100);
            Console.WriteLine("  5 - {0} ({1}%)", textarray[31], ((double)textarray[31] / (double)textarray[0]) * 100);
            Console.WriteLine("  6 - {0} ({1}%)", textarray[32], ((double)textarray[32] / (double)textarray[0]) * 100);
            Console.WriteLine("  7 - {0} ({1}%)", textarray[33], ((double)textarray[33] / (double)textarray[0]) * 100);
            Console.WriteLine("  8 - {0} ({1}%)", textarray[34], ((double)textarray[34] / (double)textarray[0]) * 100);
            Console.WriteLine("  9 - {0} ({1}%)", textarray[35], ((double)textarray[35] / (double)textarray[0]) * 100);
            Console.WriteLine("  0 - {0} ({1}%)", textarray[36], ((double)textarray[36] / (double)textarray[0]) * 100);
            Console.WriteLine("  space - {0} ({1}%)", textarray[37], ((double)textarray[37] / (double)textarray[0]) * 100);
            Console.WriteLine("  . - {0} ({1}%)", textarray[38], ((double)textarray[38] / (double)textarray[0]) * 100);
            Console.WriteLine("  , - {0} ({1}%)", textarray[39], ((double)textarray[39] / (double)textarray[0]) * 100);
            Console.WriteLine("  ! - {0} ({1}%)", textarray[40], ((double)textarray[40] / (double)textarray[0]) * 100);
            Console.WriteLine("  ? - {0} ({1}%)", textarray[41], ((double)textarray[41] / (double)textarray[0]) * 100);
            Console.WriteLine("  : and ; - {0} ({1}%)", textarray[42], ((double)textarray[42] / (double)textarray[0]) * 100);
            Console.WriteLine("  '-' - {0} ({1}%)", textarray[43], ((double)textarray[43] / (double)textarray[0]) * 100);
            Console.WriteLine("Number of other symbols: {0} ({1}%)", textarray[45], ((double)textarray[45] / (double)textarray[0]) * 100);
            double temp_entropy = Entropy(textarray);
            Console.WriteLine("Entropy: {0}", temp_entropy);
            Console.WriteLine("Amount Of Information: {0} | {1}", AmountOfInformation(temp_entropy, textarray[0]), new FileInfo(dir).Length);
            Console.WriteLine();
        }
        //calculates the number of specific symbols, and overall number of symbols
        static void CalculateText(string dir, int[] textarray)
        {
            string symbol = "", line = "";
            using(TextReader tr = new StreamReader(dir))
            {
                while(tr.Peek() != -1)
                {
                    line = tr.ReadLine();
                    for(int i =0;i<line.Length;i++)
                    {
                        symbol = line.Substring(i, 1);
                        textarray[TextArrayIndex(symbol)] = textarray[TextArrayIndex(symbol)] + 1;
                        textarray[0] = textarray[0] + 1;
                    }
                }
            }
        }
        //calculates index of symbol in textarray
        static int TextArrayIndex(string symbol)
        {
            int result = 0;
            symbol = symbol.ToLower();
            switch (symbol)
            {
                case "а":
                    result = 1;
                    break;
                case "б":
                    result = 2;
                    break;
                case "в":
                    result = 3;
                    break;
                case "г":
                    result = 4;
                    break;
                case "д":
                    result = 5;
                    break;
                case "е":
                    result = 6;
                    break;
                case "є":
                    result = 7;
                    break;
                case "ж":
                    result = 8;
                    break;
                case "з":
                    result = 9;
                    break;
                case "и":
                    result = 10;
                    break;
                case "і":
                    result = 11;
                    break;
                case "ї":
                    result = 12;
                    break;
                case "й":
                    result = 13;
                    break;
                case "к":
                    result = 14;
                    break;
                case "л":
                    result = 15;
                    break;
                case "м":
                    result = 16;
                    break;
                case "н":
                    result = 17;
                    break;
                case "о":
                    result = 18;
                    break;
                case "п":
                    result = 19;
                    break;
                case "р":
                    result = 20;
                    break;
                case "с":
                    result = 21;
                    break;
                case "т":
                    result = 22;
                    break;
                case "у":
                    result = 23;
                    break;
                case "ф":
                    result = 24;
                    break;
                case "х":
                    result = 25;
                    break;
                case "ц":
                    result = 26;
                    break;
                case "1":
                    result = 27;
                    break;
                case "2":
                    result = 28;
                    break;
                case "3":
                    result = 29;
                    break;
                case "4":
                    result = 30;
                    break;
                case "5":
                    result = 31;
                    break;
                case "6":
                    result = 32;
                    break;
                case "7":
                    result = 33;
                    break;
                case "8":
                    result = 34;
                    break;
                case "9":
                    result = 35;
                    break;
                case "0":
                    result = 36;
                    break;
                case " ":
                    result = 37;
                    break;
                case ".":
                    result = 38;
                    break;
                case ",":
                    result = 39;
                    break;
                case "!":
                    result = 40;
                    break;
                case "?":
                    result = 41;
                    break;
                case ":":
                case ";":
                    result = 42;
                    break;
                case "-":
                    result = 43;
                    break;
                case "я":
                    result = 44;
                    break;
                case "ч":
                    result = 46;
                    break;
                case "ш":
                    result = 47;
                    break;
                case "щ":
                    result = 48;
                    break;
                case "ь":
                    result = 49;
                    break;
                case "ю":
                    result = 50;
                    break;
                default:
                    result = 45;
                    break;
            }
            return result;
        }
    }
}
