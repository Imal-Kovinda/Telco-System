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
        public int CustomerId { get; set; }

        [DBField("CUSTOMER_NAME")]
        public string CustomerName { get; set; }

        [DBField("CUSTOMER_TYPE_ID")]
        public string CustomerTypeId { get; set; }

        [DBField("TITLE")]
        public string Title { get; set; }

        [DBField("ACTIVATED_ON")]
        public string ActivatedOn { get; set; }

        [DBField("ACTIVATED_BY")]
        public string ActivatedBy { get; set; }

        [DBField("ADDRESS_LINE_1")]
        public int AddressLine1 { get; set; }

        [DBField("ADDRESS_LINE_2")]
        public int AddressLine2 { get; set; }

        [DBField("ADDRESS_LINE_3")]
        public int AddressLine3 { get; set; }

        [DBField("CITY")]
        public string City { get; set; }

        [DBField("POSTAL_CODE")]
        public string PostalCode { get; set; }

        [DBField("MODIFIED_BY")]
        public string ModifiedBy { get; set; }

        [DBField("MODIFIED_ON")]
        public string ModifiedOn { get; set; }

        [DBField("PROFILE_STATUS")]
        public string ProfileStatus { get; set; }

        [DBField("CP_REMARKS")]
        public string CpRemarks { get; set; }

        [DBField("DISTRICT")]
        public string District { get; set; }

        [DBField("PROVINCE")]
        public string Province { get; set; }

        [DBField("CUST_GROUP")]
        public string CustGroup { get; set; }

        [DBField("CUST_RATING")]
        public string CustRating { get; set; }

        [DBField("TOP_CUSTOMER_STAT")]
        public string TopCustomerStat { get; set; }

        [DBField("CONFIDENTIAL")]
        public string Confidential { get; set; }

        [DBField("PREFERRED_LANGUAGE")]
        public string PreferredLanguage { get; set; }

        [DBField("PROFESSION_DESIGNATION")]
        public string ProfessionDesignation { get; set; }

        [DBField("DATE_OF_BIRTH")]
        public string DateOfBirth { get; set; }

        [DBField("CONTACT_PHONE_NO")]
        public string ContactPhoneNumber { get; set; }

        [DBField("MANAGER_1")]
        public string Manager1 { get; set; }

        [DBField("MANAGER_2")]
        public string Manager2 { get; set; }

        [DBField("SALES_PERSON")]
        public string SalesPerson { get; set; }

        [DBField("NEW_ID_NUMBER")]
        public string NewIdNumber { get; set; }




    }
}
