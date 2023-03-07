using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelperMVC.Models
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public bool IsAgree { get; set; }
    }
}