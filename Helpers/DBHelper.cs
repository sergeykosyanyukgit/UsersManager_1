namespace UsersManager_1.Helpers
{
    public static class DBHelper
    {
        public const string Connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sergey\source\repos\UsersManager_1\UsersManagerDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public const string GetGroupsExpression = "GetGroups";
        public const string CreateGroupExpression = "CreateGroup";
        public const string GetUsersExpression = "GetUsers";
        public const string CreateUserExpression = "CreateUser";
        public const string DeleteUserExpression = "DeleteUser";
    }
}
