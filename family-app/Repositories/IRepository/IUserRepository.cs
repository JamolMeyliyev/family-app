using family_app.Entities.Account;

namespace family_app.Repositories.IRepository;

public interface IUserRepository
{
    ValueTask SignUp(User user);
    ValueTask<string> SignIn(User user);
    ValueTask<User> Profile();
    ValueTask Logout(User user);

}
