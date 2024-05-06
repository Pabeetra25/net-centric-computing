using System.ComponentModel.DataAnnotations;

namespace PlayerValidation.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(18, 40)]
        public int Age { get; set; }

    }
}
