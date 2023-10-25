using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationFoundation.Models
{
    public class Donation
    {
        [Key]

        public int DonationId { get; set; }

        public string Date { get; set; }

        public int NumberOfItems { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    }
}
