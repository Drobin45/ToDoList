using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        public string ListTitle { get; set; }
        public DateTime ListCreateDate { get; set; }

        [ForeignKey("List")]
        public int ListID { get; set; }
        public string TaskDescriptions { get; set; }
        public bool IsDone { get; set; }
        public DateTime DueDate { get; set; }
        public virtual List List { get; set; }
    }
}