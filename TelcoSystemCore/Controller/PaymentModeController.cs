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
    public interface IPaymentModeController
    {
        int Save(PaymentMode paymentMode);
    }

    public class PaymentModeControllerImpl : IPaymentModeController
    {
        IPaymentModeDAO paymentModeDAO = DAOFactory.CreatePaymentModeDAO();

        public int Save(PaymentMode paymentMode)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return paymentModeDAO.Save(paymentMode, dbConnection);
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
