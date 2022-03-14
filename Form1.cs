using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersManager_1.DTO;
using UsersManager_1.Interfaces;

namespace UsersManager_1
{
    public partial class Form1 : Form
    {
        private List<int> SelectedNewUsergroups { get; set; }
        private List<Group> Groups { get; set; }
        private IDBController dBController;
        public Form1()
        {
            SelectedNewUsergroups = new List<int>();
            InitializeComponent();
            dBController = new DBController();
            StartConnection();
        }

        private void StartConnection()
        {
            try
            {
                dBController.StartConnection();
                UpdateGroups(dBController.RefreshGroups());
                UpdateUsers(dBController.RefreshUsers());
                AddGroupButton.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateGroups(List<Group> groups)
        {
            Groups = groups;
            groupsGridView.DataSource = groups;
            groupsGridView.Columns[0].HeaderText = "ID группы";
            groupsGridView.Columns[1].HeaderText = "Название группы";
            groupsGridView.Columns[2].HeaderText = "Сотрудников в группе";

            userGroupsListBox.Items.Clear();
            foreach(var group in groups)
            {
                userGroupsListBox.Items.Add(group, false);
            }
        }


        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            dBController.CreateGroup(newGroupName.Text);
            UpdateGroups(dBController.RefreshGroups());
            newGroupName.Text = "";
            AddGroupButton.Enabled = false;
        }

        private void newGroupName_TextChanged(object sender, EventArgs e)
        {
            AddGroupButton.Enabled = newGroupName.Text.Length > 0;
        }

        public void UpdateUsers(List<User> users)
        {
            usersGridView.DataSource = users;
            usersGridView.Columns[0].HeaderText = "ID сотрудника";
            usersGridView.Columns[1].HeaderText = "ФИО сотрудника";
            usersGridView.Columns[2].HeaderText = "Входит в группы";
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            SelectedNewUsergroups.Clear();
            foreach (var item in userGroupsListBox.CheckedItems)
            {
                Group group = (Group)Convert.ChangeType(item, typeof(Group));
                SelectedNewUsergroups.Add(group.Id);
            }

            dBController.CreateUser(userName.Text, SelectedNewUsergroups);
            UpdateUsers(dBController.RefreshUsers());
            UpdateGroups(dBController.RefreshGroups());

            userGroupsListBox.Items.Clear();
            foreach (var group in Groups)
            {
                userGroupsListBox.Items.Add(group, false);
            }
            userName.Text = "";
            addUser.Enabled = false;
        }
        private void usersGridView_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var userToDeleteId = Convert.ToInt32(usersGridView.Rows[e.RowIndex].Cells[0].Value);
                dBController.DeleteUser(userToDeleteId);
                UpdateUsers(dBController.RefreshUsers());
                UpdateGroups(dBController.RefreshGroups());
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            addUser.Enabled = userName.Text.Length > 0;
        }
    }
}
