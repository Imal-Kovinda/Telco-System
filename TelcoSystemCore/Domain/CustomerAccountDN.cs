using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class CustomerAccountDN
    {
        [DBField("ACCOUNT_DN_ID")]
        public int AccountDnId { get; set; }

        [DBField("ACCOUNT_DN")]
        public int AccountDn { get; set; }

        [DBField("ACCOUNT_ID")]
        public int ACCOUNT_ID { get; set; }

        [DBField("ACCOUNT_LOCATION_ID")]
        public int AccountLocationId { get; set; }

        [DBField("CONNECT_STATUS_ID")]
        public int ConnectStatusId { get; set; }

        [DBField("VALID_UNTIL")]
        public int ValidUntil { get; set; }

        [DBField("ESN_EMI_NO")]
        public int EsnEmiNo { get; set; }

        [DBField("MSISDN_NO")]
        public int MsisdnNo { get; set; }

        [DBField("IMSI_NO")]
        public int ImsiNo { get; set; }

        [DBField("ACTIVATED_ON")]
        public int ActivatedOn { get; set; }

        [DBField("ACTIVATED_BY")]
        public int ActivatedBy { get; set; }

        [DBField("DEACTIVATED_ON")]
        public int DeactivatedOn { get; set; }

        [DBField("DEACTIVATED_BY")]
        public int DeactivatedBy { get; set; }

        [DBField("EFFECTIVE_DATE ")]
        public int EffectiveDate { get; set; }

        [DBField("DISTRICT")]
        public int District { get; set; }

        [DBField("PROVINCE")]
        public int Province { get; set; }


        [DBField("SEQUENCE_NUMBER ")]
        public int SequenceNumber { get; set; }

        [DBField("OD_LINE_USAGE")]
        public int OdLineUsage { get; set; }

        [DBField("LINE_TYPE")]
        public int LineType { get; set; }

        [DBField("FIRST_BILL_DATE")]
        public int FirstBIllDate { get; set; }

        [DBField("LAST_BILL_DATE")]
        public int LastBillDate { get; set; }

        [DBField("SWITCH_TYPE")]
        public int SwitchType { get; set; }

        [DBField("CHARGE_PLAN_CODE")]
        public int ChangePlanCode { get; set; }

        [DBField("CPC_EFFECTIVE_DATE")]
        public int CpcEffectiveDate { get; set; }

        [DBField("SALES_PERSON")]
        public int SalesPerson { get; set; }

        [DBField("IP_ADDRESS")]
        public int IpAddress { get; set; }

        [DBField("RTU_CPE_NUMBER")]
        public int RtuCpeNumber { get; set; }

        [DBField("NO_OF_PORTS")]
        public int NoOfPorts { get; set; }

        [DBField("SIP_PASSWORD")]
        public int SipPassword { get; set; }

        [DBField("SIP_ORDER_TYPE ")]
        public int SipOrderType { get; set; }

        [DBField("SIP_PORT")]
        public int SipPort { get; set; }

        [DBField("MAC_ADDRESS")]
        public int MacAddress { get; set; }

        [DBField("CUSTOMER_PREMISES_IP")]
        public int CustomerPremisesIp { get; set; }

        [DBField("SIGNALING_IP")]
        public int SignalingIp { get; set; }

        [DBField("MEDIA_IP")]
        public int MediaIp { get; set; }

        [DBField("TERMINAL_ID")]
        public int TerminalId { get; set; }

        [DBField("TRUNK_ID")]
        public int TrunkId { get; set; }

        [DBField("SWITCH_ID")]
        public int SwitchId { get; set; }

        [DBField("FIBER_OPERATOR")]
        public int FiberOperator { get; set; }

        [DBField("CCT_ID")]
        public int CctId { get; set; }

        [DBField("BANDWIDTH ")]
        public int Bandwidth { get; set; }

        [DBField("COMMISSION_DATE")]
        public int CommissionDate { get; set; }

        [DBField("AIRGRID")]
        public int Airgrid { get; set; }
    }
}
