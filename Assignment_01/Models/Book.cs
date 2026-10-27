using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishYear { get; set; }
        public bool InStock { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;


        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}
