using ContentManagement.Models.Account;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.Adverts
{
    public class Adverts_ImageContent
    {
        [Key]
        public int Id { get; set; }
        public DateTime Uploaded { get; set; }
        public string ImgSrc { get; set; }

        public AdvertsModel Advert { get; set; }
        public Users User { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
