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
    public interface IPaymentTypeController
    {
        int Save(PaymentType paymentType);
        List<PaymentType> GetPaymentTypes();
    }

    public class PaymentTypeControllerImpl : IPaymentTypeController
    {
        IPaymentTypeDAO paymentTypeDAO = DAOFactory.CreatePaymentTypeDAO();

        public List<PaymentType> GetPaymentTypes()
        {
            DbConnection dbConnection = null;
            List<PaymentType> listPaymentType = new List<PaymentType>();
            try
            {
                dbConnection = new DbConnection();
                listPaymentType = paymentTypeDAO.GetPaymentTypes(dbConnection);

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
            return listPaymentType;
        }

        public int Save(PaymentType paymentType)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return paymentTypeDAO.Save(paymentType, dbConnection);
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
