using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace solid2022
{
    internal class Invoice
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double DiscountRate { get; set; }
        public double TaxRate { get; set; }
        public double Total { get; set; }

        public Invoice(Book book, int quantity, double discount_rate, double tax_rate)
        {
            this.Book = book;
            this.Quantity = quantity;
            this.DiscountRate = discount_rate;
            this.TaxRate = tax_rate;
            this.Total = this.CalculateRate();
        }

        private double CalculateRate()
        {
            double price = (this.Book.Price - (this.Book.Price * this.DiscountRate)) * this.Quantity;
            double price_with_tax = price * (1 + this.TaxRate);
            return price_with_tax;
        }


        /* We will move this printing method from this class beacause it violates the SPR( Single Responsibility Principle) in our class
         * It mixing between the printing logic and business logic 
         */
        //public void PrintInvoice()
        //{
        //    Console.WriteLine($"the quantity of the books is {this.Quantity} the book name is {this.Book.Name} the book price is {this.Book.Price}");
        //    Console.WriteLine($"discount rate is {this.DiscountRate}");
        //    Console.WriteLine($"the tax rate is {this.TaxRate}");
        //    Console.WriteLine($"the total is {this.Total}");
        //}


        /* We will move this saving to file  method from this class beacause it violates the SPR ( Single Responsibility Principle) in our class
         * It mixing between the persistence logic and business logic 
         */

        //public void SaveToFile()
        //{
        //    string filename = "book";
        //    string BookJsonString = JsonSerializer.Serialize(this);
        //    File.WriteAllText(filename, BookJsonString);
        //}
    }
}
