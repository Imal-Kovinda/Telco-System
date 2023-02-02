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
    public interface ICmCategoryTypeMasterController
    {
        int Save(CmCategoryTypeMaster cmCategoryTypeMaster);
        int Update(CmCategoryTypeMaster cmCategoryTypeMaster);
        List<CmCategoryTypeMaster> GetCmCategoryTypeMasterDetailList();
        List<CmCategoryTypeMaster> GetCmCategoryTypeMaster(string category);
    }

    public class CmCategoryTypeMasterControllerImpl : ICmCategoryTypeMasterController
    {
        ICmCategoryTypeMasterDAO cmCategoryTypeMasterDAO = DAOFactory.CreateCmCategoryTypeMasterDAO();

        public List<CmCategoryTypeMaster> GetCmCategoryTypeMasterDetailList()
        {
            DbConnection dbConnection = null;
            List<CmCategoryTypeMaster> listDetail = new List<CmCategoryTypeMaster>();

            try
            {

                dbConnection = new DbConnection();

                return cmCategoryTypeMasterDAO.GetCmCategoryTypeMasterDetailList(dbConnection);

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
            return listDetail;
        }

        public List<CmCategoryTypeMaster> GetCmCategoryTypeMaster(string category)
        {
            DbConnection dbConnection = null;
            List<CmCategoryTypeMaster> listDetail = new List<CmCategoryTypeMaster>();

            try
            {
                dbConnection = new DbConnection();

                return cmCategoryTypeMasterDAO.GetCmCategoryTypeMaster(dbConnection, category);

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
            return listDetail;
        }

        public int Save(CmCategoryTypeMaster cmCategoryTypeMaster)
        {
            throw new NotImplementedException();
        }

        public int Update(CmCategoryTypeMaster cmCategoryTypeMaster)
        {
            throw new NotImplementedException();
        }
    }

}
