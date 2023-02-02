using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class AccountLocation
    {
        [DBField("account_location_id")]
        public string AccountLocationId { get; set; }

        [DBField("location_name")]
        public string LocationName { get; set; }

        [DBField("account_id")]
        public string AccountId { get; set; }

        [DBField("city")]
        public string City { get; set; }

        [DBField("activated_on")]
        public DateTime ActivatedOn { get; set; }

        [DBField("activated_by")]
        public string ActivatedBy { get; set; }

        [DBField("deactivated_on")]
        public DateTime DeactivatedOn { get; set; }

        [DBField("postal_code")]
        public string PostalCode { get; set; }

        [DBField("address_line_2")]
        public string AddressLine2 { get; set; }

        [DBField("address_line_3")]
        public string AddressLine3 { get; set; }

        [DBField("title")]
        public string Title { get; set; }

        [DBField("address_line_1")]
        public string AddressLine1 { get; set; }

        [DBField("deactivated_by")]
        public string DeactivatedBy { get; set; }

        [DBField("effective_date")]
        public DateTime EffectiveDate { get; set; }

        [DBField("location")]
        public string Location { get; set; }

        [DBField("district")]
        public string District { get; set; }

        [DBField("province")]
        public string Province { get; set; }

        [DBField("area")]
        public string Area { get; set; }

        [DBField("confidential")]
        public string Confidential { get; set; }

        [DBField("village")]
        public string Village { get; set; }

        [DBField("nearest_branch_code")]
        public string NearestBranchCode { get; set; }
    }
}
