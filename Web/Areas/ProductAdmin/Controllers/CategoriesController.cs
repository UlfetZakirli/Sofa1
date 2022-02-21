using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

namespace Web.Areas.ProductAdmin.Controllers
{
    [Area("ProductAdmin")]
    //[Authorize(Roles ="Admin")]
    public class CategoriesController : Controller
    {
        private readonly CategoryManager _categoryManager;

        public CategoriesController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }





        // GET: ProductAdmin/Categories
        public IActionResult Index()
        {
            return View(_categoryManager.GetCategories());
        }

        // GET: ProductAdmin/Categories/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();
            var selectedCategory = _categoryManager.GetById(id);
            if (selectedCategory == null)
                return NotFound();
            return View(selectedCategory);
        }

        // GET: ProductAdmin/Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductAdmin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,CategoryIcon,IsDeleted,ID")] Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryManager.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: ProductAdmin/Categories/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var selectedCategory =_categoryManager.GetById(id.Value);
            if (selectedCategory == null)
                return NotFound();
            return View(selectedCategory);
        }

        // POST: ProductAdmin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Name,CategoryIcon,IsDeleted,ID")] Category category)
        {
            if (id != category.ID)
                return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _categoryManager.Update(category);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_categoryManager.CategoryExists(category.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: ProductAdmin/Categories/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var selectedCategory = _categoryManager.GetById(id);
            if (selectedCategory == null)
                return NotFound();
            return View(selectedCategory);
        }

        // POST: ProductAdmin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var selectedCategory = _categoryManager.GetById(id);
            _categoryManager.Delete(selectedCategory);
            return RedirectToAction(nameof(Index));
        }


    }
}