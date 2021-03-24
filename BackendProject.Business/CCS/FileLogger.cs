using System;
using System.Collections.Generic;
using System.Text;

namespace BackendProject.Business.CCS
{
    public class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
