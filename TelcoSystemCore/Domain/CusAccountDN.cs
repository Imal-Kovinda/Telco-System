using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable]
    public class CusAccountDN
    {
        [DBField("ACCOUNT_DN_ID")]
        public int accountDNId { get; set; }

        [DBField("ACCOUNT_DN ")]
        public string accountDN { get; set; }

        [DBField("ACCOUNT_ID ")]
        public string accountId { get; set;}

        [DBField("ACCOUNT_LOCATION_ID ")]
        public string accLocationId { get; set; }

        [DBField("CONNECT_STATUS_ID ")]
        public string connectstatId { get; set; }

        [DBField("VALID_UNTIL ")]
        public DateTime validUntil { get; set; }

        [DBField("ESN_EMI_NO ")]
        public string esnEmiNo { get; set; }

        [DBField("MSISDN_NO ")]
        public string msisdnNo { get; set; }

        [DBField("IMSI_NO ")]
        public string imsiNo { get; set; }

        [DBField("ACTIVATED_ON ")]
        public DateTime activatedOn { get; set; }

        [DBField("ACTIVATED_BY ")]
        public string activatedBy { get; set; }

        [DBField("DEACTIVATED_ON ")]
        public DateTime deactivatedOn { get; set; }

        [DBField("DEACTIVATED_BY ")]
        public string deactivatedBy { get; set;}

        [DBField("EFFECTIVE_DATE ")]
        public DateTime effectiveDate { get; set; }

        [DBField("DISTRICT ")]
        public string district { get; set; }

        [DBField("PROVINCE ")]
        public string province { get; set; }

        [DBField("SEQUENCE_NUMBER ")]
        public int seqNum { get; set; }

        [DBField("OD_LINE_USAGE ")]
        public string odLineUsage { get; set; }

        [DBField("LINE_TYPE ")]
        public string lineType { get; set; }

        [DBField("FIRST_BILL_DATE ")]
        public DateTime firstBillDate { get; set; }

        [DBField("LAST_BILL_DATE ")]
        public DateTime lastBillDate { get; set;}

        [DBField("SWITCH_TYPE ")]
        public string switchType { get; set; }

        [DBField("CHARGE_PLAN_CODE ")]
        public string chargePlanCode { get; set; }

        [DBField("CPC_EFFECTIVE_DATE ")]
        public DateTime cpcEffectiveDate { get; set; }

        [DBField("SALES_PERSON ")]
        public string salesPerson { get; set; }

        [DBField("IP_ADDRESS ")]
        public string ipAddress { get; set; }

        [DBField("RTU_CPE_NUMBER ")]
        public string rtuCpeNumber { get; set; }

        [DBField("NO_OF_PORTS ")]
        public int noOfPorts { get; set; }

        [DBField("SIP_PASSWORD ")]
        public string sipPassword { get; set; }

        [DBField("SIP_ORDER_TYPE")]
        public int sipOrderType { get; set; }

        [DBField("SIP_PORT ")]
        public int sipPort { get; set; }

        [DBField("MAC_ADDRESS ")]
        public string macAddress { get; set; }

        [DBField("CUSTOMER_PREMISES_IP ")]
        public string cusPremisesIp { get; set; }

        [DBField("SIGNALING_IP ")]
        public string signaligIp { get; set; }

        [DBField("MEDIA_IP ")]
        public string mediaIp { get; set; }

        [DBField("TERMINAL_ID ")]
        public int terminalId { get; set; }

        [DBField("TRUNK_ID ")]
        public string trunkId { get; set; }

        [DBField("SWITCH_ID ")]
        public int switchId { get; set; }

        [DBField("FIBER_OPERATOR ")]
        public string fiberOperator { get; set; }

        [DBField("CCT_ID ")]
        public string cctId { get; set; }

        [DBField("BANDWIDTH ")]
        public int bandwidth { get; set; }

        [DBField("COMMISSION_DATE ")]
        public DateTime commissionDate { get; set; }

        [DBField("AIRGRID ")]
        public string airgrid { get; set; }
    }
}
