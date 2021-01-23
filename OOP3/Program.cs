using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager thingsCreditManager = new ThingsCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageManager = new MortgageManager();
            ICreditManager esnafKredisiManager = new EsnafKredisiManager();
            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //basvuruManager.BasvuruYap(thingsCreditManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(vehicleCreditManager, fileLoggerService);
            //basvuruManager.BasvuruYap(esnafKredisiManager, smsLoggerService);


            List<ICreditManager> credits = new List<ICreditManager> {thingsCreditManager,mortgageManager };
            List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, fileLoggerService };
            basvuruManager.BasvuruYap(thingsCreditManager,loggers);

        }
    }
}
