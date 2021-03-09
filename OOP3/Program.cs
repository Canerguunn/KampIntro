using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKredisiManager = new IhtiyacKredisiManager();
            IKrediManager tasitKredisiManager = new TasitKredisiManager();
            IKrediManager konutKredisiManager = new KonutKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKredisiManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKredisiManager,konutKredisiManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
