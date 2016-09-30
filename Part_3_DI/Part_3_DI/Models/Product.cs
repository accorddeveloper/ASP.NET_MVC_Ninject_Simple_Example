using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_DI.Models
{
    public class Product
    {
        /// <summary>
        /// 產品ID
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// 產品名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 產品說明
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 產品單價
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 產品類別
        /// </summary>
        public string Category { get; set; }
    }
}
