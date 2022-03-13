using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using UsersManager_1.DTO;
using UsersManager_1.Helpers;

namespace UsersManager_1
{
    public class DBController
    {
        private SqlConnection Connection { get; set; }
        private Form1 Form { get; set; }
        public async Task StartConnection(Form1 form)
        {
            Form = form;
            var connection = new SqlConnection(DBHelper.Connection);
            try
            {
                await connection.OpenAsync();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    Connection = connection;
                    Form.UpdateGroups(RefreshGroups(connection));
                    Form.UpdateUsers(RefreshUsers(connection));
                }
            }
        }

        public List<Group> RefreshGroups(SqlConnection connection)
        {
            var groups = new List<Group>();
            var command = new SqlCommand(DBHelper.GetGroupsExpression, connection);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    groups.Add(new Group() {
                        Id = (int)reader.GetValue(0),
                        Description = (string)reader.GetValue(1),
                        UsersCount = (int)reader.GetValue(2)
                    });
                }
            }
            reader.Close();
            return groups;
        }
        public void CreateGroup(string name)
        {
            var command = new SqlCommand(DBHelper.CreateGroupExpression, Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@desc", name);

            var reader = command.ExecuteReader();
            reader.Close();

            Form.UpdateGroups(RefreshGroups(Connection));
        }
        public List<User> RefreshUsers(SqlConnection connection)
        {
            var users = new List<User>();
            var command = new SqlCommand(DBHelper.GetUsersExpression, connection);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    users.Add(new User()
                    {
                        Id = (int)reader.GetValue(0),
                        Fio = (string)reader.GetValue(1),
                        Groups = reader.GetValue(2) is DBNull ? "" : (string)reader.GetValue(2)
                    });
                }
            }
            reader.Close();
            return users;
        }

        public void CreateUser(string fio, List<int> groups)
        {
            var table = new DataTable();
            table.Columns.Add("id", typeof(int));
            foreach(var item in groups)
            {
                table.Rows.Add(item);
            }

            var command = new SqlCommand(DBHelper.CreateUserExpression, Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@fio", fio);
            var pList = new SqlParameter("@groups_list", SqlDbType.Structured);
            pList.TypeName = "id_list";
            pList.Value = table;

            command.Parameters.Add(pList);
            var reader = command.ExecuteReader();
            reader.Close();
            Form.UpdateUsers(RefreshUsers(Connection));
            Form.UpdateGroups(RefreshGroups(Connection));
        }

        public void DeleteUser(int ID_User)
        {
            var command = new SqlCommand(DBHelper.DeleteUserExpression, Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID_User", ID_User);
            var reader = command.ExecuteReader();
            reader.Close();
            Form.UpdateUsers(RefreshUsers(Connection));
            Form.UpdateGroups(RefreshGroups(Connection));
        }
    }
}
