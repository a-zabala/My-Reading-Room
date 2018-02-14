using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Reading_Room.Models
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string CurrentBook { get; set; }
        public int TotalMinutes { get; set; }
    }
}
