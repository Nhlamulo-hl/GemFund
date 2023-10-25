using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using static GemFund.Areas.Identity.Pages.Account.ViewListModel;

namespace GemFund.Areas.Identity.Pages.Account
{
    public class ViewListModel : PageModel
    {
        public void OnGet()
        { }
        
public class Donations
        {
            public int Id { get; set; }
            public string Donor { get; set; }
            public decimal Amount { get; set; }
            
        }

        
        public class GoodDonations
        {
            public int Id { get; set; }
            public string Donor { get; set; }
            public string Item { get; set; }
            
        }

        
        public class Disaster
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
            
        }

    }
}
// ApplicationDbContext.cs
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Donations> Donations { get; set; }
    public DbSet<GoodDonations> GoodDonations { get; set; }
    public DbSet<Disaster> Disaster { get; set; }
}

