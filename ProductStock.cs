using System;
using System.Collections.Generic;

namespace PaymentTracking
{
    public class ProductStock
    {
        private List<Product> _products;

        public ProductStock()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void UpdateStock()
        {
            foreach (Product product in _products)
            {
                product.UpdateStock();
            }
        }
    }
}

/* This class ProductStock represents a collection of Product objects. 
It has a private List member _products to store the products. 
It has three methods: AddProduct (which adds a Product to the stock), 
RemoveProduct (which removes a Product from the stock), 
and GetProducts (which returns a List of all the Products in the stock). 
Additionally, it has a UpdateStock method, 
which updates the stock levels of all products in the stock based on 
the data in the PaymentLog and CostLog.
Contact me: linkedin.com/farukkara or farukkara100@protonmail.ch */