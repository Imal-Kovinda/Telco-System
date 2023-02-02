using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class CmCategoryTypeMaster
    {
        [DBField("code")]
        public string Code { get; set; }

        [DBField("description")]
        public string Description { get; set; }

        [DBField("status")]
        public string Status { get; set; }

        [DBField("added_by")]
        public string AddedBy { get; set; }

        [DBField("added_on")]
        public DateTime AddedOn { get; set; }

        [DBField("system_type")]
        public string SystemType { get; set; }
    }
}
