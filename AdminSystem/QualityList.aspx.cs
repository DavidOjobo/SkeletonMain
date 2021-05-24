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
        //if this is the first time the page is being displayed
        if (IsPostBack == false)
        {
            DisplayProducts();
        }
    }
    void DisplayProducts()
    {
        //create instance of product collection
        clsQualityCollection AllProducts = new clsQualityCollection(); 
        //set data source to the list of batches in the collection
        lstProductList.DataSource = AllProducts.ProductList;
        lstProductList.DataValueField = "ProductNo";
        lstProductList.DataTextField = "ProductName";
        lstProductList.DataBind();
    }

    protected void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductNo"] = -1;
        Response.Redirect("QualityControl.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if (lstProductList.SelectedIndex != -1)
        {
            ProductNo = Convert.ToInt32(lstProductList.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("QualityDataEntry.aspx");

        }

        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if (lstProductList.SelectedIndex != -1)
        {
            ProductNo = Convert.ToInt32(lstProductList.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
