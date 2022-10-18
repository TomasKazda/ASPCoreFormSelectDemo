using System.ComponentModel.DataAnnotations;

namespace ASPCoreFormSelectDemo.Models
{
    public class CodeBook
    {
        public int Id { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
