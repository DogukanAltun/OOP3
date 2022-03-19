using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main()
        {
            IKrediManager TaşıtKredisi = new TaşıtKrediManager();
            IKrediManager KonutKredisi = new KonutKrediManager();
            IKrediManager İhtiyaçKredisi = new İhtiyaçKrediManager();
            BaşvuruManager başvuruManager = new BaşvuruManager();
            List<IKrediManager> Krediler = new List<IKrediManager>() { TaşıtKredisi, KonutKredisi, İhtiyaçKredisi };
            başvuruManager.KrediOnBilgilendirmesiYap(Krediler);
            Iloggerservice fileloggerservice = new FileLoggerService();
            başvuruManager.BaşvuruYap(İhtiyaçKredisi, fileloggerservice);
        }
    }
}
