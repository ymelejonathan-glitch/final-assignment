using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insurance
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }=string.Empty;

        [Required]
        public string LastName { get; set; }=string.Empty;

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }=string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int CarYear { get; set; }

        [Required]
        public string CarMake { get; set; }=string.Empty;

        [Required]
        public string CarModel { get; set; }=string.Empty;

        public bool DUI { get; set; }

        public int SpeedingTickets { get; set; }

        [Required]
        public string CoverageType { get; set; }=string.Empty;

        public decimal Quote { get; set; }

        public string Code { get; set; }=string.Empty;
    }
}