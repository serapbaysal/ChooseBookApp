using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChooseBookApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId{ get; set; }
    }
}