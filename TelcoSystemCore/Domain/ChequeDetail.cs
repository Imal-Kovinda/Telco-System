using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class ChequeDetail
    {
        [DBField("TRANSACTION_ID")]
        public int TransactionId { get; set; }

        [DBField("RECEIPT_ID")]
        public int ReceiptId { get; set; }

        [DBField("CHEQUE_NO")]
        public int ChequeNo { get; set; }

        [DBField("CHEQUE_DATE")]
        public int ChequeDate { get; set; }

        [DBField("BANK_CD")]
        public int BankCd { get; set; }

        [DBField("BRANCH_NAME")]
        public int BranchName { get; set; }

        [DBField("RECEIVED_DOC_CATEG")]
        public int ReceivedDocCateg { get; set; }

        [DBField("RECEIVED_DOC_NO")]
        public int ReceivedDocNo { get; set; }
    }
}
