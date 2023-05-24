namespace RefactoringExample.RefactoredCode;

using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class ShoppingCart
{
    private List<Product> products;

    public ShoppingCart()
    {
        products = new List<Product>();
    }

    public void AddProducts(IEnumerable<Product> productList)
    {
        products.AddRange(productList);
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }

    public decimal CalculateTotalPrice()
    {
        return products.Sum(product => product.Price);
    }
}