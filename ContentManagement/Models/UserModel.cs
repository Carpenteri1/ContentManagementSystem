using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ContentManagement.Data;
using MySql.Data.MySqlClient;

namespace ContentManagement.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is requered")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")] 
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }

}

