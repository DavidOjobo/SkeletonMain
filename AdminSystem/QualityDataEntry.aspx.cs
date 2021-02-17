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
        QualityControl.ProductNo = txtProductNo.Text;
        Session["QualityControl"] = QualityControl;
        //navigate to viewer page
        Response.Redirect("QualityViewer.aspx");
    }
}