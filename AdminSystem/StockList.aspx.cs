using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack ==  true)
        {
            DisplayStock();
        }

    }
    void DisplayStock()
    {
        ClassLibrary.clsStockCollection AllProducts = new ClassLibrary.clsStockCollection();
        lstStockList.DataSource = AllProducts.ProductList;
        lstStockList.DataValueField = "ProductNo";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }
}