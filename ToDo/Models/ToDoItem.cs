using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class ToDoItem
    {
        public int ToDoItemID { get; set; }
        public string ToDoText { get; set; }
        public bool IsDone { get; set; }
    }
}