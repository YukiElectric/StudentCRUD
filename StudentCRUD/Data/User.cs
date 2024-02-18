using Microsoft.AspNetCore.Identity;

namespace StudentCRUD.Data
{
    public class User : IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
    }
}
