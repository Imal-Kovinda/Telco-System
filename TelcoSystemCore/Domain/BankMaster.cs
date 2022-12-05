using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class BankMaster
    {
        [DBField("BANK_CODE")]
        public String Bankode { get; set; }

        [DBField("BANK_NAME")]
        public String BankName { get; set; }

        [DBField("INTRODUCED_BY")]
        public String IntroducedBy { get; set; }

        [DBField("INTRODUCED_ON")]
        public String IntroducedOn { get; set; }

        [DBField("CREDIT_CARD_ACCOUNT")]
        public String CreditCardAccount { get; set; }

        [DBField("MCASH_CODE")]
        public String MCashCode { get; set; }


    }
}
