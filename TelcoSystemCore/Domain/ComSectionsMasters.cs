using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class ComSectionsMasters
    {
        [DBField("section_id")]
        public string SectionId { get; set; }

        [DBField("section_name")]
        public string SectionName { get; set; }

        [DBField("created_by")]
        public string CreatedBy { get; set; }

        [DBField("created_on")]
        public DateTime CreatedOn { get; set; }

        [DBField("valid_until")]
        public string ValidUntil { get; set; }

        [DBField("parent_sec")]
        public string ParentSec { get; set; }
    }
}
