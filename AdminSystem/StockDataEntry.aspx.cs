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
        if (IsPostBack == true)
        {
            if (ProductNo != -1)
            {
                DisplayProduct();
            }

        }

    }

    private void DisplayProduct()
    {
        clsStockCollection ProductList = new clsStockCollection();
        ProductList.ThisProduct.Find(ProductNo);
        //txtProductNo.Text = ProductList.ThisProduct.ProductNo.ToString();
        txtProductName.Text = ProductList.ThisProduct.ProductName;
        txtProductNo.Text = ProductList.ThisProduct.ProductNo.ToString();
        txtPrice.Text = ProductList.ThisProduct.Price.ToString();
        txtQuantityInStock.Text = ProductList.ThisProduct.QuantityInStock.ToString();
        txtQuantityOrdered.Text = ProductList.ThisProduct.QuantityOrdered.ToString();
        txtDate.Text = ProductList.ThisProduct.Date.ToString("MM/dd/yyyy");
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStock StockManagement = new clsStock();
        //create a new instance of clsStock
        Int32 ProductNo;
        double Price;
        DateTime Date;
        int QuantityInStock;
        int QuantityOrdered;
        ProductNo = Convert.ToInt32(txtProductNo.Text);
        string ProductName = txtProductName.Text;
        Price = Convert.ToDouble(txtPrice.Text);
        QuantityInStock = Convert.ToInt32(txtQuantityInStock.Text);
        QuantityOrdered = Convert.ToInt32(txtQuantityOrdered.Text);
        Date = Convert.ToDateTime(txtDate.Text);

        string Error = "";
        //validate the data
        Error = StockManagement.Valid(ProductName, QuantityInStock, Price, ProductNo, Date, QuantityOrdered);
        if (Error == "")
        {

            txtProductNo.Text = StockManagement.ProductNo.ToString();
            txtPrice.Text = StockManagement.Price.ToString();
            txtQuantityOrdered.Text = StockManagement.QuantityOrdered.ToString();
            txtDate.Text = StockManagement.Date.ToString();
            txtProductName.Text = StockManagement.ProductName;
            txtQuantityOrdered.Text = StockManagement.QuantityInStock.ToString();
            clsStockCollection ProductList = new clsStockCollection();

            if (ProductNo == -1)
            {
                ProductList.ThisProduct = StockManagement;
                ProductList.Add();
            }

            else
            {
                ProductList.ThisProduct.Find(ProductNo);
                ProductList.ThisProduct = StockManagement;
                ProductList.Update();
            }

            Response.Redirect("ProductList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock StockManagement = new clsStock();
        Int32 ProductNo;
        Boolean Found = false;
        ProductNo = Convert.ToInt32(txtProductNo.Text);
        Found = StockManagement.Find(ProductNo);
        if (Found == true)
        {
            txtProductNo.Text = StockManagement.ProductNo.ToString();
            txtPrice.Text = StockManagement.Price.ToString();
            txtQuantityOrdered.Text = StockManagement.QuantityOrdered.ToString();
            txtDate.Text = StockManagement.Date.ToString();
            txtProductName.Text = StockManagement.ProductName;
            txtQuantityOrdered.Text = StockManagement.QuantityInStock.ToString();
        }
    }
}
