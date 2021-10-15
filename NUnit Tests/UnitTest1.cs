using System;
using System.Data;
using Books.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Books.Core;
using Dapper;
using System.Linq;
using System.Configuration;

namespace NUnit_Tests
{
    [TestClass]
    public class UnitTest1
       
    {
        BookRepository bookRepository = new BookRepository();

        [TestMethod]
        public void DeleteTest()
        {
            



        }
        [TestMethod]
        public void InsertTest()
        {
            using (IDbConnection db = new MySqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                Book book = new Book();
                book.book_name = "testvalue";
                book.book_author = "testauthor";
                book.genre = "testgenre";

                bookRepository.Insert(book);

                Book result = db.Query<Book>("SELECT * FROM books.books_management LIMIT 1", commandType: CommandType.Text).ToList().First();


                if (book.id != result.id)
                {
                    Assert.Fail();
                }
            }
        }
    }
}
