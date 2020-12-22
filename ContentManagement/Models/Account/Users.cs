using ContentManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Account
{
    public class Users
    {
        [Key]
        public int? Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Användarnamn")]
        [Required(ErrorMessage =("Användarnamn krävs"))]
        public string UserName { get; set; }

        [Required(ErrorMessage = ("Lösenord krävs"))]
        [Display(Name = "Lösenord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [NotMapped]// Does not effect with your database
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Bekräfta lösenordet")]
        [Compare("Password", ErrorMessage = "Lösenorden matchar inte")]
        public string ConfirmPassword { get; set; }




    }
}
