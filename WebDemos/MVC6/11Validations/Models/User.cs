using System.ComponentModel.DataAnnotations;

namespace _11Validations.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name can not be empty")]
        [StringLength(15, MinimumLength = 3,
            ErrorMessage = "Name should be min 3 and mx 8 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is must")]
        //[EmailAddress]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is must")]
        [Range(18, 68, ErrorMessage = "Age must be within range 18 to 68")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Password is must")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "pwd - min 8 char with one Uppercase,Lowercase, Numbers, Symbals")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is must")]
        [Compare("Password", ErrorMessage = "Password does not match!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Mobile no is must")]
        [RegularExpression(@"^\+91\s?[6-9]\d{9}$", ErrorMessage = "Incorrect Mobile No")]
        [Display(Name = "Mobile:")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Website URL is compulsory")]
        [Url(ErrorMessage = "Invalid Url")]
        public string WebSiteURL { get; set; }

        [MaxLength(10, ErrorMessage = "max 20 char allowed")]
        [MinLength(5, ErrorMessage = "min 5 char required")]
        [Display(Name = "Ask your query here:")]
        public string Query { get; set; }
    }
}
