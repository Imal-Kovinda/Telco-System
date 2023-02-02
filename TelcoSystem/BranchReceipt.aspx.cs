using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Common;
using TelcoSystemCore.Controller;
using TelcoSystemCore.Domain;
using System.Data.Odbc;
using System.Web.Services.Description;
using System.Data.Common;

namespace TelcoSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        List<CustomerAccount> ListCustomerAccount = new List<CustomerAccount>();
        List<PaymentType> ListPaymentType = new List<PaymentType>();
        List<ReceiptDetails> ListReceiptDetails = new List<ReceiptDetails>();
        public static string text;

        IPaymentTypeController paymentTypeController = ControllerFactory.CreatePaymentTypeController();
        ICustomerAccountController customerAccountController = ControllerFactory.CreateCustomerAccountController();
        IReceiptDetailsController receiptDetailsController = ControllerFactory.CreateReceiptDetailsController();

        CustomerAccount customerAccount = new CustomerAccount();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPaymentType();
            }
            txtSubName.Text = text;

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {

            CustomerAccount customerAccount = new CustomerAccount();

            customerAccount.accountId = txtAccCode.Text;
            customerAccount.mobileNumber = txtDN.Text;
            customerAccount.cusId = txtNIC.Text;
            customerAccount.accountName = txtAccName.Text;

            //ListCustomerAccount.Add(customerAccount);

            //ViewState["ListCustomerAccount"] = ListCustomerAccount;
            //gvCustomerAccount.DataSource = ListCustomerAccount;
            //gvCustomerAccount.DataBind();

        }

        private void Clear()
        {

            //txtCategory.Text = string.Empty;
            ////txtDate.Text = string.Empty;
            //txtReceiptNo.Text = string.Empty;
            txtTotal.Text = string.Empty;

            txtDN.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtAccCode.Text = string.Empty;
            txtSubName.Text = string.Empty;
            txtAccName.Text = string.Empty;
            txtAmount.Text = string.Empty;
        }

        protected void txtAccCode_TextChanged(object sender, EventArgs e)
        {
            if (txtAccCode.Text != "")
            {
                customerAccount = customerAccountController.GetCustomerAccount(txtAccCode.Text);
                if (customerAccount.accountId != "" || customerAccount.accountId != null)
                {
                    txtAccName.Text = customerAccount.accountName;
                    txtDN.Text = customerAccount.mobileNumber;
                    txtNIC.Text = customerAccount.cusId;

                }
            }

        }



        protected void ddllpaymentTypeId_SelectedValueChanged(object sender, EventArgs e)
        {
            text = ddlpaytypeid.SelectedValue;
            txtSubName.Text = text;

        }

        protected void BindPaymentType()
        {
            IPaymentTypeController paymentTypeController = ControllerFactory.CreatePaymentTypeController();
            List<PaymentType> paymentTypes = paymentTypeController.GetPaymentTypes();
            ddlpaytypeid.DataSource = paymentTypes;
            ddlpaytypeid.DataValueField = "payTypeName";
            ddlpaytypeid.DataTextField = "payTypeId";
            ddlpaytypeid.DataBind();

            //txtSubName.Text = "TEXT";
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            string receiptNumber = string.Empty;

            ReceiptDetails receiptDetails = new ReceiptDetails();

            receiptDetails.category = txtCategory.Text;
            receiptDetails.accountId = txtAccCode.Text;
            receiptDetails.payTypeId = ddlpaytypeid.SelectedValue;
            receiptDetails.amount = txtAmount.Text;


            receiptDetailsController.Save(receiptDetails);

            Clear();

            ListReceiptDetails.Add(receiptDetails);

            ViewState["ListReceiptDetails"] = ListReceiptDetails;
            gvReceiptDetails.DataSource = ListReceiptDetails;
            gvReceiptDetails.DataBind();

            txtReceiptNo.Text = receiptNumber;

        }


    }


}
