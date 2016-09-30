using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_DI.Models
{
    public class LinqValueCalculator2 : IValueCalculator
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return 999;
        }
    }
}
