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

        //create a new instance of clsCustomer

        //capture the Full Name
        string ProductName = txtProductName.Text;
        //capture the Email
        Int32 ProductNo = Convert.ToInt32(txtProductNo.Text);
        //capture the PhoneNumber
        Int32 OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Int32 Price = Convert.ToInt32(txtPrice.Text);
        //capture the CustomerID
        //int CustomerID = Convert.ToInt32(txtCustomerID.Text);
        // capture Date added
        string Date = txtDate.Text;
        // varlable to store any error messages
        string Error = "";
        //validate the data
        Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
        if (Error == "")
        {
            // capture the Full Name
            Order.ProductName = ProductName;
            Order.ProductNo = ProductNo;
            Order.OrderNo = OrderNo;
            //capture the OrderNo
            Order.Price = Price;
            // capture the ProductNo
            //I capture date added
            Order.Date = Convert.ToDateTime(Date);
        }
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {

    }
}