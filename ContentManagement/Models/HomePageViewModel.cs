using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMV.Models
{
    public class HomePageViewModel
    {
        private readonly string  title = "Home Page Title";
        public string Title { get{return title;} }
        public int Id { get; set; }

    }
}
