// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Edit.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class EditModel(
    IAppLogging appLogging,
    ICarRepo repo,
    IMakeRepo makeRepo) : BasePageModel<Car>(appLogging, repo, "Edit")
{
    protected override void GetLookupValues()
    {
        LookupValues =
            new SelectList(makeRepo.GetAllAsList()
                .OrderBy(m => m.Name), nameof(Make.Id), nameof(Make.Name));
    }

    public void OnGet(
        int? id)
    {
        GetOneEntity(id);
        GetLookupValues();
    }

    public IActionResult OnPost(
        int id) =>
        SaveOneEntityWithLookup(repo.Update);
}