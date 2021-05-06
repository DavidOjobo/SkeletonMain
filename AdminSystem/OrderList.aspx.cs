using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrder();
        }
    }
    void DisplayProducts()
    {
        //create instance of product collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        //set data source to the list of batches in the collection
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "ProductNo";
        lstOrderList.DataTextField = "ProductName";
        lstOrderList.DataBind();
    }
} 

