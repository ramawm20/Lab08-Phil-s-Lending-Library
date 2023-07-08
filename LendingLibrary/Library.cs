using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    public class Library : ILibrary
    {
        //Create generic collection (Dictionary) to Store the books 
        private Dictionary<string, Book> Books;
        public int Count => Books.Count;

        public Library()
        {
            Books = new Dictionary<string, Book>();
        }

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            string Author = $"{firstName} {lastName}";
            Book Thebook = new Book(title,Author);
            Books.Add(title, Thebook);
        }

        
        public Book Borrow(string title)
        {
            //Check if the Books Dictionary contains the book
            if (Books.ContainsKey(title))
            {
                Book removedBook = Books[title];
                Books.Remove(title);
                return removedBook;
                
            }
            else
            {
                return null;
            }

        }
        public void Return(Book book)
        {
            Books.Add(book.Author, book);

        }

        public IEnumerator<Book> GetEnumerator()
        {
            return Books.Values.GetEnumerator();
            
        }

     

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
