using Microsoft.AspNetCore.Mvc;

public class ConfirmationController : Controller
{
    public IActionResult Confirm()
    {
        var orderedProducts = GetOrderedProducts();

        return View(orderedProducts);
    }

    private Product[] GetOrderedProducts()
    {
        var products = new Product[]
        {
            new Product { Id = 1, Name = "Pizza Margherita", Quantity = 2, Price = 10.99m },
            new Product { Id = 2, Name = "Pizza Pepperoni", Quantity = 1, Price = 12.99m },
        };

        return products;
    }
}
