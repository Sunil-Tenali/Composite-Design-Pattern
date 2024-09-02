/******************************************************************************
 * Filename    = SingleGift.cs
 *
 * Author      = Sunil Varma Tenali
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = CompositeDesignPattern
 *
 * Description = Represents a single gift item by extending the base gift class and providing a method to calculate and display its price.
 *****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class SingleGift : GiftBase
    {
        public SingleGift( string name , decimal price ) : base( name , price ) { }

        // Overrides method to display the gift's name and price, and return the price
        public override decimal CalculateTotalPrice()
        {
            Console.WriteLine( $"{name} with the price {price}" );

            return price;
        }
    }
}
