using System;

namespace Week2_Var
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter your first integer to be computed for: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter your second integer to be computer for: ");
            string num2 = Console.ReadLine();

            Console.WriteLine("Your solutions are: ");
            float total = float.Parse(num1) + float.Parse(num2);
            float total2 = float.Parse(num1) - float.Parse(num2);
            float total3 = float.Parse(num1) * float.Parse(num2);
            float total4 = float.Parse(num1) / float.Parse(num2);
            Console.WriteLine("{0} + {1} = {2}",num1, num2, total);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, total2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, total3);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, total4);
        }
    }
}
