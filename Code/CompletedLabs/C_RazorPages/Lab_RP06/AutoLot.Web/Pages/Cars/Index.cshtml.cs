// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Index.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class IndexModel(
    IAppLogging appLogging,
    ICarRepo repo) : BasePageModel<Car>(appLogging, repo, "Inventory")
{
    public string MakeName { get; set; }
    public int? MakeId { get; set; }
    public IList<Car> CarRecords { get; set; }

    public void OnGet(
        int? makeId,
        string makeName)
    {
        MakeId = makeId;
        if (!makeId.HasValue)
        {
            MakeName = "All Makes";
            CarRecords = repo.GetAllIgnoreQueryFiltersAsList();
            return;
        }

        MakeName = makeName;
        CarRecords = repo.GetAllByAsList(makeId.Value);
    }
}