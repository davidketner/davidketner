using Microsoft.AspNetCore.Identity;

namespace davidketner.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string FullName => $"{FirstName} {LastName}";
    }
}
