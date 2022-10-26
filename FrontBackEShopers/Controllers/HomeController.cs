using FrontBackEShopers.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontBackEShopers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var category = new List<Categories>
           
            {
                new Categories()
                {
                    CategoryId = 1,
                    CategoryName = "Shirts"
                },
                new Categories()
                {
                    CategoryId = 2,
                    CategoryName = "Jeans"
                },
                new Categories()
                {
                    CategoryId = 3,
                    CategoryName = "Swimwear"
                },
                new Categories()
                {
                    CategoryId = 4,
                    CategoryName = "Sleepwear"
                },
                new Categories()
                {
                    CategoryId = 5,
                    CategoryName = "Sportswear"
                },
                new Categories()
                {
                    CategoryId = 6,
                    CategoryName = "Jumpsuits"
                },
                new Categories()
                {
                    CategoryId = 7,
                    CategoryName = "Blazers"
                },
                new Categories()
                {
                    CategoryId = 8,
                    CategoryName = "Jackets"
                },
                new Categories()
                {
                    CategoryId = 9,
                    CategoryName = "Shoes"
                }
               
            };
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
            var products = new List<Products>
            {
                new Products()
                {
                    Id = 1,
                    ImageUrl = "cat-1.jpg",
                    Name = "Men's dresses",
                    Price = "$125.00"

                },
                new Products()
                {
                    Id = 2,
                    ImageUrl = "cat-2.jpg",
                    Name = "Woman's dresses",
                     Price = "$125.00"

                },
                new Products()
                {
                    Id = 3,
                    ImageUrl = "cat-3.jpg",
                    Name = "Baby's dresses",
                     Price = "$125.00"

                },
                new Products()
                {
                    Id = 4,
                    ImageUrl = "cat-4.jpg",
                    Name = "Accerssories",
                     Price = "$125.00"

                },
                new Products()
                {
                    Id = 5,
                    ImageUrl = "cat-5.jpg",
                    Name = "Bags",
                     Price = "$125.00"

                },
                new Products()
                {
                    Id = 6,
                    ImageUrl = "cat-6.jpg",
                    Name = "Shoes",
                     Price = "$125.00"

                }
            };
           


            var homeViewModel = new HomeViewModel
            {
                Categories = category,
                CategoriesFirst = categoryFirst,
                Products = products,

            };
            return View(homeViewModel);
        }
    }
}