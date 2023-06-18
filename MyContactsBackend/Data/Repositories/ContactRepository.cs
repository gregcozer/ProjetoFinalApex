using Data.InterFaces;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public void CreateContact()
        {
            
        }

        public void DeleteContact()
        {
           
        }

        public List<string> GetContact()
        {
            return new List<string>(){ "joao", "maria"};
        }

        public void UpdateContact()
        {
           
        }
    }
}
