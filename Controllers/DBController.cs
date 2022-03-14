using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using UsersManager_1.DTO;
using UsersManager_1.Helpers;
using UsersManager_1.Interfaces;

namespace UsersManager_1
{
    public class DBController: IDBController
    {
        private SqlConnection Connection { get; set; }
        public void StartConnection()
        {
            var connection = new SqlConnection(DBHelper.Connection);
            try
            {
                connection.Open();
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
                }
            }
        }

        public List<Group> RefreshGroups()
        {
            var groups = new List<Group>();
            var command = new SqlCommand(DBHelper.GetGroupsExpression, Connection);
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
        }
        public List<User> RefreshUsers()
        {
            var users = new List<User>();
            var command = new SqlCommand(DBHelper.GetUsersExpression, Connection);
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
        }

        public void DeleteUser(int ID_User)
        {
            var command = new SqlCommand(DBHelper.DeleteUserExpression, Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID_User", ID_User);
            var reader = command.ExecuteReader();
            reader.Close();
        }
    }
}
