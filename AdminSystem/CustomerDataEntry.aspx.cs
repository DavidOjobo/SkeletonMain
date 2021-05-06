using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomers();
            }

        }

    }

    void DisplayCustomers()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        //txtProductNo.Text = CustomerBook.ThisCustomer.ProductNo.ToString();
        txtFullName.Text = CustomerBook.ThisCustomer.FullName;
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        txtPostCode.Text = CustomerBook.ThisCustomer.PostCode;
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtPhoneNo.Text = CustomerBook.ThisCustomer.PhoneNumber;
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        txtDate.Text = CustomerBook.ThisCustomer.Date.ToString("MM/dd/yyyy");


    }

    protected void txtProductNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {

        clsCustomer Customer = new clsCustomer();
       
        //create a new instance of clsCustomer

        //capture the Full Name
        string FullName = txtFullName.Text;
        //capture the Email
        string Email = txtEmail.Text;
        //capture the PhoneNumber
        string PhoneNumber = txtPhoneNo.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostCode.Text;
        string Date = txtDate.Text;
        // varlable to store any error messages
        string Error = "";
        //validate the data
        Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber); 
        if (Error == "")
        {
            // capture the Full Name
            Customer.FullName = FullName;
            //capture the Email
            Customer.Email = Email;
            // capture the Address
            Customer.Address = Address;
            Customer.PostCode = PostCode;
           
            Customer.PhoneNumber = PhoneNumber;
            Customer.Active = chkActive.Checked;
            // capture the ProductNo
            //Customer.ProductNo = ProductNo;
            //I capture date added
            Customer.Date = Convert.ToDateTime(Date);
            //store the address in the session object
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = Customer;
                CustomerList.Add();
            }
            
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = Customer;
                CustomerList.Update();
            }

            Response.Redirect("CustomerList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }

    }




    protected void btnFind_Click(object sender, EventArgs e)

    {
        clsCustomer Customer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = Customer.Find(CustomerID);

        if (Found == true)
        {
            txtCustomerID.Text = Customer.CustomerID.ToString();
            //txtProductNo.Text = Customer.ProductNo.ToString();
            txtFullName.Text = Customer.FullName;
            txtEmail.Text = Customer.Email;
            txtPhoneNo.Text = Customer.PhoneNumber.ToString();
            txtAddress.Text = Customer.Address;
            txtPostCode.Text = Customer.PostCode;
            txtDate.Text = Customer.Date.ToString();
            chkActive.Checked = Customer.Active;


        }


    }


    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }
}