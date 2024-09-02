/******************************************************************************
 * Filename    = CompositeGift.cs
 *
 * Author      = Sunil Varma Tenali
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = CompositeDesignPattern
 *
 * Description = Implements a composite structure for managing a hierarchical collection of gifts with methods to add, remove, and calculate their total price.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly List<GiftBase> _gifts;

        public CompositeGift( string name , decimal price ) : base( name , price )
        {
            _gifts = new List<GiftBase>();
        }

        // Adds a gift to the composite gift
        public void Add( GiftBase gift )
        {
            _gifts.Add( gift );
        }

        // Removes a gift from the composite gift
        public void Remove( GiftBase gift )
        {
            _gifts.Remove( gift );
        }

        public override decimal CalculateTotalPrice()
        {
            decimal total = 0;

            Console.WriteLine( $"{name} contains the following products with prices:" );

            // Iterates through the list of gifts and adds their prices to the total
            foreach (GiftBase gift in _gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}
