using Microsoft.AspNetCore.Mvc;
using MVCMovie.Data;
using MVCMovie.Models;
using MVCMovie.Models.ViewModels;

namespace MVCMovie.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MVCMovieContext context;
        public int PageSize = 4;
        public ProductsController(MVCMovieContext context)
        {
            this.context = context;
        }
        public IActionResult Index(int productPage = 1) =>
            View(new ProductListViewModel
            {
                Products = context.Product
                .OrderBy(p => p.Id)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo { CurrentPage = productPage,ItemsPerPage = PageSize,TotalItems = context.Product.Count() }
            });

        public IActionResult Create()
        {
            SeedData();
            return View();
        }

        private void SeedData()
        {
            if (this.context.Product?.Any() == false)
            {
                this.context.Product.AddRange(new Product
                {
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersports",
                    Price = 275
                },
 new Product
 {
     Name = "Lifejacket",
     Description = "Protective and fashionable",
     Category = "Watersports",
     Price = 48.95m
 },
 new Product
 {
     Name = "Soccer Ball",
     Description = "FIFA-approved size and weight",
     Category = "Soccer",
     Price = 19.50m
 },
 new Product
 {
     Name = "Corner Flags",
     Description = "Give your playing field a professional touch",
     Category = "Soccer",
     Price = 34.95m
 },
 new Product
 {
     Name = "Stadium",
     Description = "Flat-packed 35,000-seat stadium",
     Category = "Soccer",
     Price = 79500
 },
 new Product
 {
     Name = "Thinking Cap",
     Description = "Improve brain efficiency by 75%",
     Category = "Chess",
     Price = 16
 },
 new Product
 {
     Name = "Unsteady Chair",
     Description = "Secretly give your opponent a disadvantage",
     Category = "Chess",
     Price = 29.95m
 },
 new Product
 {
     Name = "Human Chess Board",
     Description = "A fun game for the family",
     Category = "Chess",
     Price = 75
 },
 new Product
 {
     Name = "Bling-Bling King",
     Description = "Gold-plated, diamond-studded King",
     Category = "Chess",
     Price = 1200
 }
);
            }

            context.SaveChanges();
        }
    }
}
