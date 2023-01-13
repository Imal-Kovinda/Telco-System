using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class LocationProfile
    {
        //TelcoSystemCore.Domain.LocationProfile' does not contain a property with the name 'locat_name'.'

        [DBField("locat_cd")]
        public string LocatCd { get; set; }

        [DBField("locat_name")]
        public string LocatName { get; set; }

        [DBField("locat_addr_line_1")]
        public string LocatAddrLine1 { get; set; }

        [DBField("locat_addr_line_2")]
        public string LocatAddrLine2 { get; set; }

        [DBField("locat_addr_line_3")]
        public string LocatAddrLine3 { get; set; }

        [DBField("city")]
        public string City { get; set; }

        [DBField("online_receipt_categ")]
        public string OnlineReceiptCateg { get; set; }

        [DBField("batch_receipt_categ")]
        public string BatchReceiptCateg { get; set; }

        [DBField("bank_receipt_categ")]
        public string BankReceiptCateg { get; set; }

        [DBField("debit_entry_categ")]
        public string DebitEntryCateg { get; set; }

        [DBField("credit_entry_categ")]
        public string CreditEntryCateg { get; set; }

        [DBField("introduced_by")]
        public string IntroducedBy { get; set; }

        [DBField("introduced_on")]
        public DateTime IntroducedOn { get; set; }

        [DBField("care_loc_code")]
        public string CareLocCode { get; set; }

        [DBField("cluster_code")]
        public string ClusterCode { get; set; }

        [DBField("deactivated_on")]
        public DateTime DeactivatedOn { get; set; }

        [DBField("deactivated_by")]
        public string DeactivatedBy { get; set; }

        [DBField("etisalat_deposit_no")]
        public string EtisalatDepositNo { get; set; }

        [DBField("supervisor_id")]
        public string SupervisorId { get; set; }

        [DBField("dl")]
        public string Dl { get; set; }

        [DBField("emp_id")]
        public string EmpId { get; set; }
    }
}
