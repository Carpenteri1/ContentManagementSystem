using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.ContentManagement
{
    public class TextContentModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Content is requered in the text field")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Content name is requered")]
        public string ContentName { get; set; }

    }
}
