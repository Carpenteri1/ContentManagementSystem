using ContentManagement.Models.EventsModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.FileModel
{
    public class FileModel
    {
        public int Id { get; set; }
        public string fileType { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }
    }
}
