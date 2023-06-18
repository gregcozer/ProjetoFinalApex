using System.Collections.Generic;

namespace Data.InterFaces
{
    public interface IContactRepository
    {
        void CreateContact();
        List<string> GetContact();
        void UpdateContact();
        void DeleteContact();   

    }
}
