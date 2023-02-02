using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class ComplainRemarks
    {
        [DBField("remark_id")]
        public string RemarkId { get; set; }

        [DBField("seq_id")]
        public string SeqId { get; set; }

        [DBField("comp_id")]
        public string CompId { get; set; }

        //place to inform
        [DBField("section_id")]
        public string SectionId { get; set; }

        [DBField("re_info_date")]
        public DateTime ReInfoDate { get; set; }


        [DBField("my_remarks")]
        public string MyRemarks { get; set; }

        [DBField("user_code")]
        public string UserCode { get; set; }

    }
}
