using System;
using System.Collections.Generic;

namespace StockManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Stock management system");
            List<Stock> stocklist = new List<Stock>();
            
            //add stock
            Stock sd = new Stock()
            {
                stockName = "Tata",
                numberOfStock = 1009,
                priceOfStock = (float)1117.51
            };
            Stock sd2 = new Stock()
            {
                stockName = "Bajaja",
                numberOfStock = 1109,
                priceOfStock = (float)4217.76
            };
            Stock sd3 = new Stock()
            {
                stockName = "AsianPaint",
                numberOfStock = 2009,
                priceOfStock = (float)5017.43
            };
            stocklist.Add(sd);
            stocklist.Add(sd2);
            stocklist.Add(sd3);
            Console.WriteLine("*************");
            Console.WriteLine("Stock Report");
            foreach (Stock stockk in stocklist)
            {
                Console.WriteLine(StockPortfolio.StockValue(stockk));
            }
            
        }
    }
}
