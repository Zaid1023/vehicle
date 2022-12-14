using MyCar.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyCar.Api.Repository
{
    public class DummyAuthRepository : IAuthRepository
    {
        List<User> _users = new List<User>
        {/*
            new User{ Id = 1, UserName ="zaid", Password=  "1234", IsActive=true},
            new User{ Id = 2, UserName ="admin", Password=  "6789", IsActive=true},
           new User{ Id = 3, UserName ="testuser", Password=  "1526", IsActive=false}*/
        };


        public User GetUser(string username)

        {
            using (var db = new MainDbContext())
            {
                var user = db.Users.Where(u => u.UserName == username).FirstOrDefault();
                return user;
            }
        }

        public User GetUser(string username, string pass)
        {
            using (var db = new MainDbContext())
            {
                var user = db.Users.FirstOrDefault(f => f.UserName == username && f.Password == pass);
                return user;
            }
        }
    }
}
