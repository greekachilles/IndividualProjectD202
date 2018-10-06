using System;
using System.Collections.Generic;

namespace LibraryApplication.Models
{
    public partial class Borrower
    {
        public Borrower()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
