using IBMiX.Service.Common;
using IBMiX.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IBMiX.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService bookService;
        private readonly IUserService userService;

        public HomeController(IBookService bookService, IUserService userService)
        {
            this.bookService = bookService;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            var books = bookService.GetBooks();
            var users = userService.GetUsers();

            ViewData["Users"] = users;
            return View(books);
        }

        [HttpPost]
        public IActionResult ReturnBook(string bookId)
        {
            if (bookId != null && !string.IsNullOrEmpty(bookId))
            {
                bookService.ReturnBook(bookId);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult BorrowBook(string bookId, int userId)
        {
            if (bookId != null && !string.IsNullOrEmpty(bookId))
            {
                bookService.BorrowBook(bookId, userId);
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}