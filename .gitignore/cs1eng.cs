using System;
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
            string dir1 = "64text1.txt";
            int[] textarray1 = new int[50];
            string dir2 = "64text2.txt";
            int[] textarray2 = new int[50];
            string dir3 = "64text3.txt";
            int[] textarray3 = new int[50];
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
            Console.WriteLine("  a - {0} ({1}%)", textarray[1], ((double)textarray[1] / (double)textarray[0]) * 100);
            Console.WriteLine("  b - {0} ({1}%)", textarray[2], ((double)textarray[2] / (double)textarray[0]) * 100);
            Console.WriteLine("  c - {0} ({1}%)", textarray[3], ((double)textarray[3] / (double)textarray[0]) * 100);
            Console.WriteLine("  d - {0} ({1}%)", textarray[4], ((double)textarray[4] / (double)textarray[0]) * 100);
            Console.WriteLine("  e - {0} ({1}%)", textarray[5], ((double)textarray[5] / (double)textarray[0]) * 100);
            Console.WriteLine("  f - {0} ({1}%)", textarray[6], ((double)textarray[6] / (double)textarray[0]) * 100);
            Console.WriteLine("  g - {0} ({1}%)", textarray[7], ((double)textarray[7] / (double)textarray[0]) * 100);
            Console.WriteLine("  h - {0} ({1}%)", textarray[8], ((double)textarray[8] / (double)textarray[0]) * 100);
            Console.WriteLine("  i - {0} ({1}%)", textarray[9], ((double)textarray[9] / (double)textarray[0]) * 100);
            Console.WriteLine("  j - {0} ({1}%)", textarray[10], ((double)textarray[10] / (double)textarray[0]) * 100);
            Console.WriteLine("  k - {0} ({1}%)", textarray[11], ((double)textarray[11] / (double)textarray[0]) * 100);
            Console.WriteLine("  l - {0} ({1}%)", textarray[12], ((double)textarray[12] / (double)textarray[0]) * 100);
            Console.WriteLine("  m - {0} ({1}%)", textarray[13], ((double)textarray[13] / (double)textarray[0]) * 100);
            Console.WriteLine("  n - {0} ({1}%)", textarray[14], ((double)textarray[14] / (double)textarray[0]) * 100);
            Console.WriteLine("  o - {0} ({1}%)", textarray[15], ((double)textarray[15] / (double)textarray[0]) * 100);
            Console.WriteLine("  p - {0} ({1}%)", textarray[16], ((double)textarray[16] / (double)textarray[0]) * 100);
            Console.WriteLine("  q - {0} ({1}%)", textarray[17], ((double)textarray[17] / (double)textarray[0]) * 100);
            Console.WriteLine("  r - {0} ({1}%)", textarray[18], ((double)textarray[18] / (double)textarray[0]) * 100);
            Console.WriteLine("  s - {0} ({1}%)", textarray[19], ((double)textarray[19] / (double)textarray[0]) * 100);
            Console.WriteLine("  t - {0} ({1}%)", textarray[20], ((double)textarray[20] / (double)textarray[0]) * 100);
            Console.WriteLine("  u - {0} ({1}%)", textarray[21], ((double)textarray[21] / (double)textarray[0]) * 100);
            Console.WriteLine("  v - {0} ({1}%)", textarray[22], ((double)textarray[22] / (double)textarray[0]) * 100);
            Console.WriteLine("  w - {0} ({1}%)", textarray[23], ((double)textarray[23] / (double)textarray[0]) * 100);
            Console.WriteLine("  x - {0} ({1}%)", textarray[24], ((double)textarray[24] / (double)textarray[0]) * 100);
            Console.WriteLine("  y - {0} ({1}%)", textarray[25], ((double)textarray[25] / (double)textarray[0]) * 100);
            Console.WriteLine("  z - {0} ({1}%)", textarray[26], ((double)textarray[26] / (double)textarray[0]) * 100);
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
            Console.WriteLine("  ( and ) - {0} ({1}%)", textarray[44], ((double)textarray[44] / (double)textarray[0]) * 100);
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
                case "a":
                    result = 1;
                    break;
                case "b":
                    result = 2;
                    break;
                case "c":
                    result = 3;
                    break;
                case "d":
                    result = 4;
                    break;
                case "e":
                    result = 5;
                    break;
                case "f":
                    result = 6;
                    break;
                case "g":
                    result = 7;
                    break;
                case "h":
                    result = 8;
                    break;
                case "i":
                    result = 9;
                    break;
                case "j":
                    result = 10;
                    break;
                case "k":
                    result = 11;
                    break;
                case "l":
                    result = 12;
                    break;
                case "m":
                    result = 13;
                    break;
                case "n":
                    result = 14;
                    break;
                case "o":
                    result = 15;
                    break;
                case "p":
                    result = 16;
                    break;
                case "q":
                    result = 17;
                    break;
                case "r":
                    result = 18;
                    break;
                case "s":
                    result = 19;
                    break;
                case "t":
                    result = 20;
                    break;
                case "u":
                    result = 21;
                    break;
                case "v":
                    result = 22;
                    break;
                case "w":
                    result = 23;
                    break;
                case "x":
                    result = 24;
                    break;
                case "y":
                    result = 25;
                    break;
                case "z":
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
                case "(":
                case ")":
                    result = 44;
                    break;
                default:
                    result = 45;
                    break;
            }
            return result;
        }
    }
}
