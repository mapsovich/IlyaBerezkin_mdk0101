using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3_2
{
    public class Персона
    {
        string фамилия = "", статус = "", здоровье = "";
        int возраст = 0, зарплата = 0;
        //Методы-свойства
        //Чтение, запись при первом обращении (Read, Write-once)
        public string Фамилия
        {
            set { if (фамилия == "") фамилия = value; }
            get { return (фамилия); }
        }
        public string Статус
        { get { return (статус); } }
        public int Возраст
        {
            set
            {
                возраст = value;
                if (возраст < 7) статус = "ребенок";
                else if (возраст < 17) статус = "школьник";
                else if (возраст < 22) статус = "студент";
                else статус = "служащий";
            }
            get { return (возраст); }
        }
        public int Зарплата
        { set { зарплата = value; } }
    }
    class Program
    {
        static void Main()
        {
            Персона персона_1 = new Персона();
            персона_1.Фамилия = "Петров";
            персона_1.Возраст = 21;
            персона_1.Зарплата = 1000;
            Console.WriteLine("Фамилия = {0}, возраст = {1} лет, статус = {2}", персона_1.Фамилия, персона_1.Возраст, персона_1.Статус);
            персона_1.Фамилия = "Иванов";
            персона_1.Возраст += 1;
            Console.WriteLine("Фамилия = {0}, возраст = {1} лет, статус = {2}", персона_1.Фамилия, персона_1.Возраст, персона_1.Статус);
            Console.ReadKey();
        }
    }
}
