using System.ComponentModel.DataAnnotations;

namespace ASPCoreFormSelectDemo.Models
{
    public class Human
    {
        public int HumanId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public CodeBook EyeColor { get; set; }
        [Required]
        public EnumData ShoeSize { get; set; }
    }
}
