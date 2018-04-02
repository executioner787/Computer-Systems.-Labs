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
            string dir1 = "text1.txt";
            string dir2 = "text2.txt";
            string dir3 = "text3.txt";
            //proccessing
            WriteResultFile(EncodeText(dir1), "64text1.txt");
            WriteResultFile(EncodeText(dir2), "64text2.txt");
            WriteResultFile(EncodeText(dir3), "64text3.txt");

            Console.ReadLine();
        }
        //encode text to base64
        static string EncodeText(string dir)
        {
            string result = "";
            result = ToBase64(dir);
            return result;
        }
        static bool[] IntToBinary(int value)
        {
            bool[] b = new bool[8];
            for (int i = 7; i >= 0; i--)
            {
                b[i] = (value % 2 == 1) ? true : false;
                value /= 2;
            }
            return b;
        }
        static bool[] ReadBitsFromFile(string path)
        {
            byte[] data = File.ReadAllBytes(path);
            bool[] bits = new bool[data.Length * 8], temp;
            for (int i = data.Length - 1; i >= 0; i--)
            {
                temp = IntToBinary(data[i]);
                for (int l = 0; l < temp.Length; l++)
                    bits[i * 8 + l] = temp[l];
            }
            return bits;
        }
        //write file
        static void WriteResultFile(string text, string dir)
        {
            using (StreamWriter sw = new StreamWriter(dir, false))
            {
                sw.Write(text);
            }
            Console.WriteLine("ready");
        }
        static string ToBase64(string text)
        {
            string result = "";
            int num_temp = 0;
            bool[] bits = ReadBitsFromFile(text);
            for (int i = 0; i < bits.Length; i += 6)
            {
                if (i + 6 <= bits.Length)
                {
                    if (bits[i])
                    {
                        num_temp += 32;
                    }
                    if (bits[i + 1])
                    {
                        num_temp += 16;
                    }
                    if (bits[i + 2])
                    {
                        num_temp += 8;
                    }
                    if (bits[i + 3])
                    {
                        num_temp += 4;
                    }
                    if (bits[i + 4])
                    {
                        num_temp += 2;
                    }
                    if (bits[i + 5])
                    {
                        num_temp += 1;
                    }
                    result += NumToSymbol(num_temp);
                } else if (i + 4 == bits.Length)
                {
                    if (bits[i])
                    {
                        num_temp += 32;
                    }
                    if (bits[i + 1])
                    {
                        num_temp += 16;
                    }
                    if (bits[i + 2])
                    {
                        num_temp += 8;
                    }
                    if (bits[i + 3])
                    {
                        num_temp += 4;
                    }
                    result += NumToSymbol(num_temp);
                    result += "=";
                }
                else
                {
                    if (bits[i])
                    {
                        num_temp += 32;
                    }
                    if (bits[i + 1])
                    {
                        num_temp += 16;
                    }
                    result += NumToSymbol(num_temp);
                    result += "==";
                }
                num_temp = 0;
            }
            return result;
        }
        static string NumToSymbol(int num)
        {
            string result = "";
            switch (num)
            {
                case 0:
                    result += "A";
                    break;
                case 1:
                    result += "B";
                    break;
                case 2:
                    result += "C";
                    break;
                case 3:
                    result += "D";
                    break;
                case 4:
                    result += "E";
                    break;
                case 5:
                    result += "F";
                    break;
                case 6:
                    result += "G";
                    break;
                case 7:
                    result += "H";
                    break;
                case 8:
                    result += "I";
                    break;
                case 9:
                    result += "J";
                    break;
                case 10:
                    result += "K";
                    break;
                case 11:
                    result += "L";
                    break;
                case 12:
                    result += "M";
                    break;
                case 13:
                    result += "N";
                    break;
                case 14:
                    result += "O";
                    break;
                case 15:
                    result += "P";
                    break;
                case 16:
                    result += "Q";
                    break;
                case 17:
                    result += "R";
                    break;
                case 18:
                    result += "S";
                    break;
                case 19:
                    result += "T";
                    break;
                case 20:
                    result += "U";
                    break;
                case 21:
                    result += "V";
                    break;
                case 22:
                    result += "W";
                    break;
                case 23:
                    result += "X";
                    break;
                case 24:
                    result += "Y";
                    break;
                case 25:
                    result += "Z";
                    break;
                case 26:
                    result += "a";
                    break;
                case 27:
                    result += "b";
                    break;
                case 28:
                    result += "c";
                    break;
                case 29:
                    result += "d";
                    break;
                case 30:
                    result += "e";
                    break;
                case 31:
                    result += "f";
                    break;
                case 32:
                    result += "g";
                    break;
                case 33:
                    result += "h";
                    break;
                case 34:
                    result += "i";
                    break;
                case 35:
                    result += "j";
                    break;
                case 36:
                    result += "k";
                    break;
                case 37:
                    result += "l";
                    break;
                case 38:
                    result += "m";
                    break;
                case 39:
                    result += "n";
                    break;
                case 40:
                    result += "o";
                    break;
                case 41:
                    result += "p";
                    break;
                case 42:
                    result += "q";
                    break;
                case 43:
                    result += "r";
                    break;
                case 44:
                    result += "s";
                    break;
                case 45:
                    result += "t";
                    break;
                case 46:
                    result += "u";
                    break;
                case 47:
                    result += "v";
                    break;
                case 48:
                    result += "w";
                    break;
                case 49:
                    result += "x";
                    break;
                case 50:
                    result += "y";
                    break;
                case 51:
                    result += "z";
                    break;
                case 52:
                    result += "0";
                    break;
                case 53:
                    result += "1";
                    break;
                case 54:
                    result += "2";
                    break;
                case 55:
                    result += "3";
                    break;
                case 56:
                    result += "4";
                    break;
                case 57:
                    result += "5";
                    break;
                case 58:
                    result += "6";
                    break;
                case 59:
                    result += "7";
                    break;
                case 60:
                    result += "8";
                    break;
                case 61:
                    result += "9";
                    break;
                case 62:
                    result += "+";
                    break;
                default:
                    result += "/";
                    break;
            }
            return result;
        }
    }
}
