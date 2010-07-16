using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using LoggingLibrary;

namespace MEFDemo
{
    public class LoggerManager
    {
        private static CompositionContainer _container;

        // Hides MEF from the outside world so users don't have to use MEF if they don't want/need to.
        static LoggerManager() {
            // AggregateCatalog is a catalog of catalogs.  Allows you to change your mind later on without hassle.
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(LoggerManager).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog(@".\Extensions"));

            _container = new CompositionContainer();
        }

        [ImportMany]
        public IEnumerable<ILoggerModule> Modules { get; set; }

        [Import]
        public ILogger Logger { get; private set; }

        public LoggerManager()
        {
            _container.SatisfyImportsOnce(this);
        }
    }
}
