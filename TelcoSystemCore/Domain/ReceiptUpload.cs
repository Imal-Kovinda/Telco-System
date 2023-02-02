using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{

    [Serializable]
    public class ReceiptUpload
    {
        [DBField("")]
        public string accountId { get; set; }

        [DBField("")]
        public int amount { get; set; }

        [DBField("")]
        public string code { get; set; }

        [DBField("")]
        public string batchNo { get; set; }

        [DBField("")]
        public string type { get; set; }

        [DBField("")]
        public string prepaid { get; set; }

        [DBField("")]
        public string addedOn { get; set; }

        [DBField("")]
        public string addedBy { get; set; }

        [DBField("")]
        public string postedOn { get; set; }

        [DBField("")]
        public string postedBy { get; set; }




    }
}
