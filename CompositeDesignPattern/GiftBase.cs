/******************************************************************************
 * Filename    = GiftBase.cs
 *
 * Author      = Sunil Varma Tenali
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = CompositeDesignPattern
 *
 * Description = Defines an abstract base class for gifts, providing a structure for storing a gift's name, price, and calculating its total price.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public abstract class GiftBase
    {
        protected string name;
        protected decimal price;

        public GiftBase( string name , decimal price )
        {
            this.name = name;
            this.price = price;
        }

        // Abstract method to calculate the total price (to be implemented by derived classes)
        public abstract decimal CalculateTotalPrice();
    }
}
