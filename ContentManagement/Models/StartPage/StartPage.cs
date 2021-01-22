using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace ContentManagement.Models.StartPage
{
    public class StartPage 
    {
        

        [Key]
        public int Id { get; set; }

        public virtual List<StartPage_ImgContent> StartPage_ImgContents { get; set; }
        public virtual List<StartPage_TextContent> StartPage_TextContents { get; set; }
        public virtual List<StartPage_TitleContent> StartPage_TitleContents { get; set; }
    }
}
