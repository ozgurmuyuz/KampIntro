using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //method injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices) //birden fazla logger kullanmak için logger service için list yazmak gerekir
        {
            //başvuran bilgilerini değerlendirme vb işler yaparız

            creditManager.Calculate();
            //loggerService.Log(); //logger service list'i yazdıktan sonra burada foreach kullanmalı ve liste döndürmeliyiz.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void DoCreditPreinformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
