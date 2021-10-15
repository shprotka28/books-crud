using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core
{
    /// <summary>
    /// Contains the CRUD functions used on pdf_library table
    /// </summary>
    public interface IPdfRepository  
    {

        /// <summary>
        /// Adds a new entry to the pdf_library table
        /// </summary>
        List<PdfLibrary> GetAll { get; }

        /// <summary>
        /// Gets all entries from the pdf_library table
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int Insert(PdfLibrary obj);

        /// <summary>
        /// Deletes an entry from the pdf_library table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

    }
}
