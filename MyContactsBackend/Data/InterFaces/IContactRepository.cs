using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.InterFaces
{
    public interface IContactRepository
    {
        Task CreateAsync(Contact contact);
        Task<List<Contact>> GetAllByUserIdAsync(int userId);
        Task<Contact> GetByIdAsync(int id);
        void Update(Contact contact);
        void Delete(Contact contact);
        Task SaveChangesAsync();
        
    }
}
