//using Entities;
//using Microsoft.AspNetCore.Mvc;

//namespace Web.Controllers
//{
//    public class CartController : Controller
//    {
//        private readonly ProductManager _productManager;

//        public CartController(ProductManager productManager)
//        {
//            _productManager = productManager;
//        }
         
//        public IActionResult Index()
//        {
//            var productIdList = Request.Cookies["cartItem"];
//            if(productIdList != null && productIdList != "")
//            {
//                List<int> productIds = productIdList.Split("-").Select(c => int.Parse(c)).ToList();
//              List<Product> productList= _productManager.GetByIds(productIds.Distinct());
//            } 
//            return View(productIdList);
//        }
//    }
//}
