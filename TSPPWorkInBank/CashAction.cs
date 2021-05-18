using System;
using System.Collections.Generic;
using System.Text;

namespace TSPPWorkInBank
{
    class CashAction : Operation
    {
        public CashAction(string currentCardID, decimal cardBalance) 
            : base(cardBalance, currentCardID)
        {

        }

        public void WithdrawCash()
        {
            Console.WriteLine(" Укажите сумму, которую желаете снять?");
            countMoney = Convert.ToInt32(Console.ReadLine());
            if (CheckPossibilityOperation())
            {
                currentBalance -= countMoney;
                Console.WriteLine(" Операция успешно завершена");
                FileSystem.UpdateCurrentBalance(currentCardID, currentBalance);
            }
            else Console.WriteLine(" Средств на балансе недостаточно");
        }

        public void DepositCash()
        {
            Console.WriteLine(" Укажите сумму, которую требуется пополнить?");
            countMoney = Convert.ToInt32(Console.ReadLine());
            currentBalance += countMoney;
            Console.WriteLine(" Операция успешно завершена");
            FileSystem.UpdateCurrentBalance(currentCardID, currentBalance);
        }

        public void TransferMoney()
        {
            Card transferCard;
            string tranferCardID;
            Console.Write(" Укажите номер карты, на которую требуется перевести средства: ");
            tranferCardID = Console.ReadLine();
            if ((transferCard = FileSystem.TryGetExistCard(tranferCardID)) == null)
                Console.WriteLine(" Указанная карта не найдена");
            else
            {
                Console.WriteLine(" Укажите сумму, которую требуется перевести на другую карту?");
                countMoney = Convert.ToInt32(Console.ReadLine());
                if (CheckPossibilityOperation())
                {
                    currentBalance -= countMoney;
                    transferCard.balance += countMoney;
                    FileSystem.UpdateCurrentBalance(currentCardID, currentBalance);
                    FileSystem.UpdateCurrentBalance(transferCard.ID, transferCard.balance);
                    Console.WriteLine(" Операция успешно завершена");
                }
                else Console.WriteLine(" Средств на балансе недостаточно");
            }
        }
    }
}
