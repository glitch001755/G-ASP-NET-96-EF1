using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public bool ISActive { get; set; }

        public List<Book> Books { get; set; } = new();

    }
}
