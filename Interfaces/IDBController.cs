using System.Collections.Generic;
using UsersManager_1.DTO;

namespace UsersManager_1.Interfaces
{
    public interface IDBController
    {
        void StartConnection();
        void CreateGroup(string name);
        void CreateUser(string fio, List<int> groups);
        void DeleteUser(int ID_User);
        List<Group> RefreshGroups();
        List<User> RefreshUsers();
    }
}
