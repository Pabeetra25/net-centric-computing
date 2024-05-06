using System.ComponentModel.DataAnnotations;

namespace ToValidatePlayerInfo.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string ?Name { get; set; }
        [Range(18, 40)]
        public int Age { get; set; }

    }
}
