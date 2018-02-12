using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace My_Reading_Room.Models
{
    public class My_Reading_Room_Entities
    {
        public DbSet<BookViewModel> Books { get; set; }
    }
}