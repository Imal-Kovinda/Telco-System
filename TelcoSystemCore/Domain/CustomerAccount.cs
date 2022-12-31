using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class CustomerAccount
    {
        [DBField("account_id")]
        public string AccountId { get; set; }

        [DBField("account_name")]
        public string AccountName { get; set; }

        [DBField("customer_id")]
        public string CustomerId { get; set; }

        [DBField("priority_id")]
        public string PriorityId { get; set; }

        [DBField("company_id")]
        public string CompanyId { get; set; }

        [DBField("current_balance")]
        public double CurrentBalance { get; set; }

        [DBField("connect_status_id")]
        public string ConnectStatusId { get; set; }

        [DBField("cr_credit_rating_code")]
        public string CrCreditRatingCode { get; set; }

        [DBField("ac_account_category")]
        public string AcAccountCategory { get; set; }

        [DBField("title")]
        public string Title { get; set; }

        [DBField("address_line_1")]
        public string AddressLine1 { get; set; }

        [DBField("address_line_2")]
        public string AddressLine2 { get; set; }

        [DBField("address_line_3")]
        public string AddressLine3 { get; set; }

        [DBField("city")]
        public string City { get; set; }

        [DBField("postal_code")]
        public string PostalCode { get; set; }

        [DBField("introduced_by")]
        public string IntroducedBy { get; set; }

        [DBField("introduced_on")]
        public DateTime IntroducedOn { get; set; }

        [DBField("last_modified_by")]
        public string LastModifiedBy { get; set; }

        [DBField("last_modified_on")]
        public DateTime LastModifiedOn { get; set; }

        [DBField("bill_run_code")]
        public double BillRunCode { get; set; }

        [DBField("deactivated_by")]
        public string DeactivatedBy { get; set; }

        [DBField("deactivated_on")]
        public DateTime DeactivatedOn { get; set; }

        [DBField("ledger_cd")]
        public string LedgerCd { get; set; }

        [DBField("acct_type")]
        public string Acct_Type { get; set; }

        [DBField("opening_balance")]
        public double OpeningBalance { get; set; }

        [DBField("control_account")]
        public string ControlAccount { get; set; }

        [DBField("bill_run_stat")]
        public string BillRunStat { get; set; }

        [DBField("team_no")]
        public int TeamNo { get; set; }

        [DBField("sales_person")]
        public string SalesPerson { get; set; }

        [DBField("collector")]
        public string Collector { get; set; }

        [DBField("province")]
        public string Province { get; set; }

        [DBField("district")]
        public string District { get; set; }

        [DBField("priority_val")]
        public int PriorityVal { get; set; }

        [DBField("major_industry")]
        public string MajorIndustry { get; set; }

        [DBField("minor_industry")]
        public string MinorIndustry { get; set; }

        [DBField("prv_ac_account_category")]
        public string PrvAcAccountCategory { get; set; }

        [DBField("cus_comment_checked")]
        public string CusCommentChecked { get; set; }

        [DBField("confidential")]
        public string Confidential { get; set; }

        [DBField("status_changed_on")]
        public DateTime StatusChangedOn { get; set; }

        [DBField("discon_avoid_date")]
        public DateTime DisconAvoidDate { get; set; }

        [DBField("top_customer_stat")]
        public string TopcustomerStat { get; set; }

        [DBField("reminder_pd")]
        public string ReminderPd { get; set; }

        [DBField("rental_category")]
        public string RentalCategory { get; set; }

        [DBField("pre_paid")]
        public string PrePaid { get; set; }

        [DBField("switch_type")]
        public string SwitchType { get; set; }

        [DBField("credit_limit")]
        public int CreditLimit { get; set; }

        [DBField("disconnect_stat")]
        public string DisconnectStat { get; set; }

        [DBField("stat_after_days")]
        public string StatAfterDays { get; set; }

        [DBField("grace_period")]
        public DateTime GracePeriod { get; set; }

        [DBField("allocated_sales_person")]
        public string AllocatedSalesPersona { get; set; }

        [DBField("revenue_region")]
        public string RevenueRegion { get; set; }

        [DBField("email")]
        public string Email { get; set; }

        [DBField("indirect_br")]
        public string IndirectBr { get; set; }

        [DBField("mobile_number")]
        public string MobileNumber { get; set; }

        [DBField("policy_apply_date")]
        public DateTime PosicyApplyDate { get; set; }

        [DBField("customer_type_id")]
        public string CustomerTypeId { get; set; }
    }
}
