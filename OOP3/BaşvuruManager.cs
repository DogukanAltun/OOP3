using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BaşvuruManager
    {
        public void BaşvuruYap(IKrediManager kredi,Iloggerservice ıloggerService )
        { 
            kredi.Hesapla();
            ıloggerService.log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
