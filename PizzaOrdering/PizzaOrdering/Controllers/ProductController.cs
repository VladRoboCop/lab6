using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    public IActionResult Order()
    {
        var products = new Product[]
        {
            new Product { Id = 1, Name = "Pizza Margherita", Price = 10.99m },
            new Product { Id = 2, Name = "Pizza Pepperoni", Price = 12.99m },
            new Product { Id = 3, Name = "Pizza Vegetarian", Price = 11.99m }
        };

        return View(products);
    }

    [HttpPost]
    public IActionResult Order(Product[] products)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Confirm", "Confirmation");
        }
        return View(products);
    }
}
