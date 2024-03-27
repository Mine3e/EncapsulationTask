using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Book : Product
    {
        public string Genre { get; set; }

        public Book(string no, double price, string name, string genre)
        {
            No = no;
            _price = price;
            Name = name;
            Genre = genre;

        }
        public void ShowInfo()
        {
            
            Console.WriteLine($"Name: {Name}, Price: {_price}, Genre: {Genre}, No:{No}");
        }
    }
}
