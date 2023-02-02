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
    public interface ICusAccountDNController
    {
        int Save(CusAccountDN cusAccountDN);
        int Update(CusAccountDN cusAccountDN);
        int Delete(CusAccountDN cusAccountDN);
        List<CusAccountDN> GetCusAccountDNs();
    }

    public class CusAccountDNControllerImpl : ICusAccountDNController
    {
        ICusAccountDNDAO cusAccountDNDAO = DAOFactory.CreateCusAccountDNDAO();

        public List<CusAccountDN> GetCusAccountDNs()
        {
            DbConnection dbConnection = null;
            List<CusAccountDN> listCusAccDN = new List<CusAccountDN>();
            try
            {
                dbConnection = new DbConnection();
                listCusAccDN = cusAccountDNDAO.GetCusAccountDNs(dbConnection);
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
            return listCusAccDN;
        }

        public int Save(CusAccountDN cusAccountDN)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return cusAccountDNDAO.Save(cusAccountDN, dbConnection);
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
        }

        public int Update(CusAccountDN cusAccountDN)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return cusAccountDNDAO.Update(cusAccountDN, dbConnection);
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
        }

        public int Delete(CusAccountDN cusAccountDN)
        {

            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return cusAccountDNDAO.Delete(cusAccountDN, dbConnection);
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
        }
    }



}
