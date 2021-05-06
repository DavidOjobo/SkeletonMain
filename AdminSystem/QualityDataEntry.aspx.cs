using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsQuality QualityControl = new clsQuality();
        string ProductName = txtProductName.Text;
        string ProductNo = txtProductNo.Text;
        //capture the StaffID
        string StaffID = txtStaffID.Text;
        //capture the Batch number
        string BatchNo = txtBatchNo.Text;
        string Grade = txtGrade.Text;
        string Date = txtDate.Text;
        // varlable to store any error messages
        string Error = "";
        //validate the data
        Error = QualityControl.Valid(ProductNo, ProductName, StaffID, BatchNo, Grade, Date);
        if (Error == "")
        {
            QualityControl.ProductName = txtProductName.Text;
            QualityControl.StaffID = Convert.ToInt32(txtStaffID.Text);
            QualityControl.BatchNo = Convert.ToInt32(txtBatchNo.Text);
            QualityControl.Grade = Convert.ToChar(txtGrade.Text);
            QualityControl.Date = Convert.ToDateTime(txtDate.Text);
            QualityControl.Defective = chkDefective.Checked;
            QualityControl.ProductName = txtProductName.Text;
            clsQualityCollection ProductList = new clsQualityCollection();
            ProductList.ThisProduct = QualityControl;
            ProductList.Add();

            //navigate to viewer page
            Response.Redirect("QualityList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsQuality QualityControl = new clsQuality();
        Int32 ProductNo;
        Boolean Found = false;
        ProductNo = Convert.ToInt32(txtProductNo.Text);
        Found = QualityControl.Find(ProductNo);
        if (Found == true)
        {
            txtStaffID.Text = QualityControl.StaffID.ToString();
            txtBatchNo.Text = QualityControl.BatchNo.ToString();
            txtGrade.Text = QualityControl.Grade.ToString();
            txtDate.Text = QualityControl.Date.ToString();
            txtProductName.Text = QualityControl.ProductName;
        }
    }
}