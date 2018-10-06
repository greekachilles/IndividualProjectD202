using System;
using System.Collections.Generic;

namespace LibraryApplication.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int? Year { get; set; }
        public int? BorrowerId { get; set; }

        public Borrower Borrower { get; set; }
    }
}
