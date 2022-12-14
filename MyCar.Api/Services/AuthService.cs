using MyCar.Api.Repository;

namespace MyCar.Api.Services
{
    public class AuthService
    {
        

        public bool Login(string username, string password)
        {
            var Auth = new DummyAuthRepository();
            {
                var user = Auth.GetUser(username);
                if (user != null)
                {
                    if (user.Password == password && user.IsActive == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
               else { return false; }


            }
        }
    }
}