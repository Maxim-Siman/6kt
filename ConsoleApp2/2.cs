using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum Color
    {
        red,
        green,
        blue,
        Yellow,
        Cyan,
        Magenta
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Color color1 = Color.red;
            Color color2 = Color.green;
            Color color3 = Color.blue;
            Color color4 = Color.Yellow;
            Color color5 = Color.Cyan;
            Color color6 = Color.Magenta;
            PrintColor(color1);
            PrintColor(color2);
            PrintColor(color3);
            PrintColor(color4);
            PrintColor(color5);
            PrintColor(color6);
        }

        public static void PrintColor(Color color)
        {
            switch (color)
            {
                case Color.red:
                    Console.WriteLine("#FF0000 0; 0; 255");
                    break;
                case Color.green:
                    Console.WriteLine("#00FF00 0; 255; 0");
                    break;
                case Color.blue:
                    Console.WriteLine("#00BFFF 0; 191; 255");
                    break;
                case Color.Yellow:
                    Console.WriteLine("#FFFF00 255; 255; 0");
                    break;
                case Color.Cyan:
                    Console.WriteLine("#00FFFF 0, 255, 255");
                    break;
                case Color.Magenta:
                    Console.WriteLine("#FF00FF 255, 0, 255");
                    break;
                default:
                    Console.WriteLine("Такой цвет не прописан в моей скудной программе");
                    break;
            }
        }
    }
}
