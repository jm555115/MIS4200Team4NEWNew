using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team4New.Models
{
    
    public class UserProfile
    {
       
        [Key]
        public Guid userID { get; set; }

        [Required]
        [Display(Name = "First Name")]    
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        public string email { get; set; }
        [Display(Name = "Name")]
        public string fullName { get { return lastName + ", " + firstName; } }
        [Display(Name = "Total Nominations")]
        public int numberOfNominations { get; set; }
        public ICollection<Nomination> Nominations { get; set; }

    }
}