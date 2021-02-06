using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //burada instance oluşturmak yerine örneğin 19.satırda parantez içine new FileLoggerService() yazabilirdik

            ICreditManager craftLoanManager = new CraftLoanManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(craftLoanManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() }) ; 
            //parantez içinde öncelikle kredi türleri için hangi metottan istem yaptıysak onu yazdırdı 
            //burada birden fazla logger çalıştırdığımız için, aynı kredilerde olduğu gibi foreach kullanıp logger listesinde döndük.

            List<ICreditManager> credits = new List<ICreditManager>() { consumerLoanManager, vehicleLoanManager };

            //applicationManager.DoCreditPreinformation(credits);
        }
    }
}
