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
    /// Contains the CRUD functions used on pdf_library table
    /// Implements <see cref="IPdfRepository"/>
    /// </summary>
    public class PdfRepository : IPdfRepository
    {
        /// <summary>
        /// Deletes an entry from the pdf_library table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            using (IDbConnection db = new MySqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                ///executing delete operation  
                int result = db.Execute("DELETE FROM pdf_library WHERE id=@id", new { id }, commandType: CommandType.Text);
                
                return result != 0;
            }
        }

        /// <summary>
        /// Gets all entries from the pdf_library table
        /// </summary>
        public List<PdfLibrary> GetAll
        {
            get
            {
                ///connecting to data base
                using (IDbConnection db = new MySqlConnection(Helper.ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    ///getting all entries from the data base
                    return db.Query<PdfLibrary>("SELECT * FROM pdf_library", commandType: CommandType.Text).ToList();
                }
            }
        }
        

        /// <summary>
        /// Adds a new entry to the pdf_library table
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Insert(PdfLibrary obj)
        {
            using (IDbConnection db = new MySqlConnection(Helper.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                   db.Open();
                DynamicParameters p = new DynamicParameters();  ///creating a dapper parameter 
                p.Add("p_id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.AddDynamicParams(new { p_content = obj.content, p_file_name= obj.file_name });

                db.Execute("sp_library_Insert", p, commandType: CommandType.StoredProcedure); ///executing stored procedure
                int id = p.Get<int>("p_id");

                return id;
            }
        }
    }
}
