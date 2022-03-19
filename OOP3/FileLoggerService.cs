using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class FileLoggerService:Iloggerservice 
    {
        public void log()
        {
            Console.WriteLine("Dosya loglandı");
        }
    }
}
