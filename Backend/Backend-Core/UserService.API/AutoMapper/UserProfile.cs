public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDTO>();
        CreateMap<UserDTO, User>();
        CreateMap<CreateUserDTO, User>();
        CreateMap<UserUpdateDTO, User>();
    }
}
