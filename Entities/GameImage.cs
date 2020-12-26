using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class GameImage
    {
        [Key]
        public long Id { get; set; }
        public Game? Game { get; set; }
        public string Location { get; set; }
        public bool IsThumbnail { get; set; }
        public DateTime Created { get; set; }

    }
}