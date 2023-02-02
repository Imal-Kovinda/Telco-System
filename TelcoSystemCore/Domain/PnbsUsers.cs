using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class PnbsUsers
    {
        [DBField("EMP_ID ")]
        public string empId { get; set; }

        [DBField("NAME ")]
        public string empNmae { get; set; }

        [DBField("PNBS_ID ")]
        public string pnbsId { get; set; }

        [DBField("NW_USERID")]
        public string nwUserid { get; set;}

        [DBField("LOCATION ")]
        public string location { get; set; }

        [DBField("NIC_ID")]
        public string nic { get; set; }

        [DBField("DEPARTMENT ")]
        public string department { get; set; }

        [DBField("DIVISION")]
        public string division { get; set; }

        [DBField("CREATED_ON")]
        public DateTime createdOn { get; set; }

        [DBField("CREATED_BY")]
        public string createdBy { get; set; }

        [DBField("DEACTIVATED_ON")]
        public DateTime deactivatedOn { get; set; }

        [DBField("DEACTIVATED_BY ")]
        public string deactivatedBy { get; set; }

        [DBField("CONTACT_NO")]
        public string contactNo { get; set; }

        [DBField("PASSWORD")]
        public string password { get; set; }

        [DBField("FIRST_LOGIN ")]
        public DateTime firstLogin { get; set; }

        [DBField("CURRENT_LOGIN")]
        public DateTime currentLogin { get; set; }

        [DBField("PREVIOUS_LOGIN")]
        public DateTime previousLogin { get; set; }

    }
}
