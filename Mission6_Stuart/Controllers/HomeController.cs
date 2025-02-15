using Microsoft.AspNetCore.Mvc;
using Mission6_Stuart.Models;

namespace Mission6_Stuart.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;

        // Corrected constructor for dependency injection
        public HomeController(MovieCollectionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Collection()
        {
            return View();
        }
         
        [HttpPost]
        public IActionResult Collection(Collection response)
        {
            if (ModelState.IsValid)
            {
                _context.Collections.Add(response);
                _context.SaveChanges();

                // Stay on the same page and pass the updated data to the view
                return View("Confirmation", response);
            }

            // Return the view with validation errors
            return View("Collection");
        }


    }
}
