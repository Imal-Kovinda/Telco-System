using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class ReceiptMaster
    {
        [DBField("RECEIPT_ID")]
        public int ReceiptId { get; set; }

        [DBField("RECEIPT_DATE")]
        public int ReceiptDate { get; set; }

        [DBField("RECEIPT_NO")]
        public int ReceiptNo { get; set; }

        [DBField("BRANCH_ID")]
        public int BranchId { get; set; }

        [DBField("PAYMENT_MODE_ID")]
        public int PaymentModeId { get; set; }

        [DBField("LEDGER_CD")]
        public int LedgerCd { get; set; }

        [DBField("NARRATION")]
        public int Narration { get; set; }

        [DBField("ADDED_BY")]
        public int AddedBy { get; set; }

        [DBField("ADDED_ON")]
        public int AddedOn { get; set; }

        [DBField("STATUS_OF_RECEIPT")]
        public int StatusOfReceipt { get; set; }

        [DBField("POSTED")]
        public int Posted { get; set; }

        [DBField("SEQ_NO")]
        public int SeqNo { get; set; }

        [DBField("POSTED_CP")]
        public int PostedCp { get; set; }

        [DBField("BANK_CODE")]
        public int BankCode { get; set; }

        [DBField("BANKING_DATE")]
        public int BankingDate { get; set; }

        [DBField("MODIFIED_BY")]
        public int ModifiedBy { get; set; }

        [DBField("MODIFIED_ON")]
        public int ModifiedOn { get; set; }

        [DBField("CURRENCY_CODE")]
        public int CurrencyCode { get; set; }

        [DBField("PROVISIONARY_REC_NUMBER")]
        public int ProvisionaryRecNumber { get; set; }

        [DBField("EMAIL_SENT")]
        public int EmailSent { get; set; }

        [DBField("RECEIPT_CATEG")]
        public int ReceiptCateg { get; set; }

     
    }
}
