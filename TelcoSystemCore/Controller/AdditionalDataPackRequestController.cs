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
    public interface IAdditionalDataPackRequestController
    {
        int Save(AdditionalDataPackRequest customer);
        int Update(AdditionalDataPackRequest customer);
        List<AdditionalDataPackRequest> GetAdditionalDataPackRequestDetailList(string phoneNumber);
    }

    public class AdditionalDataPackRequestControllerImpl : IAdditionalDataPackRequestController
    {
        IAdditionalDataPackRequestDAO additionalDataPackRequestDAO = DAOFactory.CreateAdditionalDataPackRequestDAO();

        public int Save(AdditionalDataPackRequest additionalDataPackRequest)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return additionalDataPackRequestDAO.Save(additionalDataPackRequest, dbConnection);
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

        public int Update(AdditionalDataPackRequest additionalDataPackRequest)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return additionalDataPackRequestDAO.Update(additionalDataPackRequest, dbConnection);
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

        public List<AdditionalDataPackRequest> GetAdditionalDataPackRequestDetailList(string phoneNumber)
        {
            DbConnection dbConnection = null;
            List<AdditionalDataPackRequest> listDetail = new List<AdditionalDataPackRequest>();

            try
            {
                dbConnection = new DbConnection();

                if (phoneNumber != null)
                {
                    return additionalDataPackRequestDAO.GetAdditionalDataPackRequestDetailList(dbConnection, phoneNumber);
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
            return listDetail;
        }

    }
}
