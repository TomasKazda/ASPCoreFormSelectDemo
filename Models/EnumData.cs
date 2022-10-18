using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPCoreFormSelectDemo.Models
{
    public enum EnumData
    {
        [Display(Name="Large")]
        L,
        [Display(Name = "Medium")]
        M,
        [Display(Name = "Small")]
        S,
    }
}
