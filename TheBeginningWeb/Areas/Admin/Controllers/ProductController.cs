using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBeginning.Entities.Entity;
using TheBeginning.Services.ProductRepository;

namespace TheBeginningWeb.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService = new ProductService();
        // GET: Admin/Product
        public ActionResult ProductList()
        {
            List<ProductEntity> model = _productService.GetList();
            return View(model);
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            ProductEntity model = _productService.GetItemById(id);
            return View(model);
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(ProductEntity model)
        {
           
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _productService.Add(model);

                    return RedirectToAction("ProductList", "Product");
                }else
                {
                    return View();
                }
            
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            ProductEntity model = _productService.GetItemById(id);
            return View(model);
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductEntity model)
        {
            try
            {
                // TODO: Add update logic here
                _productService.Update(model.Id, model);
                return RedirectToAction("ProductList", "Product");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            ProductEntity model = _productService.GetItemById(id);
            return View(model);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
