using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInviteMVC5WebApp.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="First Name Cannot Be Empty")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Cannot Be Empty")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Cannot Be Empty")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile Cannot be Empty")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please Choose One Option")]
        public bool? WillAttend { get; set; }



    }
}