// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Create.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class CreateModel(IAppLogging appLogging, ICarRepo repo, IMakeRepo makeRepo)
  : BasePageModel<Car>(appLogging, repo, "Create")
{
    protected override void GetLookupValues()
    {
        LookupValues = new SelectList(makeRepo.GetAllAsList().OrderBy(m => m.Name),
          nameof(Make.Id),
          nameof(Make.Name));
    }

    public void OnGet()
    {
        GetLookupValues();
        Entity = new Car();
    }

    public IActionResult OnPost() => SaveOneEntityWithLookup(repo.Add);

}
