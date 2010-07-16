using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MEFDemo
{
    // Applies the export to implementing types (including other interfaces), 
    // using this interface as the contract type.
    [InheritedExport] 
    public interface ILogWriter // Thing the framework uses internally to write out log messages.
    {
        void Log(string message);
    }
}
