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
        clsOrder Order = new clsOrder();
        string ProductName = txtProductName.Text;
        string ProductNo = txtProductNo.Text;
        //capture the StaffID
        string OrderNo = txtOrderNo.Text;
        //capture the Batch number
        string Price = txtPrice.Text;
        string Date = txtDate.Text;
        //string Dispatched = txtDispatched.Text;
        // varlable to store any error messages
        string Error = "";
        //validate the data
        Error = Order.Valid(ProductNo, ProductName, OrderNo, Price, Date);
        if (Error == "")
        {
            Order.ProductName = txtProductName.Text;
            Order.ProductNo = Convert.ToInt32(txtProductNo.Text);
            Order.OrderNo = Convert.ToInt32(txtOrderNo.Text);
            Order.Price = Convert.ToChar(txtPrice.Text);
            Order.Date = Convert.ToDateTime(txtDate.Text);
            //Order.Dispatched = chkDispatched.Checked;
            Order.ProductName = txtProductName.Text;
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = Order;
            OrderList.Add();

            //navigate to viewer page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder Order = new clsOrder();
        Int32 ProductNo;
        Boolean Found = false;
        ProductNo = Convert.ToInt32(txtProductNo.Text);
        Found = Order.Find(ProductNo);
        if (Found == true)
        {
            txtProductName.Text = Order.ProductName.ToString();
            txtProductNo.Text = Order.ProductNo.ToString();
            txtPrice.Text = Order.Price.ToString();
            txtDate.Text = Order.Date.ToString();
            txtProductName.Text = Order.ProductName;
        }
    }
}