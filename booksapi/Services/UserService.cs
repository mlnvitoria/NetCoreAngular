using booksapi.Helpers;
using booksapi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace booksapi.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
    }

    public class UserService : IUserService
    {
        public BooksApiContext _Context { get; set; }
        public UserService(BooksApiContext context)
        {
            _Context = context;
        }


        public async Task<User> Authenticate(string email, string password)
        {
            var user = await Task.Run(() => _Context.Users.SingleOrDefault(x => x.Email == email && x.Password == password));

            // return null if user not found
            if (user == null)
            {
                return null;
            }

            // authentication successful so return user details without password
            return user.WithoutPassword();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.Run(() => _Context.Users.WithoutPasswords());
        }
    }
}