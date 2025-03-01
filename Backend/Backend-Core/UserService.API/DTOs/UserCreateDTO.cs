public class UserCreateDTO
{
    public string Name { get; set; } = string.Empty!;

    public string Email { get; set; } = string.Empty!;

    public string Password { get; set; } = string.Empty!;

    public string? LanguagePreference { get; set; }

    public int UserType { set; } = 0;
}
