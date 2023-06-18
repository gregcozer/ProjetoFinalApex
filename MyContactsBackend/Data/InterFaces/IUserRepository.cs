using System.Collections.Generic;

namespace Data.InterFaces
{
    public interface IUserRepository
    {
        void CreateUser();
        List<string> GetUsers();
        void UpdateUser();
        void DeleteUser();
       
    }
}
