using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    private object lstProductList;
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }

    }
    void DisplayStock()
    {
        ClassLibrary.clsStockCollection AllProducts = new ClassLibrary.clsStockCollection();
        lstStockList.DataSource = AllProducts.mProductList;
        lstStockList.DataValueField = "ProductNo";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductNo"] = -1;
        Response.Redirect("StockDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if (lstStockList.SelectedIndex != -1)
        {
            ProductNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("StockDataEntry.aspx");

        }

        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }



    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if (lstStockList.SelectedIndex != -1)
        {
            ProductNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("DeleteStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

   

    protected void btnApply_Click(object sender, EventArgs e)
    {
       
        clsStockCollection Products = new clsStockCollection();
        Products.ReportByProductNo(txtFilter.Text);
        lstStockList.DataSource = Products.mProductList;
        lstStockList.DataValueField = "ProductNo";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {

        clsStockCollection Products = new clsStockCollection();
        Products.ReportByProductNo("");
        txtFilter.Text = "";
        lstStockList.DataSource = Products.mProductList;
        lstStockList.DataValueField = "ProductNo";
        lstStockList.DataTextField = "ProductName";
        lstStockList.DataBind();

    }   

    }


