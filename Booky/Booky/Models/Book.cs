using System;

namespace Booky
{
    public class Book
    {
        public Guid Guid { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string IsbnCode { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Summary { get; set; }
    }
}
