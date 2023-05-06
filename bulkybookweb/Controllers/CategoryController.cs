using bulkybookweb.Data;
using bulkybookweb.Models;
using Microsoft.AspNetCore.Mvc;

namespace bulkybookweb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Applicationdbcontext _db;

        public CategoryController(Applicationdbcontext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList= _db.Categories.ToList();
            return View(objCategoryList);
        }
        //get
        public IActionResult Create()
        {
            
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //get edit
        public IActionResult Edit(int? id)
        {
            if(id==null || id==0)
            {
                return NotFound();
            }
            var categoryfromdb = _db.Categories.Find(id);
            if (categoryfromdb == null)
            {
                return NotFound();

            }
            return View(categoryfromdb);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //get delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryfromdb = _db.Categories.Find(id);
            if (categoryfromdb == null)
            {
                return NotFound();

            }
            return View(categoryfromdb);
        }
        //post delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            
           
        }
    }
}
