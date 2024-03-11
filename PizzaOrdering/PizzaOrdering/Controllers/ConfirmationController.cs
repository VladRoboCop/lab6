using Microsoft.AspNetCore.Mvc;

public class ConfirmationController : Controller
{
    public IActionResult Confirm()
    {
        // Здесь можно добавить логику получения данных о заказанных продуктах из хранилища,
        // такого как база данных или сессия

        var orderedProducts = GetOrderedProducts(); // Примерный метод для получения данных о продуктах

        return View(orderedProducts);
    }

    private Product[] GetOrderedProducts()
    {
        // Примерная логика получения данных о продуктах
        var products = new Product[]
        {
            new Product { Id = 1, Name = "Pizza Margherita", Quantity = 2, Price = 10.99m },
            new Product { Id = 2, Name = "Pizza Pepperoni", Quantity = 1, Price = 12.99m },
            // Добавьте другие продукты, если необходимо
        };

        return products;
    }
}
