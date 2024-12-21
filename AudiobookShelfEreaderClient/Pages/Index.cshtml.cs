public class IndexModel : PageModel
{
    private readonly LibraryService _libraryService;

    public List<LibraryModel> Libraries { get; set; } = new();
    public List<LibraryItemModel> Items { get; set; } = new();
    public string SelectedLibraryId { get; set; }

    public IndexModel(LibraryService libraryService)
    {
        _libraryService = libraryService;
    }

    public async Task OnGetAsync(string selectedLibraryId = null)
    {
        var token = Request.Cookies["AuthToken"];
        if (token == null)
        {
            Response.Redirect("/Login");
            return;
        }

        Libraries = await _libraryService.GetLibrariesAsync(token);

        SelectedLibraryId = selectedLibraryId;
        if (!string.IsNullOrEmpty(selectedLibraryId))
        {
            Items = await _libraryService.GetLibraryItemsAsync(token, selectedLibraryId);
        }
    }
}