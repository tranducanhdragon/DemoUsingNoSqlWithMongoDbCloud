using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Core.Entity
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
