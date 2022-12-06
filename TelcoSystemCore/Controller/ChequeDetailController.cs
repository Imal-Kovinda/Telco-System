using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;

namespace TelcoSystemCore.Controller
{
    internal interface IChequeDetailController
    {
        int Save(ChequeDetail chequeDetail);
        int Update(ChequeDetail chequeDetail);
        List<ChequeDetail> GetChequeDetailList(string ChequeDetailQuery = null);
    }

    public class ChequeDetailControllerImpl : IChequeDetailController
    {
        IChequeDetailController chequeDetailDAO = DAOFactory.CreateChequeDetailDAO();
        public int Save(ChequeDetail chequeDetail)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return chequeDetailDAO.Save(chequeDetail, dbConnection);
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

        public int Update(ChequeDetail chequeDetail)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return customerDAO.Update(customer, dbConnection);
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

        public List<ChequeDetail> GetChequeDetailList(string ChequeDetailQuery = null)
        {
            throw new NotImplementedException();
        }
    }
}
