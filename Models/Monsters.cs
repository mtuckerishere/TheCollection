using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheCollection.Models
{
    public class Monsters
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Level { get; set; }         
        public int HP { get; set; } 
        public int MP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }
        public int MagicDefence { get; set; }
        public int MagicEvasion { get; set; }
        public int Speed { get; set; }
        public int HitRate { get; set; }
        public int Evasion { get; set; }
        public int Experience { get; set; }
        public int Gil { get; set; } 
        public virtual ICollection<Locations> Locations {get;set;}  
    }
}