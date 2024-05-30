using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_3
{
    interface IWorker
    {
        void Work(IPart part);
    }
    interface IPart
    {
        double HumanHour { get; }
        double Progress { get; }

        void WorkWith();
    }

    class Basement : IPart
    {
        public double HumanHour { get; set; }
        public double Progress { get; set; }
        public void WorkWith()
        {
            Progress += 1 / HumanHour;
        }
    }

    class Wall : IPart
    {
        public double HumanHour { get; set; }
        public double Progress { get; set; }
        public void WorkWith()
        {
            Progress += 1 / HumanHour;
        }
    }

    class Door : IPart
    {
        public double HumanHour { get; set; }
        public double Progress { get; set; }
        public void WorkWith()
        {
            Progress += 1 / HumanHour;
        }
    }

    class Window : IPart
    {
        public double HumanHour { get; set; }
        public double Progress { get; set; }
        public void WorkWith()
        {
            Progress += 1 / HumanHour;
        }
    }

    class Roof : IPart
    {
        public double HumanHour { get; set; }
        public double Progress { get; set; }
        public void WorkWith()
        {
            Progress += 1 / HumanHour;
        }
    }
    class House 
    {
        List<IPart> parts = new List<IPart> { 
            new Basement { HumanHour = 10, Progress =  0 }, 
            new Wall { HumanHour = 4, Progress = 0 }, new Wall { HumanHour = 4, Progress = 0 }, new Wall { HumanHour = 4, Progress = 0 }, new Wall { HumanHour = 4, Progress = 0 },
            new Door { HumanHour = 1, Progress = 0 }, 
            new Window { HumanHour = 2, Progress = 0 },new Window { HumanHour = 2, Progress = 0 },new Window { HumanHour = 2, Progress = 0 },new Window { HumanHour = 2, Progress = 0 },
            new Roof { HumanHour = 10, Progress =  0 }
        };
    }




    class Worker
    {
        void Work(IPart part) {
            part.WorkWith();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double y = 3;
            Console.WriteLine(x/y);
            Console.WriteLine(x/y+ x / y);
            Console.WriteLine(x / y + x / y + x / y);
        }
    }
}
