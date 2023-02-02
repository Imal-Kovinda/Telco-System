using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IPaymentTypeDAO
    {
        int Save(PaymentType paymentType, DbConnection dbConnection);
        List<PaymentType> GetPaymentTypes(DbConnection dbConnection);

        PaymentType GetPaymentType(DbConnection dbConnection, String payTypeId);
    }

    public class PaymentTypeSqlDAOImpl : IPaymentTypeDAO
    {
        PaymentType paymentType = new PaymentType();
        public List<PaymentType> GetPaymentTypes(DbConnection dbConnection)
        {
            List<PaymentType> ListPaymentType = new List<PaymentType>();

            dbConnection = new DbConnection();

            dbConnection.cmd.CommandText = "select * from  lb.payment_type ";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            ListPaymentType = dataAccessObject.ReadCollection<PaymentType>(dbConnection.dr);
            dbConnection.dr.Close();

            return ListPaymentType;
        }

        public int Save(PaymentType paymentType, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@payTypeName", paymentType.payTypeName);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }

        public PaymentType GetPaymentType(DbConnection dbConnection, String payTypeId)
        {

            dbConnection.cmd.CommandText = "select * from lb.payment_type WHERE PAYMENT_TYPE_ID = '" + payTypeId + "'";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            paymentType = dataAccessObject.GetSingleOject<PaymentType>(dbConnection.dr);
            dbConnection.dr.Close();
            return paymentType;
        }


    }



}
