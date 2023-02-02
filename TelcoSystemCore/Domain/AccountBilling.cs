using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{

    [Serializable()]
    public class AccountBilling
    {
        [DBField("BILLING_ID")]
        public string billingId { get; set; }

        [DBField("ACCOUNT_ID")]
        public string accountId { get; set; }

        [DBField("BILL_YEAR")]
        public int billYear { get; set; }

        [DBField("BILL_MONTH")]
        public int billMonth { get; set; }

        [DBField("BILL_DATE")]
        public DateTime billDate { get; set; }

        [DBField("BILL_AMOUNT_MONTH")]
        public int billamountMonth { get; set; }

        [DBField("BILL_AMOUNT_PREVIOUS")]
        public int billamountPrevious { get; set; }

        [DBField("BILL_TOTAL_AMOUNT")]
        public int billtotalAmount { get; set; }

        [DBField("PAID_AMOUNT")]
        public int paidAmount { get; set; }

        [DBField("BALANCE_AMOUNT")]
        public int balanceAmount { get; set; }


    }
}
