using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class AdditionalDataPackRequest
    {
        [DBField("request_id")]
        public string RequestId { get; set; }

        [DBField("request_date")]
        public DateTime RequestDate { get; set; }

        [DBField("account_dn_id")]
        public string AccountDnId { get; set; }

        [DBField("request_type_id")]
        public string RequestTypeId { get; set; }

        [DBField("pack_size")]
        public int PackSize { get; set; }

        [DBField("switched_work_done")]
        public string SwitchedWork { get; set; }

        [DBField("directory_number")]
        public string DirectoryNumber { get; set; }

        [DBField("user_code")]
        public string UserCode { get; set; }

        [DBField("subscribed_on")]
        public DateTime SubscribedOn { get; set; }

        [DBField("subscribed_by")]
        public string SubscribedBy { get; set; }

        [DBField("modified_by")]
        public string ModifiedBy { get; set; }

        [DBField("modified_on")]
        public DateTime ModifiedOn { get; set; }

        [DBField("feature_code")]
        public string FeatureCode { get; set; }

        [DBField("feature_type")]
        public string FeatureType { get; set; }

        [DBField("seq_num")]
        public int SeqNum { get; set; }

        [DBField("sw_done_on")]
        public DateTime SwDoneOn { get; set; }

        [DBField("sw_remarks")]
        public string SwRemarks { get; set; }

        [DBField("bill_start_date")]
        public DateTime BillStartDate { get; set; }



    }
}
