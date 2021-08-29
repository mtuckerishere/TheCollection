using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheCollection.Models
{
    public class Locations
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }   
        public virtual ICollection<Monsters> Monsters {get;set;}   
    }
}