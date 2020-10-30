using Microsoft.AspNetCore.Mvc;

namespace TaxSystemNASS.Models
{
    public class UserProfileViewModel : Controller
    {
        public string EmailAddress { get; set; }

        public string Name { get; set; }

        public string ProfileImage { get; set; }
    }
}