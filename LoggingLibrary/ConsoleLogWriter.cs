using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MEFDemo
{
    public class ConsoleLogWriter : ILogWriter
    {
        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}
