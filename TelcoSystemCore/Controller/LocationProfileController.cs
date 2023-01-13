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
    public interface ILocationProfileController
    {
        int Save(LocationProfile locationProfile);
        int Update(LocationProfile locationProfile);
        List<LocationProfile> GetLocationProfileDetailList();
        List<LocationProfile> GetLocationProfileLocationCd(string nearestBo);
    }

    public class LocationProfileControllerImpl : ILocationProfileController
    {
        ILocationProfileDAO locationProfileDAO = DAOFactory.CreateLocationProfileDAO();

        public int Save(LocationProfile locationProfile)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return locationProfileDAO.Save(locationProfile, dbConnection);
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

        public int Update(LocationProfile locationProfile)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return locationProfileDAO.Update(locationProfile, dbConnection);
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

        public List<LocationProfile> GetLocationProfileDetailList()
        {
            DbConnection dbConnection = null;
            List<LocationProfile> listDetail = new List<LocationProfile>();

            try
            {
                dbConnection = new DbConnection();

                return locationProfileDAO.GetLocationProfileDetailList(dbConnection);


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

        public List<LocationProfile> GetLocationProfileLocationCd(string nearestBo)
        {
            DbConnection dbConnection = null;
            List<LocationProfile> listDetail = new List<LocationProfile>();

            try
            {
                dbConnection = new DbConnection();

                return locationProfileDAO.GetLocationProfileLocationCd(dbConnection,  nearestBo);


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
