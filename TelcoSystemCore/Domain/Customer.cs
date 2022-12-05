using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class Customer
    {
        [DBField("CUSTOMER_ID")]
        public int CUSTOMER_ID { get; set; }

        [DBField("CUSTOMER_NAME")]
        public string CUSTOMER_NAME { get; set; }

        [DBField("CUSTOMER_TYPE_ID")]
        public string CUSTOMER_TYPE_ID { get; set; }

        [DBField("TITLE")]
        public string TITLE { get; set; }

        [DBField("ACTIVATED_ON")]
        public string ACTIVATED_ON { get; set; }

        [DBField("ACTIVATED_BY")]
        public string ACTIVATED_BY { get; set; }

        [DBField("ADDRESS_LINE_1")]
        public int ADDRESS_LINE_1 { get; set; }

        [DBField("ADDRESS_LINE_2")]
        public int ADDRESS_LINE_2 { get; set; }

        [DBField("ADDRESS_LINE_3")]
        public int ADDRESS_LINE_3 { get; set; }

        [DBField("CITY")]
        public string CITY { get; set; }

        [DBField("POSTAL_CODE")]
        public string POSTAL_CODE { get; set; }

        [DBField("MODIFIED_BY")]
        public string MODIFIED_BY { get; set; }

        [DBField("MODIFIED_ON")]
        public string MODIFIED_ON { get; set; }

        [DBField("PROFILE_STATUS")]
        public string PROFILE_STATUS { get; set; }

        [DBField("CP_REMARKS")]
        public string CP_REMARKS { get; set; }

        [DBField("DISTRICT")]
        public string DISTRICT { get; set; }

        [DBField("PROVINCE")]
        public string PROVINCE { get; set; }

        [DBField("CUST_GROUP")]
        public string CUST_GROUP { get; set; }

        [DBField("CUST_RATING")]
        public string CUST_RATING { get; set; }

        [DBField("TOP_CUSTOMER_STAT")]
        public string TOP_CUSTOMER_STAT { get; set; }

        [DBField("CONFIDENTIAL")]
        public string CONFIDENTIAL { get; set; }

        [DBField("PREFERRED_LANGUAGE")]
        public string PREFERRED_LANGUAGE { get; set; }

        [DBField("PROFESSION_DESIGNATION")]
        public string PROFESSION_DESIGNATION { get; set; }

        [DBField("DATE_OF_BIRTH")]
        public string DATE_OF_BIRTH { get; set; }

        [DBField("CONTACT_PHONE_NO")]
        public string CONTACT_PHONE_NO { get; set; }

        [DBField("MANAGER_1")]
        public string MANAGER_1 { get; set; }

        [DBField("MANAGER_2")]
        public string MANAGER_2 { get; set; }

        [DBField("SALES_PERSON")]
        public string SALES_PERSON { get; set; }

        [DBField("NEW_ID_NUMBER ")]
        public string NEW_ID_NUMBER { get; set; }

       


    }
}
