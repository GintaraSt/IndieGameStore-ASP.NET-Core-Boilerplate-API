using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Comment
    {
        [Key]
        public long Id { get; set; }
        public Game? Game { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User? User { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}