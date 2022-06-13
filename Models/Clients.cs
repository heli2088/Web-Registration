using System.ComponentModel.DataAnnotations;

namespace WebRegistration.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [Required,EmailAddress, StringLength(50)] 
        public string Email { get; set; } = null!;

        [Required] 
        public Char Gender { get; set; }

       
        [Required,DataType(DataType.Date)]
        [Display(Name = "Date Register ")] 
        public string Dateregistered { get; set; }

        [Required, StringLength(15)]
        [Display(Name = "Selected  days")]
        public string Selectedeventdays { get; set; }

        [Required, StringLength(100)]
        [Display(Name = "Additional Request")]
        public string AdditionalRequest { get; set; }

        


    }
}
