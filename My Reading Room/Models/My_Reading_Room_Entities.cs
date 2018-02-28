using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace My_Reading_Room.Models
{
    public class MyReadingRoomDbContext: DbContext
    {
        public DbSet<BookViewModel> Books { get; set; }
        public DbSet<StudentViewModel> Students { get; set; }
    }
    
}