using Books.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Books.DataAccess
{
    /// <summary>
    /// Contains the CRUD functions, used on books_management table
    /// Implements <see cref="IBookRepository"/>
    /// </summary>
    public class BookRepository : IBookRepository
    {
        /// <summary>
        /// Deletes an entry from the books_managemet table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            using (IDbConnection db = new MySqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                //executing delete operation 
                int result = db.Execute("DELETE FROM books.books_managment WHERE id = @id", new { id }, commandType: CommandType.Text);
                
                return result != 0;
            }
        }

        /// <summary>
        /// Gets all entries from the books_management table
        /// </summary>
        public List<Book> GetAll
        {
            get
            {
                //connecting to database
                using (IDbConnection db = new MySqlConnection(Helper.ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    //getting all the entries from the database
                    return db.Query<Book>("SELECT * FROM books.books_managment", commandType: CommandType.Text).ToList();
                }
            }
        }

        /// <summary>
        /// Adds a new book to the books_management table 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Insert(Book obj)
        {
            using (IDbConnection db = new MySqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters p = new DynamicParameters();  //creating a dapper parameter 
                p.Add("p_id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.AddDynamicParams(new { p_book_name = obj.book_name, p_book_author = obj.book_author, p_genre=obj.genre});

                db.Execute("sp_books_Insert", p, commandType: CommandType.StoredProcedure); //executing stored procedure
                int id = p.Get<int>("p_id");

                return id;
            }
        }
        /// <summary>
        /// Updates already existing data entries
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Update(Book obj)
        {
            using (IDbConnection db = new MySqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                //executing update operation
                int result = db.Execute("UPDATE books.books_managment SET book_name = @book_name, book_author = @book_author, genre = @genre WHERE id = @id;", 
                    new {
                        book_name = obj.book_name,
                        book_author = obj.book_author,
                        genre = obj.genre, 
                        id = obj.id
                    });
                return result != 0;
            }
        }
    }
}
