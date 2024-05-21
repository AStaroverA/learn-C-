//Добавьте к уже созданному классу "Дебетовая карточка" информацию о сумме денег на карте.
//Выполните перегрузку +(для увеличения суммы денег на указанную величину)
// - для уменьшкния суммы денег на указанную величину
// == проверка на равенство CVC кода 
// < и > проверка меньтше или больше суммы денег
// != и Equals.
//Используйте механизм свойств для полей класса
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace GitHub1
{
    internal class Program
    {

        class DebitCard(int c, int n, double a)
        {
            private int cvv = c;
            private int number = n;
            private double amount = a;
            public int Number()
            {
               return number;
            }
            public int Cvv()
            {
                return cvv;
            }
            public double Amount()
            {
                return amount;
            }



            public static double operator +(DebitCard CC, double number)
            {
                return CC.Amount() + number;
            }
            public static double operator -(DebitCard CC, double number)
            {
                return CC.Amount() - number;
            }
            public static bool operator ==(DebitCard c1, DebitCard c2)
            {
                return c1.Cvv() == c2.Cvv();
            }
            public static bool operator !=(DebitCard c1, DebitCard c2)
            {
                return c1.Cvv() != c2.Cvv();
            }
            public static bool operator <(DebitCard c1, DebitCard c2)
            {
                return c1.Amount() < c2.Amount();
            }
            public static bool operator >(DebitCard c1, DebitCard c2)
            {
                return c1.Amount() < c2.Amount();
            }
        }
        
        static void Main(string[] args)
        {
            DebitCard D1 = new DebitCard(137, 5553535, 1337.322);
            DebitCard D2 = new DebitCard(148, 19391945, 1488);
            DebitCard D3 = new DebitCard(148, 19391945, 1488);
            

        }

    }
}