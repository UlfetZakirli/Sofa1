using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShoppingDB _context;

        public HomeController(ILogger<HomeController> logger, ShoppingDB context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM()
            {
                Sliders = _context.Sliders.ToList(),
                Products = _context.Products.ToList(),
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Blog_list()
        {
            return View();
        }
        public IActionResult Single_blog()
        {
            return View();
        }
        public IActionResult Purchase()
        {
            return View();
        }
        public IActionResult Error_page()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Sign_up()
        {
            return View();
        }
        public IActionResult Forget_password()
        {
            return View();
        }
        public IActionResult My_account()
        {
            return View();
        }
        public IActionResult Shop_right()
        {
            return View();
        }
        public IActionResult Single_product()
        {
            return View();
        }

        public IActionResult Shopping_Cart()
        {
            return View();
        }
        public IActionResult About_us()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Coming_soon()
        {
            return View();
        }
        public IActionResult Comparing()
        {
            return View();
        }
        public List<Blog> FindBlogById(int? categoryId)
        {
            return _context.Blogs.Where(x => x.BlogCategoryId == categoryId).ToList();
        }
        public IActionResult Blog(int? id)
        {
            if(id == null) return  NotFound();
            var findBlog=_context.Blogs.FirstOrDefault(x=>x.ID == id);
            if (findBlog == null) return NotFound();
            BlogVM blogVM = new BlogVM()
            {
                BlogSingle=findBlog,
                SameBlogs=FindBlogById(findBlog.BlogCategoryId)
            };
       
            return View(blogVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}