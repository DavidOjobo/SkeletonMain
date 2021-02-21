using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public string ProductNo { get; set; }
        public string QuantityOrdered { get; set; }
        public string ProductDesc { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string QuantityInStock { get; set; }
    }
}