using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable]
    public class PaymentMode
    {
        [DBField("LEDGER_CD")]
        public string ledgerCd { get; set; }

        [DBField("LEDGER_ACCT")]
        public string ledgerAcc { get; set; }

        [DBField("INTRODUCED_BY ")]
        public string introducedBy { get; set; }

        [DBField("INTRODUCED_ON ")]
        public DateTime introducedOn { get; set; }

        [DBField("PAYMENT_MODE_ID ")]
        public string payModeId { get; set; }

        [DBField("PAYMENT_MODE_NAME ")]
        public string payModeName { get; set; }
    }
}
