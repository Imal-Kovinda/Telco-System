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
    public interface ICmComplainSubTypeMasterController
    {
        int Save(CmComplainSubTypeMaster cmComplainSubTypeMaster);
        int Update(CmComplainSubTypeMaster cmComplainSubTypeMaster);
        List<CmComplainSubTypeMaster> GetCmComplainSubTypeMasterDetailList();
        List<CmComplainSubTypeMaster> GetCmComplainSubTypeMaster(string complainSub);
    }

    public class CmComplainSubTypeMasterControllerImpl : ICmComplainSubTypeMasterController
    {
        ICmComplainSubTypeMasterDAO cmComplainSubTypeMasterDAO = DAOFactory.CreateCmComplainSubTypeMasterDAO();

        public List<CmComplainSubTypeMaster> GetCmComplainSubTypeMasterDetailList()
        {
            DbConnection dbConnection = null;
            List<CmComplainSubTypeMaster> listDetail = new List<CmComplainSubTypeMaster>();

            try
            {

                dbConnection = new DbConnection();
            


                return cmComplainSubTypeMasterDAO.GetCmComplainSubTypeMasterDetailList(dbConnection);
                

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

        public List<CmComplainSubTypeMaster> GetCmComplainSubTypeMaster(string complainSub)
        {
            DbConnection dbConnection = null;
            List<CmComplainSubTypeMaster> listDetail = new List<CmComplainSubTypeMaster>();

            try
            {
                dbConnection = new DbConnection();

                return cmComplainSubTypeMasterDAO.GetCmComplainSubTypeMaster(dbConnection, complainSub);

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

        public int Save(CmComplainSubTypeMaster cmComplainSubTypeMaster)
        {
            throw new NotImplementedException();
        }

        public int Update(CmComplainSubTypeMaster cmComplainSubTypeMaster)
        {
            throw new NotImplementedException();
        }
    }

}
