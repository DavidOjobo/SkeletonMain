using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public string ProductNo { get; set; }
        public int QuantityOrdered { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int QuantityInStock { get; set; }
    }
}