using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Library
    {
        Book[] Books = { };
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length - 1] = book;
        }
        public Book[] GetFilteredBooks (string genre)
        {

            Book[] fbooks = {};
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre == genre)
                {
                    Array.Resize(ref fbooks, fbooks.Length+1);
                    fbooks[fbooks.Length - 1] = Books[i];
                }
            }
            return fbooks;
        }
        public Book[] GetFilteredBooks(int minPrice,  int maxPrice)
        {
            Book[] pbooks = { };
            for(int i = 0;i < Books.Length;i++)
            {
                if (Books[i]._price >minPrice && Books[i]._price < maxPrice)
                {
                    Array.Resize(ref  pbooks, pbooks.Length+1);
                    pbooks[pbooks.Length - 1] = Books[i];

                }
            }
            return pbooks;
            
        }
        public void ShowAllBooks()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"{Books[i].Name},{Books[i]._price}, {Books[i].Genre}, {Books[i].No}");
            }
        }


    }
}
