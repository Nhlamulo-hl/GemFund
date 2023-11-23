using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GemFund.Areas.Identity.Pages.Account
{
    public class Allocate_GoodsModel : PageModel
    {
        public class Allocate_Goods
        {
            public DateTime Date { get; set; }
            public int NumberOfItems { get; set; }
            public string? Category { get; set; }
            public string? Description { get; set; }
            public bool IsAnonymous { get; set; }
        }

    }
    public enum Eroles
    {
        Defalut = 0,
        Clothes = 1,
        Water = 2,

    }
    public enum Erol
    {
        Defalut = 0,
        Storm = 1,
        Fire = 2,

    }
}
