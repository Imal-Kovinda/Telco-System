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
        public String CompId { get; set; }

        [DBField("txn_date")]
        public DateTime TxnDate { get; set; }

        [DBField("cust_name")]
        public String CustName { get; set; }

        [DBField("comp_cat_code")]
        public String CompCatCode { get; set; }

        [DBField("comp_type")]
        public String CompType { get; set; }

        [DBField("comp_sub_type")]
        public String CompSubType { get; set; }

        [DBField("dn_svc_no")]
        public String DnSvcNo { get; set; }

        [DBField("login_name")]
        public String LoginName { get; set; }

        [DBField("acc_code")]
        public String AccCode { get; set; }

        [DBField("acc_rating")]
        public String AccRating { get; set; }

        [DBField("conn_status")]
        public String ConnStatus { get; set; }

        [DBField("acc_category")]
        public String AccCategory { get; set; }

        [DBField("line_type")]
        public String LineType { get; set; }

        [DBField("line_usage")]
        public String LineUsage { get; set; }

        [DBField("last_month_bill")]
        public int LastMonthBill { get; set; }

        [DBField("user_code")]
        public String UserCode { get; set; }

        [DBField("address")]
        public String Address { get; set; }

        [DBField("city")]
        public String City { get; set; }

        [DBField("cust_remarks")]
        public String CustRemarks { get; set; }

        [DBField("contact_person")]
        public String ContactPerson { get; set; }

        [DBField("informed_by")]
        public String InformedBy { get; set; }

        [DBField("contact_no")]
        public String ContactNo { get; set; }

        [DBField("followup")]
        public String Followup { get; set; }

        [DBField("status")]
        public String Status { get; set; }

        [DBField("it_bstr")]
        public String ItBstr { get; set; }

        [DBField("logged_by")]
        public String LoggedBy { get; set; }

        [DBField("logged_on")]
        public DateTime LoggedOn { get; set; }

        [DBField("modified_by")]
        public String ModifiedBy { get; set; }

        [DBField("modified_on")]
        public DateTime ModifiedOn { get; set; }

        [DBField("attended_on")]
        public DateTime AttendedOn { get; set; }

        [DBField("completed_on")]
        public DateTime CompletedOn { get; set; }

        [DBField("note")]
        public string Note { get; set; }

        [DBField("ref_comp_id")]
        public String RefCompId { get; set; }

        [DBField("urgent_comp")]
        public String UrgentComp { get; set; }

        [DBField("system_type")]
        public String SystemType { get; set; }

        [DBField("email")]
        public String Email { get; set; }

        [DBField("directed")]
        public String Directed { get; set; }

        [DBField("info_to")]
        public String InfoTo { get; set; }

        [DBField("completed_by")]
        public String CompletedBy { get; set; }

        [DBField("hold_to")]
        public DateTime HoldTo { get; set; }

        [DBField("call_type")]
        public String CallType { get; set; }

        [DBField("fault_id")]
        public int FaultId { get; set; }

        [DBField("comp_section_id")]
        public String CompSectionId { get; set; }

        [DBField("rejected")]
        public String Rejected { get; set; }
    }
}
