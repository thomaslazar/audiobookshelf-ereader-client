public class DetailsModel : PageModel
{
    private readonly LibraryItemService _libraryItemService;

    public LibraryItemModel Item { get; set; }
    public string DownloadLink { get; set; }

    public DetailsModel(LibraryItemService libraryItemService)
    {
        _libraryItemService = libraryItemService;
    }

    public async Task OnGetAsync(string id)
    {
        var token = Request.Cookies["AuthToken"];
        if (token == null)
        {
            Response.Redirect("/Login");
            return;
        }

        Item = await _libraryItemService.GetItemDetailsAsync(token, id);
        DownloadLink = _libraryItemService.GetDownloadLink(id);
    }
}