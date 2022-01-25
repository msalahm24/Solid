using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid2022
{
    internal class Book
    {
        public string Name { get; set; }
        public string Auther_name { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Isbn { get; set; }
        public Book(string name, string auther, int year, int price, string isbn)
        {
            this.Name = name;
            this.Auther_name = auther;
            this.Year = year;
            this.Price = price;
            this.Isbn = isbn;
        }
    }
}
