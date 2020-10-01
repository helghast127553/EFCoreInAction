using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public byte Order { get; set; }

        //relationships
        public Book Book { get; set; }
        public Author Author { get; set; }  
    }
}
