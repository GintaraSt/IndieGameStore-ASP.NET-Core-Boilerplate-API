using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Game
    {
        [Key]
        public long Id { get; set; }
        public User? User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PricingType { get; set; }
        public float Price { get; set; }
        public float MinDonation { get; set; }
        public float MaxDonation { get; set; }
        public string FileLocation { get; set; }
        public float AverageRaiting { get; set; }
        public int DownloadCount { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}