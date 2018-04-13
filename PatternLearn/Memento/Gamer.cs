using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearn
{
    public class Gamer
    {
        private static string[] fruitsname = { "apple", "grape", "banana", "orange" };

        private int number;
        private int money;
        private List<string> fruits = new List<string>();
        private Random random = new Random();

        private Memento memento;

        public int Money { get { return money; } }

        public int PreviousMoney {
            get {
                if (memento == null)
                {
                    return 0;
                }
                return memento.Money;
            }
        }

        public Gamer(int money)
        {
            this.number = 1;
            this.money = money;
        }


        public void Bet()
        {
            int dice = random.Next(1, 7);

            switch (dice)
            {
                case 1:
                    money += 100;
                    Console.WriteLine("money add");
                    break;
                case 2:
                    money = money >> 1;
                    Console.WriteLine("money cut");
                    break;
                case 6:
                    string f = getFruit();
                    Console.WriteLine("add fruit (" + f + ")");
                    fruits.Add(f);
                    break;

                case 3:
                case 4:
                case 5:
                default:
                    Console.WriteLine("nothing");
                    break;
            }
        }

        public void CreatMemento(string path)
        {
            memento = new Memento(money, number++);

            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].StartsWith("nice"))
                {
                    memento.AddFruit(fruits[i]);
                }
            }

            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                BinaryFormatter format = new BinaryFormatter();
                format.Serialize(stream, memento);
            }
        }

        public void RestoreMemento(string path)
        {
            if (memento == null)
            {
                using (Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    BinaryFormatter format = new BinaryFormatter();
                    memento = (Memento)format.Deserialize(stream);
                }
            }  

            money = memento.Money;
            number = memento.Number;
            fruits = memento.GetFruits();
        }   

        public override string ToString()
        {
            return string.Format("[money = {0} , fruits = {1}]", money, getFruits()); 
        }

        string getFruit()
        {
            string perfix = "";

            if (random.Next(0, 2) == 0)
            {
                perfix = "nice ";
            }

            return perfix + fruitsname[random.Next(fruitsname.Length)];
        }
        
        string getFruits()
        {
            string str;

            if (fruits.Count > 0)
            {
                str = "[";

                for (int i = 0; i < fruits.Count - 1; i++)
                {
                    str += string.Format("{0}, ", fruits[i]);
                }
                str += fruits[fruits.Count - 1];

                str += "]";
            }
            else
            {
                str = "null";
            }     
            return str;
        }   
    }
}
