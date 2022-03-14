namespace UsersManager_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addGroupLabel = new System.Windows.Forms.Label();
            this.newGroupName = new System.Windows.Forms.TextBox();
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.TextBox();
            this.addUser = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.userGroupsListBox = new System.Windows.Forms.CheckedListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupsGridView
            // 
            this.groupsGridView.AllowUserToAddRows = false;
            this.groupsGridView.AllowUserToDeleteRows = false;
            this.groupsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.groupsGridView.BackgroundColor = System.Drawing.Color.White;
            this.groupsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupsGridView.Location = new System.Drawing.Point(5, 21);
            this.groupsGridView.Name = "groupsGridView";
            this.groupsGridView.ReadOnly = true;
            this.groupsGridView.RowHeadersVisible = false;
            this.groupsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.groupsGridView.Size = new System.Drawing.Size(436, 109);
            this.groupsGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группы";
            // 
            // addGroupLabel
            // 
            this.addGroupLabel.AutoSize = true;
            this.addGroupLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGroupLabel.Location = new System.Drawing.Point(5, 5);
            this.addGroupLabel.Name = "addGroupLabel";
            this.addGroupLabel.Size = new System.Drawing.Size(109, 13);
            this.addGroupLabel.TabIndex = 4;
            this.addGroupLabel.Text = "Добавление группы";
            // 
            // newGroupName
            // 
            this.newGroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.newGroupName.Location = new System.Drawing.Point(101, 5);
            this.newGroupName.Name = "newGroupName";
            this.newGroupName.Size = new System.Drawing.Size(330, 20);
            this.newGroupName.TabIndex = 5;
            this.newGroupName.TextChanged += new System.EventHandler(this.newGroupName_TextChanged);
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupNameLabel.Location = new System.Drawing.Point(5, 5);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupNameLabel.Size = new System.Drawing.Size(96, 16);
            this.groupNameLabel.TabIndex = 6;
            this.groupNameLabel.Text = "Название группы";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.addGroupLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(446, 83);
            this.panel1.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.AddGroupButton);
            this.panel6.Controls.Add(this.newGroupName);
            this.panel6.Controls.Add(this.groupNameLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(5, 21);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(436, 57);
            this.panel6.TabIndex = 8;
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddGroupButton.Location = new System.Drawing.Point(101, 32);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(330, 20);
            this.AddGroupButton.TabIndex = 7;
            this.AddGroupButton.Text = "Добавить группу";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupsGridView);
            this.panel2.Location = new System.Drawing.Point(5, 89);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(446, 135);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.usersGridView);
            this.panel3.Location = new System.Drawing.Point(5, 225);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(446, 136);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сотрудники";
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usersGridView.BackgroundColor = System.Drawing.Color.White;
            this.usersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Location = new System.Drawing.Point(5, 21);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.usersGridView.Size = new System.Drawing.Size(436, 110);
            this.usersGridView.TabIndex = 1;
            this.usersGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.usersGridView_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.addUserLabel);
            this.panel4.Controls.Add(this.userGroupsListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 363);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(446, 105);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.userName);
            this.panel5.Controls.Add(this.addUser);
            this.panel5.Controls.Add(this.userNameLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 18);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5);
            this.panel5.Size = new System.Drawing.Size(316, 56);
            this.panel5.TabIndex = 9;
            // 
            // userName
            // 
            this.userName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userName.Location = new System.Drawing.Point(39, 5);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(272, 20);
            this.userName.TabIndex = 5;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // addUser
            // 
            this.addUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addUser.Enabled = false;
            this.addUser.Location = new System.Drawing.Point(39, 31);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(272, 20);
            this.addUser.TabIndex = 7;
            this.addUser.Text = "Добавить сотрудника";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.userNameLabel.Location = new System.Drawing.Point(5, 5);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.userNameLabel.Size = new System.Drawing.Size(34, 18);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "ФИО";
            // 
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserLabel.Location = new System.Drawing.Point(5, 5);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(131, 13);
            this.addUserLabel.TabIndex = 4;
            this.addUserLabel.Text = "Добавление сотрудника";
            // 
            // userGroupsListBox
            // 
            this.userGroupsListBox.DisplayMember = "Description";
            this.userGroupsListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.userGroupsListBox.FormattingEnabled = true;
            this.userGroupsListBox.Location = new System.Drawing.Point(321, 5);
            this.userGroupsListBox.Name = "userGroupsListBox";
            this.userGroupsListBox.Size = new System.Drawing.Size(120, 95);
            this.userGroupsListBox.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(446, 463);
            this.panel7.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(456, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManager";
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView groupsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addGroupLabel;
        private System.Windows.Forms.TextBox newGroupName;
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.CheckedListBox userGroupsListBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}

