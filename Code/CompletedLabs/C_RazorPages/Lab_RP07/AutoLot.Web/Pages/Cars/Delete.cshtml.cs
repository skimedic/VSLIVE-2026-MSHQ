// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Delete.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class DeleteModel(
    IAppLogging appLogging,
    ICarRepo repo) : BasePageModel<Car>(appLogging, repo, "Delete")
{
    public void OnGet(
        int? id)
    {
        GetOneEntity(id);
    }

    public IActionResult OnPost(
        int id) =>
        DeleteOneEntity(id);
}