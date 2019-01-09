using Microsoft.AspNetCore.Identity;

namespace shoplet.Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the shopletUser class
    public class ShopletUser : IdentityUser
    {
        public string Address { get; set; }
    }
}
