using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VithalDynamic.Models
{
    public class OrderModel
    {
        public string Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public Int16 Qty { get; set; }
        public double Price { get; set; }
        public double TotalAmount { get; set; }
    }

    public class OrderDetail
    {
        /// <summary>  
        /// To hold list of orders  
        /// </summary>  
        /// 
        public string Id { get; set; }
        public List<OrderModel> OrderDetails { get; set; }

    }
}
