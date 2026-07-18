// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - RazorSyntax.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.Pages;

public class RazorSyntaxModel(
    ICarRepo repo,
    IMakeRepo makeRepo) : PageModel
{
    [ViewData]
    public SelectList LookupValues { get; set; }

    [ViewData]
    public string Title => "Razor Syntax";

    [BindProperty]
    public Car Entity { get; set; }

    public IActionResult OnGet()
    {
        LookupValues = new(makeRepo.GetAllAsList(), nameof(Make.Id), nameof(Make.Name));
        Entity = repo.Find(6);
        return Page();
    }
}
