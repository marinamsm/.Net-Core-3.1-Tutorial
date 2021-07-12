using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos {
    public class CommandCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string howTo { get; set; }

        [Required]
        [MaxLength(250)]
        public string line { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string platform { get; set; }
    }
}