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

    protected void txtProductNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        
            clsCustomer Customer = new clsCustomer();
            Customer.ProductNo = Convert.ToInt32(txtProductNo.Text);
            Session["Customer"] = Customer;
            //navigate to viewer page
            Response.Redirect("CustomerViewer.aspx");
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
   
        {
            clsCustomer Customer = new clsCustomer();
            Int32 ProductNo;
            Boolean Found = false;
            ProductNo = Convert.ToInt32(txtProductNo.Text);
            Found = Customer.Find(ProductNo);

            if (Found == true)
            {
                txtProductNo.Text = Customer.ProductNo.ToString();
                txtFullName.Text = Customer.FullName;
                txtEmail.Text = Customer.Email;
                txtOrderNo.Text = Customer.OrderNo.ToString();
                txtCustomerID.Text = Customer.CustomerID.ToString();
                txtPhoneNo.Text = Customer.PhoneNumber.ToString();
                txtAddress.Text = Customer.Address;
                txtDate.Text = Customer.Date.ToString();


            }

        
    }
}
