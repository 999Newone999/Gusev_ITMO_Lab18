using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            Stack<char> stack1 = new Stack<char>(); // "()"
            Stack<char> stack2 = new Stack<char>(); // "[]"
            Stack<char> stack3 = new Stack<char>(); // "{}"

            Console.WriteLine("Задание 18.");
            Console.WriteLine("Проверка корректности расстановки скобок.");
            Console.WriteLine("Введите входную строку:");
            inputString = Console.ReadLine();
            foreach (char a in inputString)
            {
                if (a == '(')
                    stack1.Push(a);
                if (a == '[')
                    stack2.Push(a);
                if (a == '{')
                    stack3.Push(a);
                if (a == ')')
                    stack1.Pop();
                if (a == ']')
                    stack2.Pop();
                if (a == '}')
                    stack3.Pop();
            }
            if ((stack1.Count() == 0) && (stack2.Count() == 0) && (stack3.Count() == 0))
                Console.WriteLine("Скобки во входной строке расставлены корректно.");
            else
                Console.WriteLine("Скобки во входной строке расставлены не корректно.");
            Console.ReadKey();
        }
    }
}
