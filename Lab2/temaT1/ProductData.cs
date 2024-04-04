using System;
using System.Collections.Generic;

namespace temaT1
{
    public class ProductData
    {
        public Dictionary<string, Dictionary<string, decimal>> ProductPrices { get; set; }

        public ProductData()
        {
            ProductPrices = new Dictionary<string, Dictionary<string, decimal>>()
            {
                { "Alimente", new Dictionary<string, decimal>() { { "Paine", 2.5m }, { "Lapte", 3.0m }, { "Fructe", 4.0m } } },
                { "Băuturi", new Dictionary<string, decimal>() { { "Cola", 2.0m }, { "Apă", 1.0m }, { "Suc", 2.5m } } },
                { "Curățenie", new Dictionary<string, decimal>() { { "Detergent", 5.5m }, { "Mop", 7.0m }, { "Hârtie igienică", 3.0m } } },
                { "Haine", new Dictionary<string, decimal>() { { "Tricou", 12.0m }, { "Blugi", 25.0m }, { "Șapcă", 8.0m } } },
                { "Electronice", new Dictionary<string, decimal>() { { "Telefon", 500.0m }, { "Căști", 80.0m }, { "Mouse", 30.0m } } },
            };
        }

        public decimal GetProductPrice(string category, string product)
        {
            if (ProductPrices.ContainsKey(category) && ProductPrices[category].ContainsKey(product))
                return ProductPrices[category][product];
            else
                throw new ArgumentException("Invalid category or product");
        }
    }
}