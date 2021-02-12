using ContentManagement.UnderPageModels.PageModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Data.Services
{
    public class FileManager
    {

        private readonly CMSDbContext context;
        private readonly IWebHostEnvironment host;
        public FileManager(CMSDbContext context, IWebHostEnvironment host)
        {
            this.context = context;
            this.host = host;
        }


        public string CopyToRootFolder(IFormFile fileContent,string folder)
        {
            if (fileContent != null)
            {
                string rootPath = host.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(fileContent.FileName);
                string extension = Path.GetExtension(fileContent.FileName);
                string path = Path.Combine(rootPath + folder + fileName + extension);
                string imgUrl = folder + fileName + extension;

                if (!File.Exists(path))//if file excist, dont copy
                {
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        fileContent.CopyTo(fileStream);
                    }
                }

                return imgUrl;
            }
            return string.Empty;

        }
    }
}
