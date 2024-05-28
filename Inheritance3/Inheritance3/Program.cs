using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{

    public abstract class Animal
    {
        public bool CanFly;
        public bool CanSwim;

        public Animal(bool CF, bool CS) {CanFly = CF; CanSwim = CS; }

        public abstract void FlyInfo();
        public abstract void SwimInfo();
    }

    public class Tiger : Animal {
        string name;
        public Tiger(string n, bool CF, bool CS) : base(CF, CS) { name = n;}

        public override void FlyInfo() { 
            if (CanFly)
            {
                Console.WriteLine($"Tiger {name} can Fly");
            } else
            {
                Console.WriteLine($"Tiger {name} can't Fly");
            }
        }
        public override void SwimInfo()
        {
            if (CanSwim)
            {
                Console.WriteLine($"Tiger {name} can Swim");
            }
            else
            {
                Console.WriteLine($"Tiger {name} can't Swim");
            }
        }

    }
    public class Crocolide : Animal
    {
        string name;
        public Crocolide(string n, bool CF, bool CS) : base(CF, CS) { name = n; }

        public override void FlyInfo()
        {
            if (CanFly)
            {
                Console.WriteLine($"Crocolide {name} can Fly");
            }
            else
            {
                Console.WriteLine($"Crocolide {name} can't Fly");
            }
        }
        public override void SwimInfo()
        {
            if (CanSwim)
            {
                Console.WriteLine($"Crocolide {name} can Swim");
            }
            else
            {
                Console.WriteLine($"Crocolide {name} can't Swim");
            }
        }

    }
    public class Kangaroo : Animal
    {
        string name;
        public Kangaroo(string n, bool CF, bool CS) : base(CF, CS) { name = n; }

        public override void FlyInfo()
        {
            if (CanFly)
            {
                Console.WriteLine($"Kangaroo {name} can Fly");
            }
            else
            {
                Console.WriteLine($"Kangaroo {name} can't Fly");
            }
        }
        public override void SwimInfo()
        {
            if (CanSwim)
            {
                Console.WriteLine($"Kangaroo {name} can Swim");
            }
            else
            {
                Console.WriteLine($"Kangaroo {name} can't Swim");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Tigran", false, true);
            Crocolide crocolide = new Crocolide("Crocant", false, true);
            Kangaroo kangaroo = new Kangaroo("Kaneki KenGuru", false, true);

            tiger.FlyInfo();
            crocolide.FlyInfo();
            kangaroo.FlyInfo();
            Console.WriteLine("\n");
            tiger.SwimInfo();
            crocolide.SwimInfo();
            kangaroo.SwimInfo();

        }
    }
}
