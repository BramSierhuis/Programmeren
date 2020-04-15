using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = string.Empty;
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("Wrong Data");
                }
            }
            catch (Exception ex)
            {
                ErrorLogging(ex);
                ReadError();
            }

            Console.ReadKey();
        }

        public static void ErrorLogging(Exception ex)
        {
            string strPath = "Log.txt";
            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(strPath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);
            }
        }

        public static void ReadError()
        {
            string strPath = "Log.txt";
            using (StreamReader sr = new StreamReader(strPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

