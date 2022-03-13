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
namespace UsersManager_1
{
    public partial class Form1 : Form
    {
        public List<int> SelectedNewUsergroups { get; set; }
        public List<Group> Groups { get; set; }
        public List<User> Users { get; set; }
        private BindingList<User> blUser = new BindingList<User>();
        private int rowIndex;
        private DBController dBController;
        public Form1()
        {
            SelectedNewUsergroups = new List<int>();
            InitializeComponent();
            dBController = new DBController();
            StartConnection(this);
        }

        private async void StartConnection(Form1 form)
        {
            try
            {
                await dBController.StartConnection(form);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateGroups(List<Group> groups)
        {
            this.Groups = groups;
            dataGridView1.DataSource = groups;
            dataGridView1.Columns[0].HeaderText = "ID группы";
            dataGridView1.Columns[1].HeaderText = "Название группы";
            dataGridView1.Columns[2].HeaderText = "Сотрудников в группе";

            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            this.checkedListBox1.Items.Clear();
            foreach(var group in groups)
            {
                this.checkedListBox1.Items.Add(group, false);
            }
        }


        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            dBController.CreateGroup(this.newGroupName.Text);
            this.newGroupName.Text = "";
            this.AddGroupButton.Enabled = false;
        }

        private void newGroupName_TextChanged(object sender, EventArgs e)
        {
            if (this.newGroupName.Text.Length > 0)
            {
                this.AddGroupButton.Enabled = true;
            }
            else
            {
                this.AddGroupButton.Enabled = false;
            }
        }

        public void UpdateUsers(List<User> users)
        {
            this.Users = users;
            blUser.Clear();
            foreach (var user in users)
            {
                blUser.Add(user);
            }
            dataGridView2.DataSource = blUser;
            dataGridView2.Columns[0].HeaderText = "ID сотрудника";
            dataGridView2.Columns[1].HeaderText = "ФИО сотрудника";
            dataGridView2.Columns[2].HeaderText = "Входит в группы";

            dataGridView2.Columns[0].Width = 110;
            dataGridView2.Columns[1].Width = 140;
            dataGridView2.Columns[2].Width = 150;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SelectedNewUsergroups.Clear();
            foreach (var item in this.checkedListBox1.CheckedItems)
            {
                Group group = (Group)Convert.ChangeType(item, typeof(Group));
                SelectedNewUsergroups.Add(group.Id);
            }

            dBController.CreateUser(this.textBox1.Text, SelectedNewUsergroups);

            this.checkedListBox1.Items.Clear();
            foreach (var group in this.Groups)
            {
                this.checkedListBox1.Items.Add(group, false);
            }
            this.textBox1.Text = "";
            this.button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AddGroupButton.Enabled = false;
        }
        private void dataGridView2_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                /*var rowIndex = e.RowIndex;
                this.dataGridView2.Rows.RemoveAt(rowIndex);*/
                this.dataGridView2.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                this.dataGridView2.CurrentCell = this.dataGridView2.Rows[e.RowIndex].Cells[0];
                this.contextMenuStrip1.Show(this.dataGridView2, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if(this.textBox1.Text.Length > 0)
            {
                this.button2.Enabled = true;
            }
            else
            {
                this.button2.Enabled = false;
            }
        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Rows.RemoveAt(rowIndex);
            for (int index = 0; index < Users.Count; index++)
            {
                if(blUser.IndexOf(Users[index]) == -1)
                {
                    dBController.DeleteUser(Users[index].Id);
                }
            }
        }
    }
}
