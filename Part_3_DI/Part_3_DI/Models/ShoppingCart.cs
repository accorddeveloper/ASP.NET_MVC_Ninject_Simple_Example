using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_DI.Models
{
    public class ShoppingCart   
    {
        //計算總金額object
        private IValueCalculator calc;

        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        /// <summary>
        /// 設置/取得產品集合
        /// </summary>
        public IEnumerable<Product> Products { get; set; }

        /// <summary>
        /// 計算產品總金額
        /// </summary>
        /// <returns>產品總金額</returns>
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}
