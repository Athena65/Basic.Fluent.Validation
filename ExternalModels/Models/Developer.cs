using System.ComponentModel.DataAnnotations;

namespace AddingFluent_Validation_toWeb_Api.Models
{
    public class Developer
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public decimal Experience { get; set; }
    }
}
