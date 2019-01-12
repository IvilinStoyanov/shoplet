using Microsoft.AspNetCore.Identity;

namespace shoplet.Data.Models
{
    // Add profile data for application users by adding properties to the shopletUser class
    public class ShopletUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }
}
