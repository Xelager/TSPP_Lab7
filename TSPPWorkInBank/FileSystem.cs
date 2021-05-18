using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TSPPWorkInBank
{
    class FileSystem
    {
        static Dictionary<string, Card> listOfCards = new Dictionary<string, Card>();
        static string path = @"C:\Users\User\source\repos\TSPPWorkInBank\TSPPWorkInBank\ListOfCards.dat";
        public static int indexCurrentCard
        {
            get { return indexCurrentCard; }
            private set { indexCurrentCard = value; }
        }

        static FileSystem()
        {
            UploadFromFile();
        }

        public void AddToFile(Card card)
        {
            try
            {

                // создаем объект BinaryWriter
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    // записываем в файл значение каждого поля структуры
                    writer.Write(card.ID);
                    writer.Write(card.pin);
                    writer.Write(card.fio);
                    writer.Write(card.balance);
                    writer.Write(card.rights);
                    writer.Write(card.access);
                    writer.Write(card.countAttempts);
                }
                listOfCards.Add(card.ID, card);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void UploadFromFile()
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                        string ID = reader.ReadString();
                        int pin = reader.ReadInt32();
                        string fio = reader.ReadString();
                        decimal balance = reader.ReadDecimal();
                        string rights = reader.ReadString();
                        bool access = reader.ReadBoolean();
                        int countAttempts = reader.ReadInt32();

                        listOfCards.Add(ID, new Card(ID, pin, fio, balance, rights, access, countAttempts));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public Card TryGetExistCard(string ID)
        {
                if (listOfCards[ID] != null)
                {
                    return listOfCards[ID];
                }
            return null;
        }

        static public void IncAttempts(string ID)
        {
            listOfCards[ID].countAttempts += 1;
        }

        static public void UpdateCurrentBalance(string ID, decimal balance)
        {
            listOfCards[ID].balance = balance;
        }
    }
}
