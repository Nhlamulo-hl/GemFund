using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GemFund.Areas.Identity.Pages.Account
{
    public class Allocate_MoneyModel : PageModel
    {
        public void OnGet()
        { }
            public decimal Amount { get; set; }

        public bool Anonymous { get; set; }
    }
    }

