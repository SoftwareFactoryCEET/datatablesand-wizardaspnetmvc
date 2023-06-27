using Laboratorio5WebApplicationMVC.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio5WebApplicationMVC.Controllers
{
    public class OrderItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderItemsController(ApplicationDbContext context)
        {
            this._context = context;
        }

        // GET: OrderItemsController
        public ActionResult Index()
        {
            var orderItems = _context.OrderItems.ToList(); // AutoMapper can be used to map to DTOs
            return View(orderItems);
        }

        // GET: OrderItemsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderItemsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderItemsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderItemsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
