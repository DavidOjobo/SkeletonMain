using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public string ProductNo { get; set; }
        public int orderNo { get; set; }
        public int OrderNo { get; set; }
        public string ProductDesc { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public bool Dispatched { get; set; }
    }
}