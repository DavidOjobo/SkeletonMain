using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrders();
            }

        }
    }

    void DisplayOrders()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        //txtProductNo.Text = CustomerBook.ThisCustomer.ProductNo.ToString();
        txtProductName.Text = OrderBook.ThisOrder.ProductName;
        txtProductNo.Text = OrderBook.ThisOrder.ProductNo;
        txtPrice.Text = OrderBook.ThisOrder.Price;
        txtOrderNo.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtDate.Text = OrderBook.ThisOrder.Date.ToString("MM/dd/yyyy");

    }

    protected void txtProductNo_TextChanged(object sender, EventArgs e)
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

            if (OrderID == -1)
            {
                OrderList.ThisOrder = Order;
                OrderList.Add();
            }


            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = Order;
                OrderList.Update();
                }

                Response.Redirect("OrderList.aspx");

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