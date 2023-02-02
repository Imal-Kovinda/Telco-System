using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable]
    public class Document
    {
        public string accountId { get; set; }

        public int amount { get; set; }

        [DBField("document_category")]
        public string code { get; set; }

        public string batchNo { get; set; }
    }
}
