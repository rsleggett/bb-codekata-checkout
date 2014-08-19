using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Checkout
{
    public class Basket
    {
        private double price = 0;
    
        private List<char> products = new List<char>(); 

        public double Checkout(string productList)
        {
            if (!string.IsNullOrEmpty(productList))
            {
                products = productList.ToList();
                foreach (var product in products)
                {
                    Scan(product);
                }
                ApplyDiscounts();
            }
            return price;
        }

        private void ApplyDiscounts()
        {           
            //A's discount
            int numberOfA = products.Count( x => x=='A');
            price = price - (20*((numberOfA - (numberOfA%3))/3));

            //B's discount
            int numberOfB = products.Count(x => x == 'B');
            price = price - (15*((numberOfB - (numberOfB%2))/2));
        }

        public void Scan(char product)
        {
            if (product == 'A')
            {
                price = price + 50;
            }
            else if (product == 'B')
            {
                price = price + 30;
            }
            else if (product == 'C')
            {
                price = price + 20;
            }
            else if (product == 'D')
            {
                price = price + 15;
            }
        }
    }
}
