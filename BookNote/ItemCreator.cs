using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BookNote
{
    class ItemCreator : ICreator
    {
        private readonly string connectionString = Helper.connectionString;
        public List<Category> GetAllCategories()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Category>("spCategories_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public int InsertCategory(Category obj)
        {
            //This is used to connect with db. We need a string connection which is in the app config. 
            //We will use a class to go get it 
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                DynamicParameters p = new DynamicParameters();
                //This will get the category ID back in case we need it
                p.Add("@CategoryID", dbType: DbType.Int32, direction: ParameterDirection.Output);

                //Other parameter are used to insert the category data
                p.Add("@Name", obj.Name);
                db.Execute("spCategories_Insert", p, commandType: CommandType.StoredProcedure);
                return p.Get<int>("@CategoryID");
            }
        }
        
        public int InsertBook(Book obj)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBook(Book obj)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(Category obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                int result = db.Execute("spCategories_Update", new {CategoryID = obj.CategoryID, Name = obj.Name}, commandType: CommandType.StoredProcedure);
                return result != 0;
            }
        }
    }
}
