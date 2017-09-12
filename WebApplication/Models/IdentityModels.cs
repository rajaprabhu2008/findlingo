using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Configuration;

namespace WebApplication.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        public string NameIdentifier { get; set; }
    }
    public class ApplicationUser : CustomIdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            userIdentity.AddClaim(new Claim("WebApplication.Models.RegisterViewModel.NameIdentifier", NameIdentifier));
            userIdentity.AddClaim(new Claim("WebApplication.Models.RegisterViewModel.Email", Email));



           // userIdentity.AddClaim(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier", NameIdentifier));
           //userIdentity.AddClaim( new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", Email));


            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext,Configuration>());
            base.OnModelCreating(modelBuilder);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}