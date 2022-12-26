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
    public interface ICmLogComplainsController
    {
        //int Save(CmLogComplains cmLogComplains);
        //int Update(CmLogComplains cmLogComplains);
        List<CmLogComplains> GetCmLogComplainsList(string cmLogComplains = null);
    }

    public class CmLogComplainsControllerImpl : ICmLogComplainsController
    {
        ICmLogComplainsDAO cmLogComplainsDAO = DAOFactory.CreateCmLogComplainsDAO();

        public List<CmLogComplains> GetCmLogComplainsList(string cmLogComplains = null)
        {
            DbConnection dbConnection = null;
            List<CmLogComplains> listCmLogComplains = new List<CmLogComplains>();
            try
            {

                dbConnection = new DbConnection();
                listCmLogComplains = cmLogComplainsDAO.GetCmLogComplainsList(dbConnection);

                if (cmLogComplains != null)
                {

                    return cmLogComplainsDAO.GetCmLogComplainsList(dbConnection, cmLogComplains);
                }
                else
                {
                    //check
                    return cmLogComplainsDAO.GetCmLogComplainsList(dbConnection);

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
            //return listCmLogComplains;
        }
    }
}
