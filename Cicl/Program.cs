using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cicl
{
    internal class Program
    {
        public static int sum(int a, int b)
        {
            Debug.WriteLine($"{a} {b}");
            var file = new TextWriterTraceListener("test.txt");
            Trace.Listeners.Add(file);
            Trace.AutoFlush = true;
            Trace.WriteLine($"{a} {b}");
            return a + b;
        }
        static void Main(string[] args)
        {
            sum(4, 5);
        }
    }
}
