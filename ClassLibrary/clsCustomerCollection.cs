using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public List<clsCustomer> mCustomerList { get; set; }
        public int Count { get; set; }
        public clsCustomer ThisCustomer { get; set; }
    }
}