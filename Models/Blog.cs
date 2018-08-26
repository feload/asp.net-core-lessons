using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreLessons.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }
}