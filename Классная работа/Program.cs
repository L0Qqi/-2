using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классная_работа
{
    enum Schet
    {
        Текущий, Сберегательный
    }
    struct Bank
    {
        public int number;
        public string type;
        public int balance;
        public void Print()
        {
            Console.WriteLine($"Номер: {number} | Тип: {type} | Баланс: {balance} рублей");
        }
    }
    enum Univer
    {
        КГУ = 0, КАИ = 1, КХТИ = 2
    }

    struct Worker
    {
        public string name;
        public int vuz;

        public Worker(string Name, int Vuz)
        {
            this.name = Name;
            this.vuz = Vuz;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}, Вуз: {vuz}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Задание 3.1. Виды банковского счёта");
            foreach (Schet credit in Enum.GetValues(typeof(Schet)))
            {
                Console.WriteLine("Кредит - {0}, Номер - {1}", credit, (int)credit);
            }
            
            Console.WriteLine("Задание 3.2. Банк");
            Bank bank_data = new Bank();
            Console.WriteLine("Введите номер: ");
            bank_data.number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип: ");
            bank_data.type = Console.ReadLine();
            Console.WriteLine("Введите баланс: ");
            bank_data.balance = int.Parse(Console.ReadLine());
            bank_data.Print();
            */
            Console.WriteLine("Задание 3.1. Университеты");
            Worker worker1 = new Worker("Леонардо Зайниев", (int)Univer.КГУ);
            worker1.Print();
            Worker worker2 = new Worker("Азат Галиев", (int)Univer.КАИ);
            worker2.Print();
            Worker worker3 = new Worker("Камиль Набиев", (int)Univer.КХТИ);
            worker3.Print();
            Console.WriteLine("0 - КАИ / 1 - КХТИ / 2 - КГУ");

        }
    }
}
