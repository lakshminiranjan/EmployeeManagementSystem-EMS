using Microsoft.AspNetCore.Identity;
namespace EMS_Server.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}
