using Data.InterFaces;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser()
        {
          
        }

        public void DeleteUser()
        {
            
        }

        public List<string> GetUsers()
        {
            return new List<string>() { "joao", "maria"};
        }

        public void UpdateUser()
        {
            
        }
    }
}
