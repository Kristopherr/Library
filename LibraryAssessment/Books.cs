using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssessment
{
    public class Books
    {
        public Books()
        {

        }

        public Books(string name, string author, string isbn, string summary)
        {
            this.NAME = name;
            this.AUTHOR = author;
            this.ISBN = isbn;
            this.SUMMARY = summary;
        }

        public string NAME { get; set; }
        public string AUTHOR { get; set; } 
        public string ISBN { get; set; }

        public string SUMMARY { get; set; }

    }
}
