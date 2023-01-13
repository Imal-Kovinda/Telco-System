using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class CmComplainTypeMaster
    {
        [DBField("code")]
        public String Code { get; set; }

        [DBField("description")]
        public String Description { get; set; }

        [DBField("status")]
        public String Status { get; set; }

        [DBField("modified_by")]
        public String ModifiedBy { get; set; }

        [DBField("modified_on")]
        public DateTime ModifiedOn { get; set; }

        [DBField("system_type")]
        public String SystemType { get; set; }

        [DBField("cat_type")]
        public String CatType { get; set; }

    }
}
