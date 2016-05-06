using Microsoft.AspNet.Identity.EntityFramework;

namespace TrainApi
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("name=TrainAuth")
        {
     
        }
    }

}