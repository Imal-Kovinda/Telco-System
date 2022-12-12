using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class DirectoryNumbers
    {
        [DBField("RBS_RBS_CODE")]
        public int RbsRbsCode { get; set; }

        [DBField("SERVICE_NUMBER")]
        public int ServiceNumber { get; set; }

        [DBField("CATEGORY")]
        public int Category { get; set; }

        [DBField("AVAILABLE_FROM")]
        public int AvailableFrom { get; set; }

        [DBField("VALID_UNTIL")]
        public int ValidUntil { get; set; }

        [DBField("DC_DN_CATEGORY_CODE")]
        public int DcDnCategoryCode { get; set; }

        [DBField("DN_STATUS")]
        public int DnStatus { get; set; }

        [DBField("GENERATED_BY")]
        public int GeneratedBy { get; set; }

        [DBField("CA_AREA_CODE")]
        public int CaAreaCode { get; set; }

        [DBField("VANITY_TYPE")]
        public int VanityType { get; set; }

        [DBField("SWITCH_TYPE")]
        public int SwitchType { get; set; }

        [DBField("PRE_PAID")]
        public int PrePaid { get; set; }

        [DBField("UNIT_ASSIGN")]
        public int UnitAssign { get; set; }

        [DBField("OG_FREE_MINUTES")]
        public int OgFreeMinutes { get; set; }

        [DBField("SWITCH_ID")]
        public int SwitchId { get; set; }
    }
}
