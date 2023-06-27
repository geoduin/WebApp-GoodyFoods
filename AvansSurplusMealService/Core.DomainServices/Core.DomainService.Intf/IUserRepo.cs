using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainServices.Core.DomainService.Intf
{
    public interface IUserRepo<T>
    {
        T GetUserByEmail(string Email);
        T GetUserFromDbById(int id);
        
        void CreateUser(T user);
        bool UpdateUser(T user);
        void DeleteUser(T user);

        List<T> GetAllUsers();
        List<T> GetAllLocalUsers();

        T GetUserByIndex(int index);
        T GetUserById(int id);
    }
}
