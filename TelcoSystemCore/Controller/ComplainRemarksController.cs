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
    public interface IComplainRemarksController
    {
        int Save(ComplainRemarks complainRemarks);
        int Update(ComplainRemarks complainRemarks);

        List<ComplainRemarks> GetComplainRemarksDetailList();
    }

    public class ComplainRemarksControllerImpl : IComplainRemarksController
    {
        IComplainRemarksDAO complainRemarksDAO = DAOFactory.CreateComplainRemarksDAO();

        public List<ComplainRemarks> GetComplainRemarksDetailList()
        {
            DbConnection dbConnection = null;
            List<ComplainRemarks> listDetail = new List<ComplainRemarks>();

            try
            {

                dbConnection = new DbConnection();

                return complainRemarksDAO.GetComplainRemarksDetailList(dbConnection);

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

        public int Save(ComplainRemarks complainRemarks)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return complainRemarksDAO.Save(complainRemarks, dbConnection);
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

        public int Update(ComplainRemarks complainRemarks)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return complainRemarksDAO.Update(complainRemarks, dbConnection);
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
