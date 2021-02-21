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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock aStock = new clsStock();
        aStock.ProductNo = txtProductNo.Text;
        //navigate to the viewers' page
        Response.Redirect("StockViewer.aspx");
    }
}

public class clsStock
{
    public clsStock()
    {
    }

    public object ProductNo { get; internal set; }
}