using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new LoggerManager();
            var logger = manager.Logger;
            logger.Log("Foo");
        }
    }
}
