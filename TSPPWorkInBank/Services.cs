using System;
using System.Collections.Generic;
using System.Text;

namespace TSPPWorkInBank
{
    class Services : Operation
    {
        private string paymentID;

        public Services(string currentCardID, decimal cardBalance) 
            : base(cardBalance, currentCardID)
        {

        }

        void PayUtilityBill()
        {
            Console.WriteLine(" Укажите идентификатор коммунального платежа:");
            paymentID = Console.ReadLine();
            Console.WriteLine(" Укажите сумму, которую требуется перевести?");
            countMoney = Convert.ToInt32(Console.ReadLine());
            if (CheckPossibilityOperation())
            {
                currentBalance -= countMoney;
                FileSystem.UpdateCurrentBalance(currentCardID, currentBalance);
                Console.WriteLine(" Операция успешно завершена");
            }
            else Console.WriteLine(" Средств на балансе недостаточно");
        }

        void PayMobileCommunication()
        {
            Console.WriteLine(" Укажите номер телефона:");
            paymentID = Console.ReadLine();
            Console.WriteLine(" Укажите сумму, которую требуется перевести?");
            countMoney = Convert.ToInt32(Console.ReadLine());
            if (CheckPossibilityOperation())
            {
                currentBalance -= countMoney;
                FileSystem.UpdateCurrentBalance(currentCardID, currentBalance);
                Console.WriteLine(" Операция успешно завершена");
            }
            else Console.WriteLine(" Средств на балансе недостаточно");
        }

        void PayEWallet()
        {
            Console.WriteLine(" Укажите идентификатор электронного кошелька:");
            paymentID = Console.ReadLine();
            Console.WriteLine(" Укажите сумму, которую требуется перевести?");
            countMoney = Convert.ToInt32(Console.ReadLine());
            if (CheckPossibilityOperation())
            {
                currentBalance -= countMoney;
                FileSystem.UpdateCurrentBalance(currentCardID, currentBalance);
                Console.WriteLine(" Операция успешно завершена");
            }
            else Console.WriteLine(" Средств на балансе недостаточно");
        }
    }
}
