using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
        if (IsPostBack == true)
        {
            if (ProductNo != -1)
            {
                DisplayCustomers();
            }

        }

    }

    private void DisplayCustomers()
    {
        throw new NotImplementedException();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStock StockManagement = new clsStock();
        StockManagement.ProductName = txtProductName.Text;
        Session["StockManagement"] = StockManagement;
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock StockManagement = new clsStock();
        Int32 ProductNo;
        Boolean Found = false;
        ProductNo = Convert.ToInt32(txtProductNo.Text);
        Found = StockManagement.Find(ProductNo);
        if (Found == true)
        {
            txtProductNo.Text = StockManagement.ProductNo.ToString();
            txtPrice.Text = StockManagement.Price.ToString();
            txtQuantityOrdered.Text = StockManagement.QuantityOrdered.ToString();
            txtDate.Text = StockManagement.Date.ToString();
            txtProductName.Text = StockManagement.ProductName;
            txtQuantityOrdered.Text = StockManagement.QuantityInStock.ToString();
        }
    }
}
