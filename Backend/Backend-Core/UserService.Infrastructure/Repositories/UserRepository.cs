public class UserRepository : IUserRepository
{
    private readonly UserDbContext _context;
    private readonly IUserService _userService;

    public UserRepository(UserServiceDbContext context, IUserService userService)
    {
        _context = context;
        _userService = userService;
    }

    public Task<bool> ValidateUserExist (string email)
    {
        return await _context.User.AnyAsync(u => u.Email == email);
    }

    Task<User> GetUserByIdAsync(int id);
    Task<User> GetUserByEmailAsync(string email);
    //Task<User> CreateUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<bool> DeleteUserAsync(int id);

    public async Task<User> CreateUserAsync (User user)
    {
        if (await ValidateUserExist(user.Email))
        {
            throw new Exception("User already exists");
        }
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User> UpdateUserAsync(User user)
}

