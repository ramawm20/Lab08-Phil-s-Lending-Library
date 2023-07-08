using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    public  class Book
    {
        public string Title;
        public string Author;

        public Book(string Title,string Author)
        {
            this.Title = Title;
            this.Author = Author;   
        }
    }
}
