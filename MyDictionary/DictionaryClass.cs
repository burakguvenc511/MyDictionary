using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class DictionaryClass<TProd,TPrice>
    {
        TProd[] Products;
        TPrice[] Prices;

        public DictionaryClass()
        {
            Products = new TProd[0];
            Prices = new TPrice[0];

        }
        public void Add(TProd Product,TPrice Price)
        {
            TProd[] tempProducts = Products;
            TPrice[] tempPrices = Prices;

            Products = new TProd[Products.Length+1];
            Prices = new TPrice[Prices.Length+1];

            for (int i = 0; i < tempProducts.Length; i++)
            {
                Products[i] = tempProducts[i];
                Prices[i] = tempPrices[i];

                
            }
            Products[Products.Length - 1] = Product;
            Prices[Prices.Length - 1] = Price;
      
        }
        public int Count
        {
            get { return Products.Length; }


        }



    }
        

}
