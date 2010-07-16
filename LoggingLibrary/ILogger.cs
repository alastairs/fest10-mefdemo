using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEFDemo
{
    // Thing the framework consumer uses to write log messages.
    public interface ILogger
    {
        void Log(string message);
    }
}
