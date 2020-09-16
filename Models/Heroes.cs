using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroProject.Models
{
    public class Heroes
    {
        [Key]
        public int Id { get; set; }
        public string heroName { get; set; }
        public string aliasFirstName { get; set; }
        public string aliasLastname { get; set; }
        public string primaryAbility { get; set; }
        public string secondaryAbility { get; set; }
        public string catchPhrase { get; set; }
    }
}
