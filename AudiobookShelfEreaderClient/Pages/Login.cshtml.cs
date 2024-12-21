public class LoginModel : PageModel
{
    private readonly AuthService _authService;

    [BindProperty]
    public string Username { get; set; }
    [BindProperty]
    public string Password { get; set; }

    public LoginModel(AuthService authService)
    {
        _authService = authService;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        try
        {
            var token = await _authService.LoginAsync(Username, Password);

            Response.Cookies.Append("AuthToken", token, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                Expires = DateTime.UtcNow.AddDays(14)
            });

            return RedirectToPage("/Index");
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return Page();
        }
    }
}