using FrontBackEShopers.DAL;
using FrontBackEShopers.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontBackEShopers.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly AppDbContext _appDbContext;        
        public HomeController(AppDbContext context)
        {
            _appDbContext = context;
        }
        public IActionResult Index()
        {
            var products = _appDbContext.Products.ToList();
            var categories = _appDbContext.Categories.ToList();



            //var category = new List<Category>

            //{
            //    new Category()
            //    {
            //        CategoryId = 1,
            //        CategoryName = "Shirts"
            //    },
            //    new Category()
            //    {
            //        CategoryId = 2,
            //        CategoryName = "Jeans"
            //    },
            //    new Category()
            //    {
            //        CategoryId = 3,
            //        CategoryName = "Swimwear"
            //    },
            //    new Category()
            //    {
            //        CategoryId = 4,
            //        CategoryName = "Sleepwear"
            //    },
            //    new Category()
            //    {
            //        CategoryId = 5,
            //        CategoryName = "Sportswear"
            //    },
            //    new Category()
            //    {
            //        CategoryId = 6,
            //        CategoryName = "Jumpsuits"
            //    },
            //    new Category()
            //    {
            //        CategoryId = 7,
            //        CategoryName = "Blazers"
            //    },
            //    new Category()
            //    {
            //        CategoryId = 8,
            //        CategoryName = "Jackets"
            //    },
            //    new Category()
            //    {
            //        CategoryId = 9,
            //        CategoryName = "Shoes"
            //    }

            //};

            var categoryFirst = new List<CategoriesFirst>
            {
                new CategoriesFirst()
                {
                    CategoryId = 1,
                    CategoryName = "Men's Dresses"
                },
                new CategoriesFirst()
                {
                    CategoryId = 2,
                    CategoryName = "Woman's Dresses"
                },
                new CategoriesFirst()
                {
                    CategoryId = 3,
                    CategoryName = "Baby's Dresses"
                }
            };
            //var products = new List<Product>
            //{
            //    new Product()
            //    {
            //        Id = 1,
            //        ImageUrl = "cat-1.jpg",
            //        Name = "Men's dresses",
            //        Price = 125.00m

            //    },
            //    new Product()
            //    {
            //        Id = 2,
            //        ImageUrl = "cat-2.jpg",
            //        Name = "Woman's dresses",
            //         Price = 125.00m

            //    },
            //    new Product()
            //    {
            //        Id = 3,
            //        ImageUrl = "cat-3.jpg",
            //        Name = "Baby's dresses",
            //         Price = 125.00m

            //    },
            //    new Product()
            //    {
            //        Id = 4,
            //        ImageUrl = "cat-4.jpg",
            //        Name = "Accerssories",
            //        Price = 125.00m

            //    },
            //    new Product()
            //    {
            //        Id = 5,
            //        ImageUrl = "cat-5.jpg",
            //        Name = "Bags",
            //         Price = 125.00m

            //    },
            //    new Product()
            //    {
            //        Id = 6,
            //        ImageUrl = "cat-6.jpg",
            //        Name = "Shoes",
            //         Price = 125.00m

            //    }
            //};



            var homeViewModel = new HomeViewModel
            {
               
               Categories = categories,
               Products = products,
               CategoriesFirst = categoryFirst

            };
            return View(homeViewModel);
        }
    }
}