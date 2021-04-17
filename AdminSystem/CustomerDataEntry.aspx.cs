using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductNo = Convert.ToInt32(Session["ProductNo"]);
        if (IsPostBack == false)
        {
            if (ProductNo != -1)
            {
                DisplayProduct();
            }
        }

    }

    void DisplayProduct()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(ProductNo);
        txtProductNo.Text = CustomerBook.ThisCustomer.ProductNo.ToString();
        txtFullName.Text = CustomerBook.ThisCustomer.FullName;
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        txtOrderNo.Text = CustomerBook.ThisCustomer.OrderNo.ToString();
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtPhoneNo.Text = CustomerBook.ThisCustomer.PhoneNumber.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        txtDate.Text = CustomerBook.ThisCustomer.Date.ToString();


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
        //capture the OrderNo
        int OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //capture the CustomerID
        int CustomerID = Convert.ToInt32(txtCustomerID.Text);
        // capture Date added
        string Date = txtDate.Text;
        // varlable to store any error messages
        string Error = "";
        //validate the data
        Error = Customer.Valid(FullName, Email, Address, PhoneNumber, Date, OrderNo, CustomerID); 
        if (Error == "")
        {
            // capture the Full Name
            Customer.FullName = FullName;
            //capture the Email
            Customer.Email = Email;
            // capture the Address
            Customer.Address = Address;
            //capture the OrderNo
            Customer.OrderNo = OrderNo;
            Customer.PhoneNumber = PhoneNumber;
            // capture the CustomID
            Customer.CustomerID = CustomerID;
            //I capture date added
            Customer.Date = Convert.ToDateTime(Date);
            //store the address in the session object
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (ProductNo == -1)
            {
                CustomerList.ThisCustomer = Customer;
                CustomerList.Add();
            }
            
            else
            {
                CustomerList.ThisCustomer.Find(ProductNo);
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