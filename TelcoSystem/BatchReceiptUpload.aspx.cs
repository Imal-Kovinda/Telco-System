using System;
using System.Collections.Generic;
using System.Data;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Win32;
using System.Windows.Forms;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using Microsoft.Ajax.Utilities;
using TelcoSystemCore.Common;
using TelcoSystemCore.Controller;
using TelcoSystemCore.Domain;
using DocumentFormat.OpenXml.Drawing.Charts;
using DataTable = System.Data.DataTable;

namespace TelcoSystem
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ICustomerAccountController customerAccountController = ControllerFactory.CreateCustomerAccountController();
        IReceiptUploadController receiptUploadController = ControllerFactory.CreateReceiptUploadController();
        IDocumentCategoryController documentCategoryController = ControllerFactory.CretaeDocumentCategoryController();

        List<ReceiptUpload> ListReceiptUpload = new List<ReceiptUpload>();
        List<CustomerAccount> customerAccounts = new List<CustomerAccount>();
        List<Document> listCategory = new List<Document>();

        static List<Document> csvDocument = new List<Document>();
        protected void Page_Load(object sender, EventArgs e)
        {

            customerAccounts = customerAccountController.GetCustomerAccounts();
            listCategory = documentCategoryController.GetDocCategory();
        }

        private System.Windows.Forms.OpenFileDialog openFileDialog1;



        protected void BrowseButton_Click(object sender, EventArgs e)
        {

            if (FileUpload1.PostedFile != null)
            {
                HttpFileCollection uploadFiles = Request.Files;
                for (int i = 0; i < uploadFiles.Count; i++)
                {
                    HttpPostedFile uploadFile = uploadFiles[i];
                    if (uploadFile.ContentLength > 0)
                    {

                        uploadFile.SaveAs(Server.MapPath("~/Files/") + uploadFile.FileName);


                    }
                }


            }


            //Upload and save the file
            string csvPath = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(csvPath);

            //Read the contents of CSV file.
            string csvData = File.ReadAllText(csvPath);

            //Execute a loop over the rows.
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {

                    int i = 0;

                    var rowData = row.Split(',');
                    Document document = new Document();
                    document.accountId = rowData[i++];
                    document.amount = Convert.ToInt32(rowData[i++]);
                    document.code = rowData[i++];
                    document.batchNo = rowData[i++];
                    csvDocument.Add(document);

                }
            }

            //Bind the DataTable.
            ViewState["csv"] = csvDocument;
            GridView1.DataSource = csvDocument;
            GridView1.DataBind();

        }


        protected void btnUpload_Click(object sender, EventArgs e)
        {

            CustomerAccount customerAccount = new CustomerAccount();
            List<Document> documents = new List<Document>();

            csvDocument = (List<Document>)ViewState["csv"];
            documents = csvDocument;

            //csvDocument = csvDocument.Where(x => customerAccounts.Any(y => y.accountId == x.accountId)).ToList();
            //.where(document_category)
            csvDocument = csvDocument.Where(x => customerAccounts.Any(y => y.accountId == x.accountId)).Where(x => listCategory.Any(y => y.accountId == x.accountId)).ToList();


            GridView2.DataSource = csvDocument;
            GridView2.DataBind();

            GridView1.DataSource = documents.Where(x => csvDocument.Any(y => x.accountId != y.accountId)).ToList();
            GridView1.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView2.Rows)
            {
                ReceiptUpload receiptUpload = new ReceiptUpload();


                receiptUpload.accountId = row.Cells[0].Text;
                receiptUpload.amount = Convert.ToInt32(row.Cells[1].Text);
                receiptUpload.code = row.Cells[2].Text;
                receiptUpload.batchNo = row.Cells[3].Text;

                receiptUploadController.Save(receiptUpload);

                ListReceiptUpload.Add(receiptUpload);

                ViewState["ListReceiptUpload"] = ListReceiptUpload;
                GridView2.DataSource = ListReceiptUpload;
                GridView2.DataBind();

                Label1.Text = "Records Inserted Successfully !";

            }
        }



    }
}