using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("x = ");
                string str = Console.ReadLine(); // takes string input
                if (str == "exit") // if user input is "exit" this will stop tho code from executing
                {
                    break;
                }
                double firstNumber = Convert.ToDouble(str);

                Console.Write("y = ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("What operation do you want to do: ");
                char operationSign = Convert.ToChar(Console.ReadLine());

                switch (operationSign)
                {
                    case '+':
                        Console.WriteLine("your answer is {0}", firstNumber + secondNumber);
                        break;
                    case '-':
                        Console.WriteLine("your answer is {0}", firstNumber - secondNumber);
                        break;
                    case '*':
                        Console.WriteLine("your answer is {0}", firstNumber * secondNumber);
                        break;
                    case '/':
                        Console.WriteLine("your answer is {0}", firstNumber / secondNumber);
                        break;
                }
            }
            while (true);
            Console.Read();
        }
       
    }
}
