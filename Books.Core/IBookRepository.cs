using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core
{
    /// <summary>
    /// Contains the CRUD functions, used on books_management table
    /// </summary>
    public interface IBookRepository 
    {
        /// <summary>
        /// Gets all entries from the books_management table
        /// </summary>
        List<Book> GetAll { get; }

        /// <summary>
        /// Adds a new book to the books_management table 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int Insert(Book obj);

        /// <summary>
        /// Updates already existing data entries
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool Update(Book obj);

        /// <summary>
        /// Deletes an entry from the books_managemet table
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        bool Delete(int bookID);
    }
}