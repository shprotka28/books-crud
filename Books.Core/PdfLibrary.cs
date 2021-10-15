using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core
{
    /// <summary>
    /// References pdf_library table
    /// </summary>
    public class PdfLibrary 
    {
        ///Refference to id 
        public int id { get; set; }

        ///Refference to content 
        public byte[] content { get; set; }

        ///Refference to file_name 
        public string file_name { get; set; }
    }
}
