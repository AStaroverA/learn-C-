using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        public class Human
        {
            string _firstName;
            string _lastName;
            DateTime _birthDate;

            public Human() { }
            //public Human(string firstName, string lastName)
            //{
            //    _firstName = firstName;
            //    _lastName = lastName;
            //}
            //public Human(string firstName, string lastName, DateTime birthDate)
            //{
            //    _firstName = firstName;
            //    _lastName = lastName;
            //    _birthDate = birthDate;
            //}
            public virtual void Show()
            {
                Console.WriteLine($"\n\nLastName: {_lastName}\nName: {_firstName}\nBirthDate: {_birthDate}");
            }

            public void SetFirstName(string firstName) { _firstName = firstName; }
            public void SetLastName(string lastName) { _lastName = lastName; }
            public void SetBirthDate(DateTime dateTime) { _birthDate = dateTime; }
        }

        public class Employee : Human
        {
            
            double _salary;
            string _citizenship;
            public Employee(){ }
            //public Employee(string fName, string lName) : base(fName, lName) { }
            //public Employee(string fName, string lName, double salary) : base(fName, lName) { _salary = salary; }
            //public Employee(string fName, string lName, DateTime date, double salary) : base(fName, lName, date) { _salary = salary; }
            public override void Show()
            {
                base.Show();
                Console.WriteLine($"Salary: {_salary}");
                Console.WriteLine($"Citizenship: {_citizenship}");
            }
            public void SetSalary(double salary) { _salary = salary; }
            public void SetCitizenship(string citizenship) { _citizenship = citizenship; }
            public class EmployeeBuilder
            {
                Employee employes = new Employee();
                public EmployeeBuilder SetFirstName(string firstName) { employes.SetFirstName(firstName); return this; }
                public EmployeeBuilder SetLastName(string lastName) { employes.SetLastName(lastName); return this; }
                public EmployeeBuilder SetBirthDate(DateTime dateTime) { employes.SetBirthDate(dateTime); return this; }
                public EmployeeBuilder SetSalary(double salary) { employes.SetSalary(salary); return this; }
                public EmployeeBuilder SetCitizenship(string citizenship) { employes.SetCitizenship(citizenship); return this; }

                public Employee build() {
                    return employes;
                }
            }



            public class Scientist : Employee {
                public void ShowScientist()
                {
                    Console.WriteLine("-------I am Scientist-------");
                }
            }
            public class Manager : Employee {
                public void ShowManager()
                {
                    Console.WriteLine("-------I am Manager-------");
                }
            }
            public class Specialist : Employee {
                public void ShowSpecialist()
                {
                    Console.WriteLine("-------I am Specialist-------");
                }
            }

            static void Main(string[] args)
            {
                //Employee p1 = new Employee("Steve", "Gray");
                //Employee p2 = new Employee("Bob", "Builder", 45000.54);
                //Employee p3 = new Employee("Alex", "White", new DateTime(2002, 7, 20), 24000.65);
                //p1.Show();
                //p2.Show();
                //p3.Show();
                EmployeeBuilder builder = new EmployeeBuilder();

                //builder.SetFirstName("Bob");
                //builder.SetLastName("Builder");
                //builder.SetBirthDate(DateTime.Now);
                //builder.SetSalary(3436.09);

                Employee p4 = new EmployeeBuilder().SetFirstName("Bob").SetLastName("Builder").SetBirthDate(DateTime.Now).SetSalary(45000.54).build();

                p4.Show();

                Employee OnlyName = new EmployeeBuilder().SetFirstName("Janny").build();
                OnlyName.Show();

                Employee OnlyLastName = new EmployeeBuilder().SetLastName("Brown").build();
                OnlyLastName.Show();

                Employee CitizenShip = new EmployeeBuilder().SetCitizenship("Russia").build();
                CitizenShip.Show();


                Employee[] employes = { new Scientist(), new Specialist(), new Manager() };

                foreach (Employee e in employes)
                {
                    e.Show();
                    /////1
                    try
                    {
                        ((Specialist)e).ShowSpecialist();
                    }
                    catch { }
                    /////2
                    Scientist scientist = e as Scientist;

                    if(scientist != null)
                    {
                        scientist.ShowScientist();
                    }
                    //////3
                    if(e is Manager)
                    {
                        (e as Manager).ShowManager();
                    }
                }
            }
        }
    }
}
