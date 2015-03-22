using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternHandsOn
{
    class Logger
    {
        private static Logger log = null;

        private Logger() { }

        public static Logger LoggerInstance
        {
            get
            {
                if (log == null) log = new Logger();
                return log;
            }
        }
    }
}
