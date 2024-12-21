public class LibraryService
{
    private readonly LibrariesApi _librariesApi;

    public LibraryService(LibrariesApi librariesApi)
    {
        _librariesApi = librariesApi;
    }

    public async Task<List<LibraryModel>> GetLibrariesAsync(string token)
    {
        _librariesApi.Configuration.DefaultHeader.Add("Authorization", $"Bearer {token}");
        return await _librariesApi.GetAllLibrariesAsync();
    }

    public async Task<List<LibraryItemModel>> GetLibraryItemsAsync(string token, string libraryId)
    {
        _librariesApi.Configuration.DefaultHeader.Add("Authorization", $"Bearer {token}");
        return await _librariesApi.GetLibraryItemsAsync(libraryId);
    }
}