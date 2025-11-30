using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Product
    {
        private int _stock;

        public int Stock => _stock;
                
        public void AddStock (int amount) 
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount must be positive!!");
                return;
            }

            _stock += amount;
        }
        public void Sell(int amount) 
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount must be positive!!");
                return;
            }

            if (amount > _stock)
            {
                Console.WriteLine("Not enough stock");
                return;
            }

           _stock -= amount;

           
        }
    }
}
