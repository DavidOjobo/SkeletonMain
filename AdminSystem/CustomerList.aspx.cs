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
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        lstCustomerList.DataSource = AllCustomers.CustomerList;
        lstCustomerList.DataValueField = "ProductNo";
        lstCustomerList.DataTextField = "Address";
        lstCustomerList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductNo"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductNo;
        if (lstCustomerList.SelectedIndex != 1)
        {
            ProductNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["ProductNo"] = ProductNo;
            Response.Redirect("CustomerDataEntry.aspx");

        }

        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }


    }
}