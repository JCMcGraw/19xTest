using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp19x1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World 2");
            Messages messages = new Messages();
            Console.WriteLine(messages.message1);
            Console.ReadKey();
        }
    }
}
