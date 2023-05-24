namespace RefactoringExample.OriginalCode;

class Product
{
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
}

class ShoppingCart
{
    private Product[] productList;

    public ShoppingCart()
    {
        productList = new Product[0];
    }

    public void AddProduct(Product product)
    {
        productList = productList.Append(product).ToArray();
    }

    public void RemoveProduct(Product product)
    {
        productList = productList.Except(new Product[] { product }).ToArray();
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;

        for (int i=0;i<productList.Length;i++)
        {
            totalPrice += productList[i].ProductPrice;
        }

        return totalPrice;
    }
}