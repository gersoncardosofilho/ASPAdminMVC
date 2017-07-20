using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository.MVC.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Usuário")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Senha")]
        public string Password { get; set; }
    }
}