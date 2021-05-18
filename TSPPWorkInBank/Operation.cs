using System;
using System.Collections.Generic;
using System.Text;

namespace TSPPWorkInBank
{
    class Operation
    {
        protected int countMoney { get; set; }
        protected decimal currentBalance { get; set; }
        protected string currentCardID { get; set; }

        public Operation(decimal cardBalance, string ID)
        {
            currentBalance = cardBalance;
            currentCardID = ID;
        }

        //Проверка возможности проводимой операции
        protected bool CheckPossibilityOperation()
        {
            if (countMoney > currentBalance) return false;
            else return true;
        }

        //Заявка работнику банка
        void CreateRequest()
        {

        }

        protected virtual void CreateSignalEvent()
        { 
        
        }
    }
}
