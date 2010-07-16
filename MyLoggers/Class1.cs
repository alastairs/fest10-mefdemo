using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MEFDemo;

namespace MyLoggers
{
    public class MyWriter : ILogWriter
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
