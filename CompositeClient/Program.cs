/******************************************************************************
 * Filename    = Program.cs
 *
 * Author      = Sunil Varma Tenali
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = CompositeDesignPattern
 *
 * Description = Demonstrates the Composite Design Pattern using a hierarchy of gifts.
 *****************************************************************************/

using System;
using CompositeDesignPattern;

namespace CompositeClient
{
    public class Program
    {
        public static void Main( string[] args )
        {
            var toy = new SingleGift( "Toy" , 20.00m );
            var book = new SingleGift( "Book" , 15.00m );

            var giftBasket = new CompositeGift( "Gift Basket" , 0.00m );
            giftBasket.Add( toy );
            giftBasket.Add( book );

            var holidayBasket = new CompositeGift( "Holiday Basket" , 0.00m );
            holidayBasket.Add( giftBasket );

            var chocolate = new SingleGift( "Chocolate" , 10.00m );
            holidayBasket.Add( chocolate );

            Console.WriteLine( "Total Price of Holiday Basket:" );
            decimal totalPrice = holidayBasket.CalculateTotalPrice();
            Console.WriteLine( $"Total Price: {totalPrice} ");

            Console.ReadLine();
        }
    }
}

