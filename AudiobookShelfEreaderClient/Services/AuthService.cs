public class AuthService
{
    private readonly ServerApi _serverApi;

    public AuthService(ServerApi serverApi)
    {
        _serverApi = serverApi;
    }

    public async Task<string> LoginAsync(string username, string password)
    {
        var request = new LoginRequestModel
        {
            Username = username,
            Password = password
        };

        var response = await _serverApi.LoginAsync(request);

        if (response.Token == null)
            throw new Exception("Login failed. Please check your credentials.");

        return response.Token;
    }
}