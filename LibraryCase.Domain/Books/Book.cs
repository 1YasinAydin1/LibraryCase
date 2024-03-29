﻿using LibraryCase.Domain.BorrowedBooks;
using LibraryCase.Domain.Common;

namespace LibraryCase.Domain.Books
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public byte[] Image { get; set; }
        public string Author { get; set; }
        public bool Status { get; set; }
        public string Type { get; set; }
        public string CoverLetter { get; set; }
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }
    }
}
