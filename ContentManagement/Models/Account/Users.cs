
using ContentManagement.HeaderModel;
using ContentManagement.StartPageModels.PageModel;
using ContentManagement.UnderPageModels.PageModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.EventsModel;
using ContentManagement.Models.Adverts;

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
        [Display(Name = "Bekräfta lösenord")]
        [Required(ErrorMessage = "Bekräfta lösenordet")]
        [Compare("Password", ErrorMessage = "Lösenorden matchar inte")]
        public string ConfirmPassword { get; set; }


        [DataType(DataType.Password)]
        [NotMapped]
        [Display(Name = "Gamla lösenordet")]
        [Required(ErrorMessage = "Lösenord krävs")]
        public string TempPassword { get; set; }//when creating a new password

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
        public List<StartPage_Links> StartPage_Links { get; set; }

        public List<UnderPage> UnderPages { get; set; }
        public List<UnderPage_ImgContents> UnderPage_ImgContents { get; set; }
        public List<UnderPage_TextContents> UnderPage_TextContents { get; set; }
        public List<UnderPage_TitleContents> UnderPage_Titles { get; set; }

        public List<AdvertsModel> Adverts { get; set; }
        public List<EventModel> Events { get; set; }
        public List<EventLinkModel> EventLinks { get; set; }
     }
}
