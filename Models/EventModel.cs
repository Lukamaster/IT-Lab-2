using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Lab_2.Models
{
    public class EventModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MinLength(5)]
        [MaxLength(30)]
        public string Location { get; set; }
    }
}