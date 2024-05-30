using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_01
{
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"\nФамилия: {LastName} Имя: {FirstName} Дата рождения: {BirthDate.ToLongDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Должность: {Position} Заработная плата: {Salary} $";
        }
    }
    public interface IWorker
    {
        //event EventHandler WorkEnded;
        bool IsWorking { get; }
        string Work();
    }
    interface IManager
    {
        List<IWorker> ListOfWorkers { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }

    class Director : Employee, IManager
    {
        public List<IWorker> ListOfWorkers { get; set; }
        public void Control()
        {
            Console.WriteLine("Контролирую работу");

        }

        public void MakeBudget()
        {
            Console.WriteLine("Формирую бюджет");
        }
        public void Organize()
        {
            Console.WriteLine("Организую работу");
        }
    }

    class Seller : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking { get { return isWorking; } }
        public string Work()
        {
            return "Продаю товар";
        }
    }
    class Casher : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking { get { return isWorking; } }
        public string Work()
        {
            return "Принимаю оплату за товар";
        }
    }
    class Stonekeeper : Employee, IWorker
    {
        bool isWorking = true;
        public bool IsWorking { get { return isWorking; } }
        public string Work()
        {
            return "Принимаю оплату за товар";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director { LastName = "Doe", FirstName = "John", BirthDate = new DateTime(1998, 10,12), Position = "Директор", Salary = 12000 };
            IWorker seller = new Seller { LastName = "Beam", FirstName = "Jim", BirthDate = new DateTime(1956,5,23), Position = "Продавец", Salary = 3780 };

            if (seller is Employee) {
                Console.WriteLine($"Заработная плата продавца: {(seller as Employee).Salary}");
            }
            
            director.ListOfWorkers = new List<IWorker> { 
            seller,
            new Casher{ LastName = "Smith", FirstName = "Nicole", BirthDate = new DateTime(1956,5,23), Position = "Кассир", Salary = 3780},
            new Stonekeeper{ LastName = "Ross", FirstName = "Bob", BirthDate = new DateTime(1956,5,23), Position = "Кладовщик", Salary = 4500 }
            };

            Console.WriteLine(director);

            if (director is IManager) { director.Control(); }
                        foreach (IWorker item in director.ListOfWorkers) { 
                Console.WriteLine(item);
                if (item.IsWorking) { Console.WriteLine(item.Work()); }
            }
        }
    }
}
