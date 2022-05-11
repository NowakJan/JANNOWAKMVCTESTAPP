using System.ComponentModel.DataAnnotations;

namespace JANNOWAKMVCTESTAPP.Models
{
    public class PersonViewModel
    {
        [Display(ResourceType = typeof(Resources.Resources), Name = "strPersonName")]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strFieldRequired")]
        [StringLength(30, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strFieldMaxLength")]
        public string Name { set; get; }

        [Display(ResourceType = typeof(Resources.Resources), Name = "strPersonEmailAddress")]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strFieldRequired")]
        [RegularExpression(@"^[_A-Za-z0-9-]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*(\.[A-Za-z]{2,4})$", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "strPersonEmailAddressIncorrect")]
        public string EmailAddress { set; get; }
    }
}