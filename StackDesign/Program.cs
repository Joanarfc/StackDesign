using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            int number1 = 4;
            int number2 = 10;
            string text = "Have a wonderful day!";

            Console.WriteLine("Result of the Push:");

            //test the Pop of an empty stack:
            //stack.Pop();

            stack.Push(number1);
            stack.Push(number2);
            stack.Push(text);


            //test the Push of a null object into the stack:
            //stack.Push(null);


            //test the Pop in an empty stack:
            //stack.Clear();
            Console.WriteLine("\nResult of the Pop:");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }
}
