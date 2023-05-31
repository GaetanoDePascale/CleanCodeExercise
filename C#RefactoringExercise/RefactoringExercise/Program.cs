
namespace RefactoringExercise;

class Program
{
    static void Main(string[] args)
    {
        string countVowelsTestString = "Prova A contare le vocali";

        Console.WriteLine("Esecuzione codice senza refactoring");
        Console.WriteLine($"Vocali contenute in {countVowelsTestString}: {OriginalCode.CountVowels.VowelsNumber(countVowelsTestString)}");

        #region Shopping Cart
        RefactoringExample.OriginalCode.ShoppingCart cart = new RefactoringExample.OriginalCode.ShoppingCart();

        RefactoringExample.OriginalCode.Product product1 = new RefactoringExample.OriginalCode.Product { ProductName = "Product 1", ProductPrice = 10 };
        RefactoringExample.OriginalCode.Product product2 = new RefactoringExample.OriginalCode.Product { ProductName = "Product 2", ProductPrice = 20 };
        RefactoringExample.OriginalCode.Product product3 = new RefactoringExample.OriginalCode.Product { ProductName = "Product 3", ProductPrice = 30 };

        cart.AddProduct(product1);
        cart.AddProduct(product2);
        cart.AddProduct(product3);

        decimal totalPrice = cart.CalculateTotalPrice();

        Console.WriteLine("Total price: $" + totalPrice);
        #endregion


        Console.WriteLine("---------------------------------------------------------------");

        Console.WriteLine("Esecuzione codice dopo refactoring");
        Console.WriteLine($"Vocali contenute in {countVowelsTestString}: {RefactoredCode.Vowels.count(countVowelsTestString)}");

        #region Shopping Cart
        RefactoringExample.RefactoredCode.ShoppingCart cartRefactored = new RefactoringExample.RefactoredCode.ShoppingCart();

        cartRefactored.AddProducts(new List<RefactoringExample.RefactoredCode.Product>
        {
            new RefactoringExample.RefactoredCode.Product { Name = "Product 1", Price = 10 },
            new RefactoringExample.RefactoredCode.Product { Name = "Product 2", Price = 20 },
            new RefactoringExample.RefactoredCode.Product { Name = "Product 3", Price = 30 }
        });

        Console.WriteLine($"Total price: ${cartRefactored.CalculateTotalPrice()}");
        #endregion

        Console.WriteLine("---------------------------------------------------------------");

        DateTime dt = new DateTime(637134336000000000);
        Console.WriteLine("Date: " + dt);
        Console.WriteLine("Ticks: " + dt.Ticks);
        Console.WriteLine("---------------------------------------------------------------");
    }
}
