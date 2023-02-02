using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class CmLogComplains
    {
        [DBField("comp_id")]
        public string CompId { get; set; }

        [DBField("txn_date")]
        public DateTime TxnDate { get; set; }

        [DBField("cust_name")]
        public string CustName { get; set; }

        [DBField("comp_cat_code")]
        public string CompCatCode { get; set; }

        [DBField("comp_type")]
        public string CompType { get; set; }

        [DBField("comp_sub_type")]
        public string CompSubType { get; set; }

        [DBField("dn_svc_no")]
        public string DnSvcNo { get; set; }

        [DBField("login_name")]
        public string LoginName { get; set; }

        [DBField("acc_code")]
        public string AccCode { get; set; }

        [DBField("acc_rating")]
        public string AccRating { get; set; }

        [DBField("conn_status")]
        public string ConnStatus { get; set; }

        [DBField("acc_category")]
        public string AccCategory { get; set; }

        [DBField("line_type")]
        public string LineType { get; set; }

        [DBField("line_usage")]
        public string LineUsage { get; set; }

        [DBField("last_month_bill")]
        public int LastMonthBill { get; set; }

        [DBField("user_code")]
        public string UserCode { get; set; }

        [DBField("address")]
        public string Address { get; set; }

        [DBField("city")]
        public string City { get; set; }

        [DBField("cust_remarks")]
        public string CustRemarks { get; set; }

        [DBField("contact_person")]
        public string ContactPerson { get; set; }

        [DBField("informed_by")]
        public string InformedBy { get; set; }

        [DBField("contact_no")]
        public string ContactNo { get; set; }

        [DBField("followup")]
        public string Followup { get; set; }

        [DBField("status")]
        public string Status { get; set; }

        [DBField("it_bstr")]
        public string ItBstr { get; set; }

        [DBField("logged_by")]
        public string LoggedBy { get; set; }

        [DBField("logged_on")]
        public DateTime LoggedOn { get; set; }

        [DBField("modified_by")]
        public string ModifiedBy { get; set; }

        [DBField("modified_on")]
        public DateTime ModifiedOn { get; set; }

        [DBField("attended_on")]
        public DateTime AttendedOn { get; set; }

        [DBField("completed_on")]
        public DateTime CompletedOn { get; set; }

        [DBField("note")]
        public string Note { get; set; }

        [DBField("ref_comp_id")]
        public string RefCompId { get; set; }

        [DBField("urgent_comp")]
        public string UrgentComp { get; set; }

        [DBField("system_type")]
        public string SystemType { get; set; }

        [DBField("email")]
        public string Email { get; set; }

        [DBField("directed")]
        public string Directed { get; set; }

        [DBField("info_to")]
        public string InfoTo { get; set; }

        [DBField("completed_by")]
        public string CompletedBy { get; set; }

        [DBField("hold_to")]
        public DateTime HoldTo { get; set; }

        [DBField("call_type")]
        public string CallType { get; set; }

        [DBField("fault_id")]
        public int FaultId { get; set; }

        [DBField("comp_section_id")]
        public string CompSectionId { get; set; }

        [DBField("rejected")]
        public string Rejected { get; set; }
    }
}
