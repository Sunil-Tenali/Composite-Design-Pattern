/******************************************************************************
 * Filename    = IGiftOperations.cs
 *
 * Author      = Sunil Varma Tenali
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = CompositeDesignPattern
 *
 * Description = Defines an interface for gift operations, providing methods to add and remove gifts in a composite structure.
 *****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public interface IGiftOperations
    {
        // Method to add a gift to the composite structure
        void Add( GiftBase gift );

        // Method to remove a gift from the composite structure
        void Remove( GiftBase gift );
    }
}
