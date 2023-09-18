using family_app.Entities.Account;
using family_app.Repositories.IRepository;

namespace family_app.Repositories.Repository;

public class UserRepository : IUserRepository
{
    public ValueTask Logout(User user)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> Profile()
    {
        throw new NotImplementedException();
    }

    public ValueTask<string> SignIn(User user)
    {
        throw new NotImplementedException();
    }

    public ValueTask SignUp(User user)
    {
       
    }
}
