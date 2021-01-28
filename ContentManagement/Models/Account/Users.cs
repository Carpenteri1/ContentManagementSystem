
using ContentManagement.Models.StartPageModels;
using ContentManagement.Models.HeaderModels;
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
        [Required(ErrorMessage = ("Användarnamn krävs"))]
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

        [DataType(DataType.DateTime)]
        public DateTime UserCreated { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastLoggedIn { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Kontotyp")]
        [Required(ErrorMessage = ("Role krävs"))]
        public string UserRole { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Förnamn")]
        [Required(ErrorMessage = ("Användarnamn krävs"))]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Efternamn")]
        [Required(ErrorMessage = ("Användarnamn krävs"))]
        public string Surname { get; set; }

        public DateTime? UserEdited { get; set; }

        public List<StartPage_ImgContents> StartPage_ImgContents { get; set; }
        public List<StartPage_TextContents> StartPage_TextContents { get; set; }
        public List<StartPage_TitleContents> StartPage_Titles { get; set; }
        public List<HeaderTitels> HeaderTitles { get; set; }

    }
}
