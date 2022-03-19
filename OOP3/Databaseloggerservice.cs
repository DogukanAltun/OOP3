using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class Databaseloggerservice : Iloggerservice
    {
        public void log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
