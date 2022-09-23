using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба__2
{
    class Program
    {
        struct Student
        {
            public string name;
            public string surname;
            public int id;
            public char category;
            public int vipil;
        }
        struct types
        {
            public string name;
            public string start;
            public string end;
            public string Print()
            {
                return $"Тип данных: {name} | Минимальное значение: {start} | Максимальное значение: {end}";
            }
        }
        struct data
        {
            public string name;
            public string town;
            public int age;
            public int pin;

            public string printdata()
            {
                return $"Имя: {name} | Город: {town} | Возраст: {age} | PIN: {pin}";
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Сколько выпили студенты");
            Student Radmir = new Student();
            Radmir.name = "Radmir";
            Radmir.surname = "Salimov";
            Radmir.id = 1;
            Radmir.category = 'b';
            Radmir.vipil = 800;
            Student Vadim = new Student();
            Vadim.name = "Vadim";
            Vadim.surname = "Gareev";
            Vadim.id = 2;
            Vadim.category = 'a';
            Vadim.vipil = 1200;
            Student Ruslan = new Student();
            Ruslan.name = "Ruslan";
            Ruslan.surname = "Sabitov";
            Ruslan.id = 3;
            Ruslan.category = 'c';
            Ruslan.vipil = 600;
            Student Anton = new Student();
            Anton.name = "Anton";
            Anton.surname = "Vasenkov";
            Anton.id = 4;
            Anton.category = 'b';
            Anton.vipil = 1000;
            Student Ekaerina = new Student();
            Ekaerina.name = "Ekaerina";
            Ekaerina.surname = "Krasnova";
            Ekaerina.id = 5;
            Ekaerina.category = 'c';
            Ekaerina.vipil = 500;
            double vesvipil = Radmir.vipil + Vadim.vipil + Ruslan.vipil + Anton.vipil + Ekaerina.vipil;
            Console.WriteLine($"Всего выпили: {vesvipil}");
            Console.WriteLine($"Radmir выпил: {Radmir.vipil/vesvipil}");
            Console.WriteLine($"Vadim выпил: {Vadim.vipil / vesvipil}");
            Console.WriteLine($"Ruslan выпил: {Ruslan.vipil / vesvipil}");
            Console.WriteLine($"Anton выпил: {Anton.vipil / vesvipil}");
            Console.WriteLine($"Ekaerina выпила: {Ekaerina.vipil / vesvipil}");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Задание 2. Типы данных");
            types booll = new types();
            booll.name = "bool";
            booll.start = "False";
            booll.end = "True";
            types bytee = new types();
            bytee.name = "byte";
            bytee.start = "0";
            bytee.end = "255";
            types sbytee = new types();
            sbytee.name = "sbyte";
            sbytee.start = "-128";
            sbytee.end = "127";
            types shortt = new types();
            shortt.name = "short";
            shortt.start = "-32768";
            shortt.end = "32767";
            types ushortt = new types();
            ushortt.name = "ushort";
            ushortt.start = "0";
            ushortt.end = "65535";
            types intt = new types();
            intt.name = "int";
            intt.start = "-2147483648";
            intt.end = "2147483647";
            types uintt = new types();
            uintt.name = "uint";
            uintt.start = "0";
            uintt.end = "4294967295";
            types longg = new types();
            longg.name = "long";
            longg.start = "-9223372036854775808";
            longg.end = "9223372036854775807";
            types ulongg = new types();
            ulongg.name = "ulong";
            ulongg.start = "0";
            ulongg.end = "18446744073709551615";
            types floatt = new types();
            floatt.name = "float";  
            floatt.start = "-3.4*10^38";
            floatt.end = "3.4*10^38";
            types doublee = new types();
            doublee.name = "double";
            doublee.start = "±5.0*10-324";
            doublee.end = "±1.7 * 10^308";
            types decimall = new types();
            decimall.name = "decimal";
            decimall.start = "±1.0*10^-28";
            decimall.end = "±7.9228*10^28";
            Console.WriteLine(booll.Print());
            Console.WriteLine(bytee.Print());
            Console.WriteLine(sbytee.Print());
            Console.WriteLine(shortt.Print());
            Console.WriteLine(ushortt.Print());
            Console.WriteLine(intt.Print());
            Console.WriteLine(uintt.Print());
            Console.WriteLine(longg.Print());
            Console.WriteLine(ulongg.Print());
            Console.WriteLine(floatt.Print());
            Console.WriteLine(doublee.Print());
            Console.WriteLine(decimall.Print());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 3. Вывод данных");
            data pers_data = new data();
            Console.WriteLine("Как вас зовут?");
            pers_data.name = Console.ReadLine();
            Console.WriteLine("Укажите город: ");
            pers_data.town = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            pers_data.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите PIN: ");
            pers_data.pin = int.Parse(Console.ReadLine());
            Console.WriteLine(pers_data.printdata());
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Задание 4. Инициалы");
            Console.WriteLine("Введите фамилию и имя через пробел");
            string[] fullname = Console.ReadLine().Split(' ');
            Console.WriteLine($"{fullname[0][0]}.{fullname[1][0]}");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Задание 5. Виски");
            Console.WriteLine("Введите обычную цену за бутылку: ");
            double normPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите скидку: ");
            double salePrice = (double.Parse(Console.ReadLine()))/100;
            Console.WriteLine("Введите стоимость отпуска");
            double holidayPrice = double.Parse(Console.ReadLine());
            double quantity = Math.Ceiling(holidayPrice / (normPrice * salePrice));
            Console.WriteLine("Бутылок необходимо купить: " + quantity);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 6. Скорость");
            Console.WriteLine("Введите скорость в км/ч");
            double speed = double.Parse(Console.ReadLine().Replace('.', ','));
            Console.WriteLine($"Скорость в см/c: {Math.Floor(speed*100000/3600)}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 7. Заглавные и строчные буквы");
            string stroka = Console.ReadLine();
            StringBuilder stroka_final = new StringBuilder();
            foreach (Char c in stroka.ToCharArray())
            {
                if (Char.IsLower(c))
                {
                    stroka_final.Append(Char.ToUpper(c));
                }
                else
                {
                    stroka_final.Append(Char.ToLower(c));
                }
            }
            Console.WriteLine(stroka_final);
        }   

    }
}
