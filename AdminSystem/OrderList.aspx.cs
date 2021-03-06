﻿using System;
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
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        //create instance of product collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        //set data source to the list of batches in the collection
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "ProductNo";
        lstOrderList.DataTextField = "ProductName";
        lstOrderList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductNo"] = -1;
        Response.Redirect("Order.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if (lstOrderList.SelectedIndex != -1)
        {
            ProductNo = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("OrderDataEntry.aspx");

        }

        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if (lstOrderList.SelectedIndex != -1)
        {
            ProductNo = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("DeleteOrder.aspx");
        }
        else //if no record has been selected
        {
            //dis[lay an error
            lblError.Text = "please select a record to delete ffrom this list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportByProductName(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "ProductName";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportByProductName("");
        txtFilter.Text = "";
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "ProductName";
        lstOrderList.DataBind();
    }
}
   



