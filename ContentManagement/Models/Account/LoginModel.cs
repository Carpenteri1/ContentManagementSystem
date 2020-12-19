using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Account
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Användarnamn")]
        [Required(ErrorMessage =("Användarnamn krävs"))]
        public string UserName { get; set; }

        [Required(ErrorMessage = ("Lösenord krävs"))]
        [Display(Name = "Lösenord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
