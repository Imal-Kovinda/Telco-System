using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class ReceiptDetail
    {
        [DBField("NARRATION")]
        public int Narration { get; set; }

        [DBField("SEQ_NO")]
        public int SeqNo { get; set; }

        [DBField("DEALER_INVOICE_ID")]
        public int DealerInvoiceId { get; set; }

        [DBField("IN_ACTIVATE_FLAG")]
        public int InActivateFlag { get; set; }

        [DBField("IN_ACTIVATE_ON")]
        public int InActivateOn { get; set; }

        [DBField("IN_ACTIVATE_BY")]
        public int InActivateBy { get; set; }

        [DBField("DETAIL_ID")]
        public int DetailId { get; set; }

        [DBField("RECEIPT_ID")]
        public int ReceiptId { get; set; }

        [DBField("ACCOUNT_ID")]
        public int AccountId { get; set; }

        [DBField("PAYMENT_TYPE_ID")]
        public int PaymentTypeId { get; set; }

        [DBField("AMOUNT")]
        public int Amount { get; set; }


    }
}
