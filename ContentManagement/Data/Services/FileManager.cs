using ContentManagement.HelperClasses;
using ContentManagement.Models.FilesModel;
using ContentManagement.UnderPageModels.PageModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ubiety.Dns.Core;

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
        public string CopyToRootFolder(IFormFile fileContent, string folder)
        {
            if (fileContent != null)
            {
                string rootPath = host.WebRootPath;
                string newFileName = CleanUpFileName(Path.GetFileNameWithoutExtension(fileContent.FileName).ToLower());
               
                string extension = Path.GetExtension(fileContent.FileName);
                string path = Path.Combine(rootPath + folder + newFileName + extension);
                string fileUrl = folder + newFileName + extension;

                if (!File.Exists(path))//if file excist, dont copy
                {
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        fileContent.CopyTo(fileStream);
                    }
                }

                return fileUrl;
            }
            return string.Empty;

        }


        private string CleanUpFileName(string filename)
        {
            return filename
                 .Replace("å", "a")
                 .Replace("ä", "a")
                 .Replace("ö", "o")
                 .Replace("ë", "e")
                 .Replace("è", "e")
                 .Replace("é", "e")
                 .Replace("(","")
                 .Replace(")","")
                 .Replace(" ","_");
        }

        public bool UploadAdvertImage(IFormFile file, string folder)
        {
            bool fileUploaded = false;

            if (file != null)
            {
                FileManager manages = new FileManager(context, host);
                var advertImage = context.AdvertImageGallery
                    .Where(img => img.ImgSrc == manages.CopyToRootFolder(file, folder))
                    .FirstOrDefault();//checks if file excist2

                if (advertImage == null)
                {
                    var newImage = new AdvertImageGallery();
                    newImage.ImgSrc = manages.CopyToRootFolder(file, folder);
                    context.Add(newImage);
                    fileUploaded = true;
                }
                else
                {
                    context.Update(advertImage);
                }
            }
            return fileUploaded;

        }

        public bool DeleteAdvertImage(string imgurl)
        {
  
            return RemoveFile(imgurl);
        }

        public string CreateTextFileInRootFolder(string filename,string folder,List<string> listOfIngress)
        {

            if(filename != null)
            {
                string rootPath = host.WebRootPath;
                string path = Path.Combine(rootPath + folder + filename);
                string fileUrl = folder + filename;

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (StreamWriter writer = new StreamWriter(
                Path.Combine(path)))
                {
                    for (int i = 0; i < listOfIngress.Count(); i++)
                    {
                        if (i < listOfIngress.Count() - 1)
                        {
                            writer.Write(listOfIngress[i].Replace("\n", "").Replace(" ", "") + "; ");
                        }
                        else
                        {
                            writer.Write(listOfIngress[i].Replace("\n", "").Replace(" ", ""));
                        }
                    }
                }
                return fileUrl;
            }
            return string.Empty;
        }

        private bool RemoveFile(string imgsrc)
        {
            if (imgsrc != null ||
                imgsrc != string.Empty)
            {
                string path = "wwwroot" + imgsrc;
                if (File.Exists(path))
                {
                    context.Remove(context.AdvertImageGallery.Where(src => src.ImgSrc == imgsrc).FirstOrDefault());
                    File.Delete(path);
                    return true;
                }
            }
            return false;
        }

    }
}
