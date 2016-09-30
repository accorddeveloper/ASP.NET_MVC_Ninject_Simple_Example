using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_DI.Models
{
    public interface IValueCalculator
    {
        /// <summary>
        /// 計算產品集合總金額
        /// </summary>
        /// <param name="products">產品集合</param>
        /// <returns>總金額</returns>
        decimal ValueProducts(IEnumerable<Product> products);
    }
}
