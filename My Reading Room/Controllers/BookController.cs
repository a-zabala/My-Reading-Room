using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using My_Reading_Room.Models;

namespace My_Reading_Room.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        // testing github commits
        public ActionResult Index()
        {
            var context = new MyReadingRoomDbContext();
            var books = context.Books.ToList();
            var booklist = new List<BookViewModel>();
            booklist.Add(new BookViewModel() { Name = "Holes", Genre = "Science Fiction", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "A Series of Unfortunate Events", Genre = "Fiction", Rating = 5 });
            booklist.Add(new BookViewModel() { Name = "Undercover Magic", Genre = "Fiction", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "Sisters", Genre = "Graphic Novel", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "Smile", Genre = "Graphic Novel", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "Ghosts", Genre = "Graphic Novel", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "Mr.Lemoncello's Library", Genre = "Realistic Fiction", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "Mr.Lemoncello's Library Olympics", Genre = "Realistic Fiction", Rating = 3 });
            booklist.Add(new BookViewModel() { Name = "Treasure Hunters", Genre = "Realistic Fiction", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "Bone", Genre = "Graphic Novel", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "The Lion, the Witch, and the Wardrobe", Genre = "Fiction", Rating = 4 });
            booklist.Add(new BookViewModel() { Name = "Land of Stories", Genre = "Science Fiction", Rating = 5 });
            return View(books);
        }
        public string BobResult()
        {
            return "Try this out";
        }
    }
}