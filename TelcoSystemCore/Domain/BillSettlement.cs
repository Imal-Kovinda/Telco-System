using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class BillSettlement
    {
        [DBField("settlement_id")]
        public string SettlementId { get; set; }

        [DBField("account_id")]
        public string AccountId { get; set; }

        [DBField("billing_id")]
        public string BillingId { get; set; }

        [DBField("amount")]
        public string Amount { get; set; }
    }
}
