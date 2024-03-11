using Microsoft.AspNetCore.Mvc;

public class RegistrationController : Controller
{
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(User user)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Order", "Product");
        }
        return View(user);
    }
}
