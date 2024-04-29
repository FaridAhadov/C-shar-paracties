using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    internal class Book
    {
        public string name;
        public string writer;
        public int page;

        public Book(string name, string writer, int page)
        {
            this.name = name;
            this.writer = writer;
            this.page = page;
        }
    }
}
