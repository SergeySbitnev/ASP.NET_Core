using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controlles
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                string category = p?.Category ?? "None";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                results.Add(string.Format($"Name: {name}, Category {category}, Price: {price}, Related: {relatedName}"));
            }
            return View(results);
        }
    }
}
