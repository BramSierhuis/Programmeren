using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class Logger
    {
        private static Logger instance;
        private int numberOfLines = 0;

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                    instance = new Logger();

                return instance;
            }
        }

        public void Log(string origin, string msg)
        {
            numberOfLines++;
            Console.WriteLine("{0} - [{1}] {2}", numberOfLines, origin, msg);
        }
    }
}
