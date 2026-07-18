// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - BasePageModel.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2026/07/13
// ==================================

namespace AutoLot.Web.Pages.Base;

public abstract class BasePageModel<TEntity>(
    IAppLogging appLogging,
    IBaseRepo<TEntity> baseRepo,
    string pageTitle) : PageModel where TEntity : BaseEntity, new()
{
    protected readonly IAppLogging AppLoggingInstance = appLogging;
    protected readonly IBaseRepo<TEntity> BaseRepoInstance = baseRepo;

    [ViewData]
    public string Title { get; init; } = pageTitle;

    [BindProperty]
    public TEntity Entity { get; set; }

    public SelectList LookupValues { get; set; }
    public string Error { get; set; }
    protected virtual void GetLookupValues() => LookupValues = null;

    protected virtual void GetOneEntity(
        int? id)
    {
        if (!id.HasValue)
        {
            Entity = null;
            Error = "Invalid Request";
            return;
        }

        Entity = BaseRepoInstance.Find(id);
        Error = Entity == null ? "Not found" : string.Empty;
    }

    protected virtual IActionResult SaveOneEntity(
        Func<TEntity, bool, int> saveFunction)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _ = saveFunction(Entity, true);
        return RedirectToPage("Details", new
        {
            id = Entity.Id
        });
    }

    protected virtual IActionResult SaveOneEntityWithLookup(
        Func<TEntity, bool, int> saveFunction)
    {
        if (!ModelState.IsValid)
        {
            GetLookupValues();
            return Page();
        }

        _ = saveFunction(Entity, true);
        return RedirectToPage("Details", new
        {
            id = Entity.Id
        });
    }

    protected virtual IActionResult DeleteOneEntity(
        int id)
    {
        if (Entity == null || Entity.Id != id)
        {
            Error = "Invalid Request";
            return BadRequest();
        }
        BaseRepoInstance.Delete(Entity);
        Error = string.Empty;
        return RedirectToPage("Index");
    }
}