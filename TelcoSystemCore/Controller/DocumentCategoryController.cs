using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;

namespace TelcoSystemCore.Controller
{
    public interface IDocumentCategoryController
    {
        List<Document> GetDocCategory();
    }

    public class DocumentCategoryCpntrollerImpl : IDocumentCategoryController
    {
        IDocumentCategoryDAO documentCategoryDAO = DAOFactory.CreateDocumentCategoryDAO();


        public List<Document> GetDocCategory()
        {
            DbConnection dbConnection = null;
            List<Document> listCategory = new List<Document>();

            try
            {
                dbConnection = new DbConnection();
                listCategory = documentCategoryDAO.GetCategory(dbConnection);
            }
            catch (Exception)
            {
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();
                }
            }
            return listCategory;
        }

    }


}
