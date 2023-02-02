using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IDocumentCategoryDAO
    {
        List<Document> GetCategory(DbConnection dbConnection);
    }

    public class DocumentCategorySqlDAOImpl : IDocumentCategoryDAO
    {
        Document document = new Document();
        public List<Document> GetCategory(DbConnection dbConnection)
        {
            List<Document> listCategory = new List<Document>();

            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText = "select * from lb.document_category";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            listCategory = dataAccessObject.ReadCollection<Document>(dbConnection.dr);
            dbConnection.dr.Close();

            return listCategory;
        }

    }


}
