using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContentManagement.Models.Account
{
    public class RegistrationModel
    {
        [Key]
        public int ID { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Användarnamn krävs")]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lösenord krävs")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bekräfta lösenordet krävs")]
        [Compare("Password", ErrorMessage = "Lösenorden matchar inte")]
        public string ConfirmPassword { get; set; }

    }
}
