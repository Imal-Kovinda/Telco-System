using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class CmComplainSubTypeMaster
    {
        [DBField("code")]
        public string Code { get; set; }

        [DBField("description")]
        public string Description { get; set; }

        [DBField("status")]
        public string Status { get; set; }

        [DBField("com_type")]
        public string ComType { get; set; }

        [DBField("modified_by")]
        public string CustomerId { get; set; }

        [DBField("modified_on")]
        public DateTime ModifiedOn { get; set; }

        [DBField("system_type")]
        public string SystemType { get; set; }

        [DBField("sec_id")]
        public string SecId { get; set; }

        [DBField("email_sms")]
        public string EmailSms { get; set; }

        [DBField("remarks")]
        public string Remarks { get; set; }

        [DBField("sub_sec_flag")]
        public string SubSecFlag { get; set; }
    }
}
