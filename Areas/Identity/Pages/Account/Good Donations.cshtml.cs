using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GemFund.Areas.Identity.Pages.Account
{
    public class Good_DonationsModel : PageModel
    {
        public class Donation
        {
            public DateTime Date { get; set; }
            public int NumberOfItems { get; set; }
            public string? Category { get; set; }
            public string? Description { get; set; }
            public bool IsAnonymous { get; set; }
        }

    }
    public enum Erole
    {
        Defalut = 0,
        Clothes = 1,
        Foods = 2,

    }
}

