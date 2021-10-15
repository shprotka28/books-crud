using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core
{
    /// <summary>
    /// References books_managment table 
    /// </summary>
    public class Book 
    {
        ///Refference to id 
        public int id { get; set; }

        ///Refference to book_name 
        public string book_name{ get; set; }

        ///Refference to book_author 
        public string book_author { get; set; }

        ///Refference to book_author 
        public string genre { get; set; }
        
    }
}
