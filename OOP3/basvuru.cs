using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var item in loggerServices)
            {
                item.Log();
            }
        }
        public void CreditPreInform(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
            
        }
    }
}
