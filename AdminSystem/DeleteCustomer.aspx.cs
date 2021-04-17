using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 ProductNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(ProductNo);
        CustomerBook.Delete();
        Response.Redirect("CustomerList.aspx");
    }
}