using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagement
{
    class StockPortfolio
    {
        internal static string StockValue(Stock s)
        {
            double result = s.priceOfStock * s.numberOfStock;
            string r = "stock name:" + s.stockName + " value is " + result.ToString();
            return r;
        }
    }
}
