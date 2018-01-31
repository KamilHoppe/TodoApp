using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class Todo
    {
        [Key]
        public int idMessage { get; set; }
        [Required]
        public string Message { get; set; }
        [MaxLength(200)]
        [Required]
        public string Tittle { get; set; }
        public DateTime Date { get; set; }
    }
}