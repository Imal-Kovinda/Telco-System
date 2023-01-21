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
    public interface IComSectionsMastersController
    {
        int Save(ComSectionsMasters comSectionsMasters);
        int Update(ComSectionsMasters comSectionsMasters);
        //List<Customer> GetCustomerList(string CustomQuery = null);

        List<ComSectionsMasters> GetComSectionsMastersDetailList();
    }

    public class ComSectionsMastersControllerImpl : IComSectionsMastersController
    {
        IComSectionsMastersDAO comSectionsMastersDAO = DAOFactory.CreateComSectionsMastersDAO();

        public List<ComSectionsMasters> GetComSectionsMastersDetailList()
        {
            DbConnection dbConnection = null;
            List<ComSectionsMasters> listDetail = new List<ComSectionsMasters>();

            try
            {

                dbConnection = new DbConnection();

                return comSectionsMastersDAO.GetComSectionsMastersDetailList(dbConnection);

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

        public int Save(ComSectionsMasters comSectionsMasters)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return comSectionsMastersDAO.Save(comSectionsMasters, dbConnection);
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

        public int Update(ComSectionsMasters comSectionsMasters)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return comSectionsMastersDAO.Update(comSectionsMasters, dbConnection);
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
