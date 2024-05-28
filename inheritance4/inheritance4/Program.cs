using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance4
{
    public abstract class Figure{
        public abstract double S();
        public abstract string Show();
    }

    class OtherFigure //не является наследником Figure и не имеет функции S()
    {
        public float otherX;
        public float otherY;
        public OtherFigure(float otherX, float otherY)
        {
            this.otherX = otherX;
            this.otherY = otherY;
        }
        public float OtherSfunc() { return otherX * otherY; }
        public string OtherShowfunc() { return $"x: {otherX} | y: {otherY}"; }
    }

    class OtherFigureAdapter : Figure // Является "переходником" для классов не наследующихся от Figure
    {
        OtherFigure other;
        public OtherFigureAdapter(OtherFigure ot) { other = ot; }

        public override double S() { return other.OtherSfunc(); }
        public override string Show() {return other.OtherShowfunc(); }
    }

    public class Rectangle : Figure
    {
        double x;
        double y;

        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override double S()
        {
            return x * y;
        }
        public override string Show()
        {
            return $"Rectangle ------- x: {x} | y: {y} -------";
        }
    }
    public class Triangle : Figure
    {
        double s1;
        double s2;
        double s3;

        public Triangle(double ss1, double ss2, double ss3)
        {
            s1 = ss1;
            s2 = ss2;
            s3 = ss3;
        }

        public override double S()
        {
            double p = (s1 + s2 + s3) / 2;
            return Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
        }
        public override string Show()
        {
            return $"Triangle ------- s1: {s1} | s2: {s2} | s3: {s3} -------";
        }
    }

    public class Circle : Figure
    {
        double radius;
        public Circle(double r) { radius = r; }
        public override double S()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string Show()
        {
            return $"Circle ------- Radius: {radius} -------";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure[] figure = new Figure[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int Key = random.Next(1,4);
                switch (Key)
                {
                    case 1:
                        double x = Math.Round(random.Next(1, 10) + random.NextDouble(),2);
                        double y = Math.Round(random.Next(1, 10) + random.NextDouble(), 2);
                        figure[i] = new Rectangle(x,y);
                        break;
                    case 2:
                        double s1 = Math.Round(random.Next(1, 10) + random.NextDouble(), 2);
                        double s2 = Math.Round(random.Next(1, 10) + random.NextDouble(), 2);
                        double s3 = Math.Round(random.Next(1, 10) + random.NextDouble(), 2);
                        figure[i] = new Triangle(s1,s2,s3);
                        break;
                    case 3:
                        double radius = Math.Round(random.Next(1, 10) + random.NextDouble(), 2);
                        figure[i] = new Circle(radius);
                        break ;
                }
            }


            for (int i = 0; i < figure.Length; i++)
            {
                Console.WriteLine(figure[i].Show() + " S: " + figure[i].S());
            }
        }
    }
}
