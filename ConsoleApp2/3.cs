using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    class Program
    {
        public static void Main()
        {
            Operation per1 = Operation.Add;
            Operation per2 = Operation.Subtract;
            Operation per3 = Operation.Multiply;
            Operation per4 = Operation.Divide;
            OperationNumber(per1);
            OperationNumber(per2);
            OperationNumber(per3);
            OperationNumber(per4);
        }
        public static void OperationNumber(Operation per)
        {
            switch (per)
            {
                case Operation.Add:
                    Console.WriteLine($"{4+3}");
                    break;
                case Operation.Subtract:
                    Console.WriteLine($"{3 - 2}");
                    break;
                case Operation.Multiply:
                    Console.WriteLine($"{6 * 6}");
                    break;
                case Operation.Divide:
                    Console.WriteLine($"{36 /6}");
                    break;
                default:
                    Console.WriteLine("Недопустимый оператор");
                    break;
            }
        }
    }
}
