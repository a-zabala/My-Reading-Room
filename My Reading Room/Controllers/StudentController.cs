using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using My_Reading_Room.Models;

namespace My_Reading_Room.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var context = new MyReadingRoomDbContext();
            var students = context.Students.ToList();
            var studentlist = new List<StudentViewModel>();
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Celina Zabala",
                CurrentBook = "Holes",
                TotalMinutes = 60
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Molly Matheny",
                CurrentBook = "Sisters",
                TotalMinutes = 45
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Maddie Ferrenbach",
                CurrentBook = "A Wrinkle in Time",
                TotalMinutes = 35
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Jesse Smith",
                CurrentBook = "Bone",
                TotalMinutes = 25
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Elysia Zabala",
                CurrentBook = "Land of Stories",
                TotalMinutes = 70
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Mia Burnside",
                CurrentBook = "Undercover Magic",
                TotalMinutes = 45
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Clay Burnside",
                CurrentBook = "Captain Underpants",
                TotalMinutes = 30
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Ava Long",
                CurrentBook = "Wonder",
                TotalMinutes = 28
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Blake Keller",
                CurrentBook = "Magic Treehouse",
                TotalMinutes = 30
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Sean Malone",
                CurrentBook = "The Lion, the Witch, and the Wardrobe",
                TotalMinutes = 32
            });
            studentlist.Add(new StudentViewModel()
            {
                StudentName = "Zeriyah Bean",
                CurrentBook = "Mr. Lemoncello's Library",
                TotalMinutes = 47
            });
            return View(students);
        }
    }
}