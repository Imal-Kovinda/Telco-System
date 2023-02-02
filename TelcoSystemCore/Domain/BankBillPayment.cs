using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelcoSystemCore.Domain
{
    public class BankBillPayment
    {
        public string AccountCode { get; set; }

        public decimal Amount { get; set; }

        public string DocumentCategory { get; set; }

        public string PaymentType { get; set; }

        public int DocumentNo { get; set; }

        public string ErrorMessage { get; set; }

    }
}
