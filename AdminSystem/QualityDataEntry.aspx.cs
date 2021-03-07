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
        QualityControl.ProductName = txtProductName.Text;
        Session["QualityControl"] = QualityControl;
        //navigate to viewer page
        Response.Redirect("QualityViewer.aspx");
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