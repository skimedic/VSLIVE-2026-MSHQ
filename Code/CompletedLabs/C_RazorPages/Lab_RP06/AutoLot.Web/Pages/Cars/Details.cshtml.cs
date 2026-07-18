// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Details.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class DetailsModel(
    IAppLogging appLogging,
    ICarRepo repo) : BasePageModel<Car>(appLogging, repo, "Details")
{
    public void OnGet(
        int? id)
    {
        GetOneEntity(id);
    }
}