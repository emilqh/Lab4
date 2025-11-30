using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        //Tapsiriq 7
        static void Increase(ref int number)

        {
            number++;
        }
        //Tapsiriq 8
        static bool TryDivide(int a, int b, out int result)
        {
            if (b == 0)
            {
                result = 0;
                return false;
            }

            result = a / b;
            return true;
        }

        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Tapsiriq 1:");
            Student s = new Student("Adil", 30);

            Console.WriteLine(s.Name + " " + s.Age);
            #endregion

            #region 2
            Console.WriteLine("\nTapsiriq 2:");
            BankAccount account = new BankAccount();

            account.Deposit(100);
            account.Deposit(-50);

            Console.WriteLine("Balance: " + account.GetBalance());
            #endregion

            #region 3
            Console.WriteLine("\nTapsiriq 3:");
            MathTools mt = new MathTools();

            Console.WriteLine(mt.Add(5, 3));
            Console.WriteLine(mt.Subtract(10, 4));
            Console.WriteLine(mt.Multiply(6, 7));
            #endregion

            #region 4
            Console.WriteLine("\nTapsiriq 4:");
            Book b = new Book();

            b.Title = "Peygamberligin Isbati - Haber Delili";
            b.Author = "Altay Cem Meric";
            b.Pages = 519;

            Console.WriteLine($"{b.Title}, {b.Author}, {b.Pages}.");
            #endregion

            #region 5
            Console.WriteLine("\nTapsiriq 5:");
            User user = new User();

            user.Password = "123";
            user.Password = "abcdef";

            Console.WriteLine("Password: " + user.Password);
            #endregion

            #region 6
            Console.WriteLine("\nTapsiriq 6:");
            Product p = new Product();
            p.AddStock(50);
            p.Sell(20);
            Console.WriteLine(p.Stock);

            #endregion

            #region 7
            Console.WriteLine("\nTapsiriq 7:");
                int myNumber = 5;
                Console.WriteLine($"My number: {myNumber}");

                Increase(ref myNumber);
                Console.WriteLine($"My number with reference: {myNumber}");

            #endregion

            #region 8
            Console.WriteLine("\nTapsiriq 8:");
            int x = 10;
            int y = 2;
            int divisionResult;

            if (TryDivide(x, y, out divisionResult))
            {
                Console.WriteLine($"{x} / {y} = {divisionResult}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }

            y = 0;
            if (TryDivide(x, y, out divisionResult))
            {
                Console.WriteLine($"{x} / {y} = {divisionResult}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }

            #endregion
                       
        }
    }
}
