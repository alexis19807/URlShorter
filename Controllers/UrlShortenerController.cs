using Microsoft.AspNetCore.Mvc;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    public class UrlShortenerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UrlShortenerViewModel());
        }

        [HttpPost]
        public IActionResult Index(UrlShortenerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Simulación de generación de URL corta
            var shortCode = GenerateShortCode();
            model.ShortUrl = $"https://short.ly/{shortCode}";

            return View(model);
        }

        private string GenerateShortCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
