using System;
using System.Collections.Generic;
using Autofac;
using Books.Core;
using Books.DataAccess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Books.Business
{
    /// <summary>
    /// For communication between the user interface and the database + 
    /// for easy change of the dataAccess to any ORM or to any data base
    /// </summary>
    public class BookService  
    {
        static IContainer _container;
        static BookService()
        {
            ContainerBuilder builder = new ContainerBuilder(); 
            builder.RegisterType<BookRepository>().As<IBookRepository>();
            _container=builder.Build(); 
           //Creating a new container with the component registrations that have been made.
        }


        /// <summary>
        /// retrieve a service from a context
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public static bool Delete(int bookID)
        {
            return _container.Resolve<IBookRepository>().Delete(bookID); 
        }

        /// <summary>
        /// retrieve a service from a context
        /// </summary>
        /// <returns></returns>
        public static List<Core.Book> GetAll()
        {
            return _container.Resolve<IBookRepository>().GetAll; 
        }

        /// <summary>
        /// Save changes
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static Core.Book Save(Core.Book obj, EntityState state)  
        {
            _container.Resolve<IBookRepository>().Insert(obj); // retrieve a service from a context

            return obj;
        }

        /// <summary>
        /// Edit
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static bool Update(Core.Book obj, EntityState state)  
        {
           return _container.Resolve<IBookRepository>().Update(obj);  
        }
    }
}
