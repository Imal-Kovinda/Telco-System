using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable]
    public class ReceiptDetails
    {
        [DBField("receipt_categ")]
        public string category { get; set; }

        [DBField("mobile_number")]
        public string mobileNumber { get; set; }

        [DBField("customer_id")]
        public string cusId { get; set; }

        [DBField("account_name")]
        public string accountName { get; set; }


        [DBField("doc_num")]
        public string receiptNo { get; set; }


        [DBField("payment_type_id")]
        public string payTypeId { get; set; }


        [DBField("payment_type_name")]
        public string payTypeName { get; set; }

        [DBField("user_id")]
        public string userId { get; set; }

        [DBField("err_msg")]
        public string errMsg { get; set; }

        [DBField("narration")]
        public string narration { get; set; }


        [DBField("account_id")]
        public string accountId { get; set; }


        [DBField("amount")]
        public string amount { get; set; }


    }
}
