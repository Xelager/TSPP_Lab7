using System;
using System.Collections.Generic;
using System.Text;

namespace TSPPWorkInBank
{
    class BankClient : User
    {
        //Служит для создания новой операции со счётом
        Operation operation;

        //Проверить текущий баланс счёта с возможностью печати
        public void CheckStatusBalance()
        {
            
            Console.WriteLine($" Текущий баланс = {card.balance}");
            Console.WriteLine($" Печать баланса");
            Console.WriteLine($" Выйти в меню");
        }

        public void ChooseSevice()
        {
            operation = new Services(card.ID, card.balance);
            Console.WriteLine($" Меню");
            Console.WriteLine($" Коммунальные услуги");
            Console.WriteLine($" Мобильная связь");
            Console.WriteLine($" Электронный кошелёк");
            Console.WriteLine($" Выйти в меню");

        }

        public void ActionWithBalance()
        {
            operation = new CashAction(card.ID, card.balance);
            Console.WriteLine($" Меню");
            Console.WriteLine($" Снять наличные");
            Console.WriteLine($" Пополнить карту");
            Console.WriteLine($" Перевести деньги на другой счёт");
            Console.WriteLine($" Выйти в меню");    
        }

    }
}
