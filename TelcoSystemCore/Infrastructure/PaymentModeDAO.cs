using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;


namespace TelcoSystemCore.Infrastructure
{
    public interface IPaymentModeDAO
    {
        int Save(PaymentMode paymentMode, DbConnection dbConnection);
    }

    public class PaymentModeSqlDAOImpl : IPaymentModeDAO
    {
        public int Save(PaymentMode paymentMode, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }
    }

}
