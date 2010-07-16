using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MEFDemo
{
    public class Logger : ILogger
    {
        private IEnumerable<ILogWriter> _writers;

        [ImportingConstructor]
        public Logger([ImportMany] IEnumerable<ILogWriter> writers)
        {
            // [ImportMany] causes MEF to find all available writers and import them
            // [ImportingConstructor] causes MEF to treat the Collection parameter as an extension point.

            _writers = writers;
        }

        public void Log(string message)
        {
            foreach (var writer in _writers)
            {
                writer.Log(message);
            }
        }
    }
}
