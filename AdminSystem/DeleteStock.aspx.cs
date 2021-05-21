using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteStock : System.Web.UI.Page
{
    Int32 ProductNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection ProductList = new clsStockCollection();
        ProductList.ThisProduct.Find(ProductNo);
        ProductList.Delete();
        Response.Redirect("StockList.aspx");

    }
}