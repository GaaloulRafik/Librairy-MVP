using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVP.Models
{
    class BooksDataModel
    {
        public int Book_ID { get; set; }
        public string Book_Name { get; set; }
        public string Book_Author { get; set; }
        public int Book_PageNumber { get; set; }
        public string Book_Country { get; set; }

    }
}
