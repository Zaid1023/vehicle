using MyCar.Api.Models;

namespace MyCar.Api.Repository
{
    public interface IAuthRepository
    {
        User GetUser(string username);
        User GetUser(string username , string pass);
    }

}
