using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        //relationships
        public ICollection<BookAuthor> BooksLink { get; set; }
    }
}
