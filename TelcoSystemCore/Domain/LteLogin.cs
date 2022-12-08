using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    public class LteLogin
    {
        [DBField("MSIDN")]
        public string MSIDN { get; set; }

        [DBField("USERNAME")]
        public string UserName { get; set; }

        [DBField("PASSWORD")]
        public string Password { get; set; }

        [DBField("LAST_LOGIN")]
        public DateTime LastLogin { get; set; }

        [DBField("DONE_ON")]
        public DateTime DoneOn { get; set; }

        [DBField("DONE_BY")]
        public string DoneBy { get; set; }

        [DBField("PREPAID")]
        public string Prepaid { get; set; }

        [DBField("INITIAL_PASSWORD")]
        public string InitialPassword { get; set; }

        [DBField("DEACTIVATED_BY")]
        public string DeactivatedBy { get; set; }

        [DBField("DEACTIVATED_ON")]
        public DateTime DeactivatedOn { get; set; }

        [DBField("USER_CODE")]
        public string UserCode { get; set; }
    }
}
