using System.ComponentModel.DataAnnotations;

namespace ASPCoreFormSelectDemo.Models
{
    public class HumanIm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int EyeColor { get; set; }
        [Required]
        public EnumData ShoeSize { get; set; }
    }
}
