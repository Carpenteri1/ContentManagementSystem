﻿using ContentManagement.Models.Account;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagement.Models.ContentManagement
{
    public class TextContentModel
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text)]
        public string Content { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }

        public ICollection<MergedContent> MergedContents { get; set; }
    }
}
