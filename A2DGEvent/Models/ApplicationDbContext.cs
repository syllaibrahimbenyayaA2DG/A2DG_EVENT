using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace A2DGEvent.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}