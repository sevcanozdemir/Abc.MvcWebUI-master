using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class UserOrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public double Count { get; set; }


    }
}