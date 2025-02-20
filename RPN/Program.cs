using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPN
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Testing ArrayStack<T> Implementation\n");

            // Stack of integers
            ArrayStack<int> intStack = new ArrayStack<int>(5);
            Console.WriteLine("Pushing values: 10, 20, 30");
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);

            Console.WriteLine($"Peek: {intStack.Peek()}"); // Should print 30
            Console.WriteLine($"Pop: {intStack.Pop()}");  // Should print 30
            Console.WriteLine($"Pop: {intStack.Pop()}");  // Should print 20
            Console.WriteLine($"Is Empty: {intStack.IsEmpty()}"); // False
            Console.WriteLine($"Pop: {intStack.Pop()}");  // Should print 10
            Console.WriteLine($"Is Empty: {intStack.IsEmpty()}"); // True

            // Stack of strings
            ArrayStack<string> stringStack = new ArrayStack<string>(3);
            stringStack.Push("Hello");
            stringStack.Push("World");
            Console.WriteLine($"Peek: {stringStack.Peek()}"); // Should print "World"
            Console.WriteLine($"Pop: {stringStack.Pop()}");  // Should print "World"
            Console.WriteLine($"Pop: {stringStack.Pop()}");  // Should print "Hello"
            Console.WriteLine($"Is Empty: {stringStack.IsEmpty()}"); // True
            Application.Run(new Form1());
        }
    }
}
