using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class Customer
    {
        [DBField("ID")]
        public int CustomerID { get; set; }

        [DBField("Name")]
        public string CustomerName { get; set; }

        [DBField("Email")]
        public string CusEmail { get; set; }

        [DBField("Address")]
        public string AccAddress { get; set; }

        [DBField("City")]
        public string City { get; set; }

        [DBField("Contact_No")]
        public string ContactNo { get; set; }


        public int LineUsage { get; set; }
        public int TotalAmount { get; set; }
        public int FYRating { get; set; }

        [DBField("NIC")]
        public string CusNIC { get; set; }


    }
}
