using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class PnbsMenuRolesUsers
    {
        [DBField("role_name")]
        public string RoleName { get; set; }

        [DBField("pnbs_userid")]
        public string PnbsUserid { get; set; }

        [DBField("entered_on")]
        public DateTime EnteredOn { get; set; }

        [DBField("entered_by")]
        public string EnteredBy { get; set; }

        [DBField("deactivated_on")]
        public DateTime DeactivatedOn { get; set; }

        [DBField("deactivated_by")]
        public string DeactivatedBy { get; set; }
    }
}
