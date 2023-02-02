using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class PaymentType
    {
        [DBField("ledger_cd")]
        public string ledgerCd { get; set; }

        [DBField("ledger_acct")]
        public string ledgerAcc { get; set; }

        [DBField("valid_until")]
        public DateTime validUntil { get; set; }

        [DBField("qr_allow")]
        public string qrAllow { get; set; }

        [DBField("cheque_allowed")]
        public string chequeAllow { get; set; }

        [DBField("cc_allowed")]
        public string ccAllow { get; set; }

        [DBField("payment_type_id")]
        public string payTypeId { get; set; }

        [DBField("payment_type_name")]
        public string payTypeName { get; set; }

        [DBField("company_id")]
        public string companyId { get; set; }



    }
}
