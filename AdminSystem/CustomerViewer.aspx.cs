using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            clsCustomer Customer = new clsCustomer();
            Customer = (clsCustomer)Session["Customer"];
            Response.Write(Customer.CustomerID);
            Response.Write(Customer.FullName);
            Response.Write(Customer.Address);
        Response.Write(Customer.PostCode);
        Response.Write(Customer.Email);
        Response.Write(Customer.Active);
        Response.Write(Customer.PhoneNumber);
        Response.Write(Customer.Date);

    }
}