// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - MenuViewComponent.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.ViewComponents;

public class MenuViewComponent(
    IMakeRepo makeRepo) : ViewComponent
{
   public IViewComponentResult Invoke()
    {
        var makes = makeRepo.GetAllAsList() ?? [];
        return View("MenuView", makes);
    }
    //public async Task<IViewComponentResult> InvokeAsync()
    //{
    //    return await Task.Run<IViewComponentResult>(() =>
    //    {
    //        var makes = makeRepo.GetAllAsList() ?? [];
    //        return View("MenuView", makes);
    //    });
    //}
}
