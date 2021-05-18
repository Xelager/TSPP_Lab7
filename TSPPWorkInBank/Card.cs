using System;
using System.Collections.Generic;
using System.Text;

namespace TSPPWorkInBank
{
    public class Card
    {
        public decimal balance { get; set; }
        public string fio { get; private set; }
        public string ID { get; set; }
        public int pin { get; private set; }
        public string rights { get; private set; }
        public bool access 
        {
            get 
            { return access; }
            private set
            {
                access = value;
                if (access == false)
                {
                    Console.WriteLine(" Ваша карта была заблокирована при возможной попытке взлома!");
                    Console.WriteLine(" Для получения более подробной информации");
                    Console.WriteLine(" и возможных способах восстановления обратитесь в банк");
                }
            }
        }

        public int countAttempts
        {
            get { return countAttempts; }
            set
            {
                if (countAttempts > 3)
                {
                    access = false;
                }
                else countAttempts = value;
            }
        }

        public Card()
        {
            CardInitialize();
        }

        public Card(string ID, int pin, string fio, decimal balance, string rights, bool access, int countAttempts)
        {
            this.ID = ID;
            this.pin = pin;
            this.fio = fio;
            this.balance = balance;
            this.rights = rights;
            this.access = access;
            this.countAttempts = countAttempts;
        }

        public Card CardInitialize()
        {
            Console.Write(" Номер карты = ");
            ID = Console.ReadLine();
            Card currentCard = FileSystem.TryGetExistCard(ID);
            if (currentCard == null)
            {
                Console.WriteLine(" Карты не существует в базе данных");
                return null;
            }
            Console.Write(" ПИН к карте = ");
            pin = Convert.ToInt32(Console.ReadLine());
            if (pin == currentCard.pin)
                return currentCard;
            else
            {
                Console.WriteLine(" Не верный пин-код");
                return null;
            } 
        }

    }
}
