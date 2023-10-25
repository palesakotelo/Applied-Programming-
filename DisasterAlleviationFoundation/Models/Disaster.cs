using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationFoundation.Models
{
    public class Disaster
    {
        [Key]

        public int DisasterId { get; set; }

        public string DisasterName { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }
    }
}
