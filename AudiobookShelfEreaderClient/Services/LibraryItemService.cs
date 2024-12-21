public class LibraryItemService
{
    private readonly LibraryItemsApi _libraryItemsApi;

    public LibraryItemService(LibraryItemsApi libraryItemsApi)
    {
        _libraryItemsApi = libraryItemsApi;
    }

    public async Task<LibraryItemModel> GetItemDetailsAsync(string token, string itemId)
    {
        _libraryItemsApi.Configuration.DefaultHeader.Add("Authorization", $"Bearer {token}");
        return await _libraryItemsApi.GetLibraryItemAsync(itemId);
    }

    public string GetDownloadLink(string itemId)
    {
        return _libraryItemsApi.GetEBookDownloadLink(itemId);
    }
}