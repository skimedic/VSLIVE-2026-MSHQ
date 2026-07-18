// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Index.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class IndexModel : PageModel
{
    public string MakeName { get; set; }
    public int? MakeId { get; set; }
    public void OnGet(int? makeId, string makeName)
    {
        MakeId = makeId;
        MakeName = makeName;
    }
}
