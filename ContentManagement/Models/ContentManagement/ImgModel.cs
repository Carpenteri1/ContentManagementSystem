using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.ContentManagement
{
    public class ImgModel
    {
       public string imgSrc { get; set; }
       public int imgHeight { get; set; }
       public int imgWidth { get; set; }
       public string altImg { get; set; } // if img cant be loaded
    }
}
