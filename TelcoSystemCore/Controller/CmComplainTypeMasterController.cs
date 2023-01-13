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
    public interface ICmComplainTypeMasterController
    {
        int Save(CmComplainTypeMaster cmComplainTypeMaster);
        int Update(CmComplainTypeMaster cmComplainTypeMaster);
        List<CmComplainTypeMaster> GetCmComplainTypeMasterDetailList();
        List<CmComplainTypeMaster> GetCmComplainTypeMaster(string complain);
    }

    public class CmComplainTypeMasterControllerImpl : ICmComplainTypeMasterController
    {
        ICmComplainTypeMasterDAO cmComplainTypeMasterDAO = DAOFactory.CreateCmComplainTypeMasterDAO();

        public List<CmComplainTypeMaster> GetCmComplainTypeMasterDetailList()
        {
            DbConnection dbConnection = null;
            List<CmComplainTypeMaster> listDetail = new List<CmComplainTypeMaster>();

            try
            {

                dbConnection = new DbConnection();


                return cmComplainTypeMasterDAO.GetCmComplainTypeMasterDetailList(dbConnection);


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

        public List<CmComplainTypeMaster> GetCmComplainTypeMaster(string complain)
        {
            DbConnection dbConnection = null;
            List<CmComplainTypeMaster> listDetail = new List<CmComplainTypeMaster>();

            try
            {
                dbConnection = new DbConnection();

                return cmComplainTypeMasterDAO.GetCmComplainTypeMaster(dbConnection, complain);

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

        public int Save(CmComplainTypeMaster cmComplainTypeMaster)
        {
            throw new NotImplementedException();
        }

        public int Update(CmComplainTypeMaster cmComplainTypeMaster)
        {
            throw new NotImplementedException();
        }
    }
}
