
namespace EmployeeFinderUI
{
    partial class EmployeFinderUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetDataById = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblEnterId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txtBoxCityId = new System.Windows.Forms.TextBox();
            this.lblCityId = new System.Windows.Forms.Label();
            this.txtBoxProjectId = new System.Windows.Forms.TextBox();
            this.lblProjectId = new System.Windows.Forms.Label();
            this.txtBoxDepartmentId = new System.Windows.Forms.TextBox();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.txtBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetEmployees = new System.Windows.Forms.Button();
            this.btnGetByIdDept = new System.Windows.Forms.Button();
            this.btnInsertDept = new System.Windows.Forms.Button();
            this.txtBoxSearchDept = new System.Windows.Forms.TextBox();
            this.lblDeptEnterId = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDeleteDept = new System.Windows.Forms.Button();
            this.btnUpdateDept = new System.Windows.Forms.Button();
            this.btnGetAllDept = new System.Windows.Forms.Button();
            this.txtBoxDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.txtBoxDeptId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGetByIdProject = new System.Windows.Forms.Button();
            this.btnInsertProject = new System.Windows.Forms.Button();
            this.txtBoxSearchProject = new System.Windows.Forms.TextBox();
            this.lblProjectEnterId = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.btnGetAllProject = new System.Windows.Forms.Button();
            this.txtBoxPrjctName = new System.Windows.Forms.TextBox();
            this.lblPrjctName = new System.Windows.Forms.Label();
            this.txtBoxPrjctId = new System.Windows.Forms.TextBox();
            this.lblPrjctId = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnGetByIdCity = new System.Windows.Forms.Button();
            this.btnInsertCity = new System.Windows.Forms.Button();
            this.txtBoxSearchCity = new System.Windows.Forms.TextBox();
            this.lblCityEnterId = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnUpdateCity = new System.Windows.Forms.Button();
            this.btnGetAllCity = new System.Windows.Forms.Button();
            this.txtBoxCtyName = new System.Windows.Forms.TextBox();
            this.lblCtyName = new System.Windows.Forms.Label();
            this.txtBoxCtyId = new System.Windows.Forms.TextBox();
            this.lblCtyId = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 447);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetDataById);
            this.tabPage1.Controls.Add(this.btnInsert);
            this.tabPage1.Controls.Add(this.txtBoxSearch);
            this.tabPage1.Controls.Add(this.lblEnterId);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnGetData);
            this.tabPage1.Controls.Add(this.txtBoxCityId);
            this.tabPage1.Controls.Add(this.lblCityId);
            this.tabPage1.Controls.Add(this.txtBoxProjectId);
            this.tabPage1.Controls.Add(this.lblProjectId);
            this.tabPage1.Controls.Add(this.txtBoxDepartmentId);
            this.tabPage1.Controls.Add(this.lblDepartmentId);
            this.tabPage1.Controls.Add(this.txtBoxEmployeeName);
            this.tabPage1.Controls.Add(this.lblEmployeeName);
            this.tabPage1.Controls.Add(this.txtBoxEmployeeId);
            this.tabPage1.Controls.Add(this.lblEmployeeId);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGetDataById
            // 
            this.btnGetDataById.Location = new System.Drawing.Point(434, 7);
            this.btnGetDataById.Name = "btnGetDataById";
            this.btnGetDataById.Size = new System.Drawing.Size(94, 37);
            this.btnGetDataById.TabIndex = 36;
            this.btnGetDataById.Text = "Get Data By ID";
            this.btnGetDataById.UseVisualStyleBackColor = true;
            this.btnGetDataById.Click += new System.EventHandler(this.btnGetDataById_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(442, 334);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 37);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(345, 15);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(56, 23);
            this.txtBoxSearch.TabIndex = 34;
            this.txtBoxSearch.Text = "0";
            // 
            // lblEnterId
            // 
            this.lblEnterId.AutoSize = true;
            this.lblEnterId.Location = new System.Drawing.Point(282, 18);
            this.lblEnterId.Name = "lblEnterId";
            this.lblEnterId.Size = new System.Drawing.Size(48, 15);
            this.lblEnterId.TabIndex = 33;
            this.lblEnterId.Text = "Enter ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 258);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(642, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 37);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(542, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 37);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(342, 334);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(94, 37);
            this.btnGetData.TabIndex = 29;
            this.btnGetData.Text = "Get All Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // txtBoxCityId
            // 
            this.txtBoxCityId.Location = new System.Drawing.Point(101, 186);
            this.txtBoxCityId.Name = "txtBoxCityId";
            this.txtBoxCityId.Size = new System.Drawing.Size(147, 23);
            this.txtBoxCityId.TabIndex = 28;
            // 
            // lblCityId
            // 
            this.lblCityId.AutoSize = true;
            this.lblCityId.Location = new System.Drawing.Point(4, 189);
            this.lblCityId.Name = "lblCityId";
            this.lblCityId.Size = new System.Drawing.Size(42, 15);
            this.lblCityId.TabIndex = 27;
            this.lblCityId.Text = "City ID";
            // 
            // txtBoxProjectId
            // 
            this.txtBoxProjectId.Location = new System.Drawing.Point(101, 157);
            this.txtBoxProjectId.Name = "txtBoxProjectId";
            this.txtBoxProjectId.Size = new System.Drawing.Size(147, 23);
            this.txtBoxProjectId.TabIndex = 26;
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.Location = new System.Drawing.Point(4, 160);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(58, 15);
            this.lblProjectId.TabIndex = 25;
            this.lblProjectId.Text = "Project ID";
            // 
            // txtBoxDepartmentId
            // 
            this.txtBoxDepartmentId.Location = new System.Drawing.Point(101, 128);
            this.txtBoxDepartmentId.Name = "txtBoxDepartmentId";
            this.txtBoxDepartmentId.Size = new System.Drawing.Size(147, 23);
            this.txtBoxDepartmentId.TabIndex = 24;
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.AutoSize = true;
            this.lblDepartmentId.Location = new System.Drawing.Point(4, 131);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(84, 15);
            this.lblDepartmentId.TabIndex = 23;
            this.lblDepartmentId.Text = "Department ID";
            // 
            // txtBoxEmployeeName
            // 
            this.txtBoxEmployeeName.Location = new System.Drawing.Point(101, 99);
            this.txtBoxEmployeeName.Name = "txtBoxEmployeeName";
            this.txtBoxEmployeeName.Size = new System.Drawing.Size(147, 23);
            this.txtBoxEmployeeName.TabIndex = 22;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(4, 102);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(91, 15);
            this.lblEmployeeName.TabIndex = 21;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // txtBoxEmployeeId
            // 
            this.txtBoxEmployeeId.Location = new System.Drawing.Point(101, 70);
            this.txtBoxEmployeeId.Name = "txtBoxEmployeeId";
            this.txtBoxEmployeeId.ReadOnly = true;
            this.txtBoxEmployeeId.Size = new System.Drawing.Size(147, 23);
            this.txtBoxEmployeeId.TabIndex = 20;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(4, 73);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(73, 15);
            this.lblEmployeeId.TabIndex = 19;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetEmployees);
            this.tabPage2.Controls.Add(this.btnGetByIdDept);
            this.tabPage2.Controls.Add(this.btnInsertDept);
            this.tabPage2.Controls.Add(this.txtBoxSearchDept);
            this.tabPage2.Controls.Add(this.lblDeptEnterId);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnDeleteDept);
            this.tabPage2.Controls.Add(this.btnUpdateDept);
            this.tabPage2.Controls.Add(this.btnGetAllDept);
            this.tabPage2.Controls.Add(this.txtBoxDeptName);
            this.tabPage2.Controls.Add(this.lblDeptName);
            this.tabPage2.Controls.Add(this.txtBoxDeptId);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Department";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetEmployees
            // 
            this.btnGetEmployees.Location = new System.Drawing.Point(551, 27);
            this.btnGetEmployees.Name = "btnGetEmployees";
            this.btnGetEmployees.Size = new System.Drawing.Size(94, 37);
            this.btnGetEmployees.TabIndex = 55;
            this.btnGetEmployees.Text = "Get Employees";
            this.btnGetEmployees.UseVisualStyleBackColor = true;
            // 
            // btnGetByIdDept
            // 
            this.btnGetByIdDept.Location = new System.Drawing.Point(443, 27);
            this.btnGetByIdDept.Name = "btnGetByIdDept";
            this.btnGetByIdDept.Size = new System.Drawing.Size(94, 37);
            this.btnGetByIdDept.TabIndex = 54;
            this.btnGetByIdDept.Text = "Get Data By ID";
            this.btnGetByIdDept.UseVisualStyleBackColor = true;
            this.btnGetByIdDept.Click += new System.EventHandler(this.btnGetByIdDept_Click);
            // 
            // btnInsertDept
            // 
            this.btnInsertDept.Location = new System.Drawing.Point(451, 354);
            this.btnInsertDept.Name = "btnInsertDept";
            this.btnInsertDept.Size = new System.Drawing.Size(94, 37);
            this.btnInsertDept.TabIndex = 53;
            this.btnInsertDept.Text = "Insert";
            this.btnInsertDept.UseVisualStyleBackColor = true;
            this.btnInsertDept.Click += new System.EventHandler(this.btnInsertDept_Click);
            // 
            // txtBoxSearchDept
            // 
            this.txtBoxSearchDept.Location = new System.Drawing.Point(354, 35);
            this.txtBoxSearchDept.Name = "txtBoxSearchDept";
            this.txtBoxSearchDept.Size = new System.Drawing.Size(56, 23);
            this.txtBoxSearchDept.TabIndex = 52;
            this.txtBoxSearchDept.Text = "0";
            // 
            // lblDeptEnterId
            // 
            this.lblDeptEnterId.AutoSize = true;
            this.lblDeptEnterId.Location = new System.Drawing.Point(291, 38);
            this.lblDeptEnterId.Name = "lblDeptEnterId";
            this.lblDeptEnterId.Size = new System.Drawing.Size(48, 15);
            this.lblDeptEnterId.TabIndex = 51;
            this.lblDeptEnterId.Text = "Enter ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(291, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(543, 258);
            this.dataGridView2.TabIndex = 50;
            // 
            // btnDeleteDept
            // 
            this.btnDeleteDept.Location = new System.Drawing.Point(651, 354);
            this.btnDeleteDept.Name = "btnDeleteDept";
            this.btnDeleteDept.Size = new System.Drawing.Size(94, 37);
            this.btnDeleteDept.TabIndex = 49;
            this.btnDeleteDept.Text = "Delete";
            this.btnDeleteDept.UseVisualStyleBackColor = true;
            this.btnDeleteDept.Click += new System.EventHandler(this.btnDeleteDept_Click);
            // 
            // btnUpdateDept
            // 
            this.btnUpdateDept.Location = new System.Drawing.Point(551, 354);
            this.btnUpdateDept.Name = "btnUpdateDept";
            this.btnUpdateDept.Size = new System.Drawing.Size(94, 37);
            this.btnUpdateDept.TabIndex = 48;
            this.btnUpdateDept.Text = "Update";
            this.btnUpdateDept.UseVisualStyleBackColor = true;
            this.btnUpdateDept.Click += new System.EventHandler(this.btnUpdateDept_Click);
            // 
            // btnGetAllDept
            // 
            this.btnGetAllDept.Location = new System.Drawing.Point(351, 354);
            this.btnGetAllDept.Name = "btnGetAllDept";
            this.btnGetAllDept.Size = new System.Drawing.Size(94, 37);
            this.btnGetAllDept.TabIndex = 47;
            this.btnGetAllDept.Text = "Get All Data";
            this.btnGetAllDept.UseVisualStyleBackColor = true;
            this.btnGetAllDept.Click += new System.EventHandler(this.btnGetAllDept_Click);
            // 
            // txtBoxDeptName
            // 
            this.txtBoxDeptName.Location = new System.Drawing.Point(123, 122);
            this.txtBoxDeptName.Name = "txtBoxDeptName";
            this.txtBoxDeptName.Size = new System.Drawing.Size(147, 23);
            this.txtBoxDeptName.TabIndex = 40;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(13, 122);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(105, 15);
            this.lblDeptName.TabIndex = 39;
            this.lblDeptName.Text = "Department Name";
            // 
            // txtBoxDeptId
            // 
            this.txtBoxDeptId.Location = new System.Drawing.Point(123, 90);
            this.txtBoxDeptId.Name = "txtBoxDeptId";
            this.txtBoxDeptId.ReadOnly = true;
            this.txtBoxDeptId.Size = new System.Drawing.Size(147, 23);
            this.txtBoxDeptId.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Department ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGetByIdProject);
            this.tabPage3.Controls.Add(this.btnInsertProject);
            this.tabPage3.Controls.Add(this.txtBoxSearchProject);
            this.tabPage3.Controls.Add(this.lblProjectEnterId);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.btnDeleteProject);
            this.tabPage3.Controls.Add(this.btnUpdateProject);
            this.tabPage3.Controls.Add(this.btnGetAllProject);
            this.tabPage3.Controls.Add(this.txtBoxPrjctName);
            this.tabPage3.Controls.Add(this.lblPrjctName);
            this.tabPage3.Controls.Add(this.txtBoxPrjctId);
            this.tabPage3.Controls.Add(this.lblPrjctId);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(846, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Project";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGetByIdProject
            // 
            this.btnGetByIdProject.Location = new System.Drawing.Point(443, 27);
            this.btnGetByIdProject.Name = "btnGetByIdProject";
            this.btnGetByIdProject.Size = new System.Drawing.Size(94, 37);
            this.btnGetByIdProject.TabIndex = 66;
            this.btnGetByIdProject.Text = "Get Data By ID";
            this.btnGetByIdProject.UseVisualStyleBackColor = true;
            this.btnGetByIdProject.Click += new System.EventHandler(this.btnGetByIdProject_Click);
            // 
            // btnInsertProject
            // 
            this.btnInsertProject.Location = new System.Drawing.Point(451, 354);
            this.btnInsertProject.Name = "btnInsertProject";
            this.btnInsertProject.Size = new System.Drawing.Size(94, 37);
            this.btnInsertProject.TabIndex = 65;
            this.btnInsertProject.Text = "Insert";
            this.btnInsertProject.UseVisualStyleBackColor = true;
            this.btnInsertProject.Click += new System.EventHandler(this.btnInsertProject_Click);
            // 
            // txtBoxSearchProject
            // 
            this.txtBoxSearchProject.Location = new System.Drawing.Point(354, 35);
            this.txtBoxSearchProject.Name = "txtBoxSearchProject";
            this.txtBoxSearchProject.Size = new System.Drawing.Size(56, 23);
            this.txtBoxSearchProject.TabIndex = 64;
            this.txtBoxSearchProject.Text = "0";
            // 
            // lblProjectEnterId
            // 
            this.lblProjectEnterId.AutoSize = true;
            this.lblProjectEnterId.Location = new System.Drawing.Point(291, 38);
            this.lblProjectEnterId.Name = "lblProjectEnterId";
            this.lblProjectEnterId.Size = new System.Drawing.Size(48, 15);
            this.lblProjectEnterId.TabIndex = 63;
            this.lblProjectEnterId.Text = "Enter ID";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(291, 70);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(543, 258);
            this.dataGridView3.TabIndex = 62;
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(651, 354);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(94, 37);
            this.btnDeleteProject.TabIndex = 61;
            this.btnDeleteProject.Text = "Delete";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Location = new System.Drawing.Point(551, 354);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(94, 37);
            this.btnUpdateProject.TabIndex = 60;
            this.btnUpdateProject.Text = "Update";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // btnGetAllProject
            // 
            this.btnGetAllProject.Location = new System.Drawing.Point(351, 354);
            this.btnGetAllProject.Name = "btnGetAllProject";
            this.btnGetAllProject.Size = new System.Drawing.Size(94, 37);
            this.btnGetAllProject.TabIndex = 59;
            this.btnGetAllProject.Text = "Get All Data";
            this.btnGetAllProject.UseVisualStyleBackColor = true;
            this.btnGetAllProject.Click += new System.EventHandler(this.btnGetAllProject_Click);
            // 
            // txtBoxPrjctName
            // 
            this.txtBoxPrjctName.Location = new System.Drawing.Point(123, 122);
            this.txtBoxPrjctName.Name = "txtBoxPrjctName";
            this.txtBoxPrjctName.Size = new System.Drawing.Size(147, 23);
            this.txtBoxPrjctName.TabIndex = 58;
            // 
            // lblPrjctName
            // 
            this.lblPrjctName.AutoSize = true;
            this.lblPrjctName.Location = new System.Drawing.Point(13, 122);
            this.lblPrjctName.Name = "lblPrjctName";
            this.lblPrjctName.Size = new System.Drawing.Size(79, 15);
            this.lblPrjctName.TabIndex = 57;
            this.lblPrjctName.Text = "Project Name";
            // 
            // txtBoxPrjctId
            // 
            this.txtBoxPrjctId.Location = new System.Drawing.Point(123, 90);
            this.txtBoxPrjctId.Name = "txtBoxPrjctId";
            this.txtBoxPrjctId.ReadOnly = true;
            this.txtBoxPrjctId.Size = new System.Drawing.Size(147, 23);
            this.txtBoxPrjctId.TabIndex = 56;
            // 
            // lblPrjctId
            // 
            this.lblPrjctId.AutoSize = true;
            this.lblPrjctId.Location = new System.Drawing.Point(13, 93);
            this.lblPrjctId.Name = "lblPrjctId";
            this.lblPrjctId.Size = new System.Drawing.Size(58, 15);
            this.lblPrjctId.TabIndex = 55;
            this.lblPrjctId.Text = "Project ID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnGetByIdCity);
            this.tabPage4.Controls.Add(this.btnInsertCity);
            this.tabPage4.Controls.Add(this.txtBoxSearchCity);
            this.tabPage4.Controls.Add(this.lblCityEnterId);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.btnDeleteCity);
            this.tabPage4.Controls.Add(this.btnUpdateCity);
            this.tabPage4.Controls.Add(this.btnGetAllCity);
            this.tabPage4.Controls.Add(this.txtBoxCtyName);
            this.tabPage4.Controls.Add(this.lblCtyName);
            this.tabPage4.Controls.Add(this.txtBoxCtyId);
            this.tabPage4.Controls.Add(this.lblCtyId);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(846, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "City";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnGetByIdCity
            // 
            this.btnGetByIdCity.Location = new System.Drawing.Point(443, 27);
            this.btnGetByIdCity.Name = "btnGetByIdCity";
            this.btnGetByIdCity.Size = new System.Drawing.Size(94, 37);
            this.btnGetByIdCity.TabIndex = 66;
            this.btnGetByIdCity.Text = "Get Data By ID";
            this.btnGetByIdCity.UseVisualStyleBackColor = true;
            this.btnGetByIdCity.Click += new System.EventHandler(this.btnGetByIdCity_Click);
            // 
            // btnInsertCity
            // 
            this.btnInsertCity.Location = new System.Drawing.Point(451, 354);
            this.btnInsertCity.Name = "btnInsertCity";
            this.btnInsertCity.Size = new System.Drawing.Size(94, 37);
            this.btnInsertCity.TabIndex = 65;
            this.btnInsertCity.Text = "Insert";
            this.btnInsertCity.UseVisualStyleBackColor = true;
            this.btnInsertCity.Click += new System.EventHandler(this.btnInsertCity_Click);
            // 
            // txtBoxSearchCity
            // 
            this.txtBoxSearchCity.Location = new System.Drawing.Point(354, 35);
            this.txtBoxSearchCity.Name = "txtBoxSearchCity";
            this.txtBoxSearchCity.Size = new System.Drawing.Size(56, 23);
            this.txtBoxSearchCity.TabIndex = 64;
            this.txtBoxSearchCity.Text = "0";
            // 
            // lblCityEnterId
            // 
            this.lblCityEnterId.AutoSize = true;
            this.lblCityEnterId.Location = new System.Drawing.Point(291, 38);
            this.lblCityEnterId.Name = "lblCityEnterId";
            this.lblCityEnterId.Size = new System.Drawing.Size(48, 15);
            this.lblCityEnterId.TabIndex = 63;
            this.lblCityEnterId.Text = "Enter ID";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(291, 70);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(543, 258);
            this.dataGridView4.TabIndex = 62;
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Location = new System.Drawing.Point(651, 354);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(94, 37);
            this.btnDeleteCity.TabIndex = 61;
            this.btnDeleteCity.Text = "Delete";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            this.btnDeleteCity.Click += new System.EventHandler(this.btnDeleteCity_Click);
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.Location = new System.Drawing.Point(551, 354);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(94, 37);
            this.btnUpdateCity.TabIndex = 60;
            this.btnUpdateCity.Text = "Update";
            this.btnUpdateCity.UseVisualStyleBackColor = true;
            this.btnUpdateCity.Click += new System.EventHandler(this.btnUpdateCity_Click);
            // 
            // btnGetAllCity
            // 
            this.btnGetAllCity.Location = new System.Drawing.Point(351, 354);
            this.btnGetAllCity.Name = "btnGetAllCity";
            this.btnGetAllCity.Size = new System.Drawing.Size(94, 37);
            this.btnGetAllCity.TabIndex = 59;
            this.btnGetAllCity.Text = "Get All Data";
            this.btnGetAllCity.UseVisualStyleBackColor = true;
            this.btnGetAllCity.Click += new System.EventHandler(this.btnGetAllCity_Click);
            // 
            // txtBoxCtyName
            // 
            this.txtBoxCtyName.Location = new System.Drawing.Point(123, 122);
            this.txtBoxCtyName.Name = "txtBoxCtyName";
            this.txtBoxCtyName.Size = new System.Drawing.Size(147, 23);
            this.txtBoxCtyName.TabIndex = 58;
            // 
            // lblCtyName
            // 
            this.lblCtyName.AutoSize = true;
            this.lblCtyName.Location = new System.Drawing.Point(13, 122);
            this.lblCtyName.Name = "lblCtyName";
            this.lblCtyName.Size = new System.Drawing.Size(63, 15);
            this.lblCtyName.TabIndex = 57;
            this.lblCtyName.Text = "City Name";
            // 
            // txtBoxCtyId
            // 
            this.txtBoxCtyId.Location = new System.Drawing.Point(123, 90);
            this.txtBoxCtyId.Name = "txtBoxCtyId";
            this.txtBoxCtyId.ReadOnly = true;
            this.txtBoxCtyId.Size = new System.Drawing.Size(147, 23);
            this.txtBoxCtyId.TabIndex = 56;
            // 
            // lblCtyId
            // 
            this.lblCtyId.AutoSize = true;
            this.lblCtyId.Location = new System.Drawing.Point(13, 93);
            this.lblCtyId.Name = "lblCtyId";
            this.lblCtyId.Size = new System.Drawing.Size(42, 15);
            this.lblCtyId.TabIndex = 55;
            this.lblCtyId.Text = "City ID";
            // 
            // EmployeFinderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 471);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeFinderUI";
            this.Text = "EmployeeFinderUI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGetDataById;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label lblEnterId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox txtBoxCityId;
        private System.Windows.Forms.Label lblCityId;
        private System.Windows.Forms.TextBox txtBoxProjectId;
        private System.Windows.Forms.Label lblProjectId;
        private System.Windows.Forms.TextBox txtBoxDepartmentId;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.TextBox txtBoxEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtBoxEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGetByIdDept;
        private System.Windows.Forms.Button btnInsertDept;
        private System.Windows.Forms.TextBox txtBoxSearchDept;
        private System.Windows.Forms.Label lblDeptEnterId;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDeleteDept;
        private System.Windows.Forms.Button btnUpdateDept;
        private System.Windows.Forms.Button btnGetAllDept;
        private System.Windows.Forms.TextBox txtBoxDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtBoxDeptId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGetByIdProject;
        private System.Windows.Forms.Button btnInsertProject;
        private System.Windows.Forms.TextBox txtBoxSearchProject;
        private System.Windows.Forms.Label lblProjectEnterId;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.Button btnGetAllProject;
        private System.Windows.Forms.TextBox txtBoxPrjctName;
        private System.Windows.Forms.Label lblPrjctName;
        private System.Windows.Forms.TextBox txtBoxPrjctId;
        private System.Windows.Forms.Label lblPrjctId;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnGetByIdCity;
        private System.Windows.Forms.Button btnInsertCity;
        private System.Windows.Forms.TextBox txtBoxSearchCity;
        private System.Windows.Forms.Label lblCityEnterId;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Button btnUpdateCity;
        private System.Windows.Forms.Button btnGetAllCity;
        private System.Windows.Forms.TextBox txtBoxCtyName;
        private System.Windows.Forms.Label lblCtyName;
        private System.Windows.Forms.TextBox txtBoxCtyId;
        private System.Windows.Forms.Label lblCtyId;
        private System.Windows.Forms.Button btnGetEmployees;
    }
}

