using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GemFund.Areas.Identity.Pages.Account
{
    public class PurchaseGoodsModel : PageModel
    {
        public decimal Amount { get; set; }
        public string? ActiveDisaster { get; set; }
    }
}
