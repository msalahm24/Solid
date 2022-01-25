using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2022
{
    internal class InvoicePrinter
    {
        public Invoice Invoice { get; set; }

        public InvoicePrinter(Invoice invoice)
        {
            this.Invoice = invoice;
        }

        public void PrintInvoice()
        {
            Console.WriteLine($"the quantity of the books is {this.Invoice.Quantity} the book name is {this.Invoice.Book.Name} the book price is {this.Invoice.Book.Price}");
            Console.WriteLine($"discount rate is {this.Invoice.DiscountRate}");
            Console.WriteLine($"the tax rate is {this.Invoice.TaxRate}");
            Console.WriteLine($"the total is {this.Invoice.Total}");
        }
    }
}
