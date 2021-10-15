using System;
using System.Collections.Generic;
using Autofac;
using Books.Core;
using Books.DataAccess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Business
{
    /// <summary>
    /// For communication between the user interface and the database
    /// </summary>
    public class PdfLibraryService
    {
        static IContainer _container;
        static PdfLibraryService()
        {
            ContainerBuilder builder = new ContainerBuilder(); 
            builder.RegisterType<PdfRepository>().As<IPdfRepository>();
            _container = builder.Build(); ///Create a new container with the component registrations that have been made.
        }
        /// <summary>
        /// retrieve a service from a context
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            return _container.Resolve<IPdfRepository>().Delete(id); 
        }

        /// <summary>
        /// retrieve a service from a context
        /// </summary>
        /// <returns></returns>
        public static List<PdfLibrary> GetAll()
        {
            return _container.Resolve<IPdfRepository>().GetAll; 
        }

        /// <summary>
        /// retrieve a service from a context
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static PdfLibrary Save(PdfLibrary obj, EntityState state)  
        {
            if (state == EntityState.Added)
            { 
                obj.id = _container.Resolve<IPdfRepository>().Insert(obj); 
            } 
            
            return obj;
        }

    }
}
