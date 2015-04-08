using System;
using System.Runtime.InteropServices;

namespace RustTester
{
    class Program
    {
        [DllImport("foo.dll")]
        private static extern uint foo(uint value1, uint value2);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello from C#. The result is {0}", foo(5, 20));
        }
    }
}
