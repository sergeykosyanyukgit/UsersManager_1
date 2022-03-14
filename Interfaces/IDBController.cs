using System.Collections.Generic;

namespace UsersManager_1.Interfaces
{
    public interface IDBController
    {
        void StartConnection(Form1 form);
        void CreateGroup(string name);
        void CreateUser(string fio, List<int> groups);
        void DeleteUser(int ID_User);
    }
}
