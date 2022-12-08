using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;
using DbConnection = TelcoSystemCore.Common.DbConnection;

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
        IChequeDetailDAO chequeDetailDAO = DAOFactory.CreateChequeDetailDAO();
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
                return chequeDetailDAO.Update(chequeDetail, dbConnection);
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
            DbConnection dbConnection = null;
            List<ChequeDetail> listChequeDetail = new List<ChequeDetail>();
            try
            {

                dbConnection = new DbConnection();
                listChequeDetail = chequeDetailDAO.GetChequeDetailList(dbConnection);

                if (ChequeDetailQuery != null)
                {

                    return chequeDetailDAO.GetChequeDetailList(dbConnection, ChequeDetailQuery);
                }
                else
                {
                    //check
                    return chequeDetailDAO.GetChequeDetailList(dbConnection);

                }

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
            return listChequeDetail;
        }
    }
}
