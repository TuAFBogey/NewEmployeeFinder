using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Formatting;
using AutoMapper;
using NewEmployeeFinder.API.DTOs;

namespace EmployeeFinderUI
{
    public partial class EmployeFinderUI : Form
    {        
        public EmployeFinderUI()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable dt = c.Select();
            //dataGridView1.DataSource = dt;
        }


        //************************************************Employee************************************************//


        private void btnGetData_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.GetAsync("api/employees/").Result;
            var emp = response.Content.ReadAsAsync<IEnumerable<EmployeeDto>>().Result;
            dataGridView1.DataSource = emp;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeDto emp = new EmployeeDto() { Name = txtBoxEmployeeName.Text, DepartmentId = Convert.ToInt32(txtBoxDepartmentId.Text.ToString()), ProjectId = Convert.ToInt32(txtBoxProjectId.Text.ToString()), CityId = Convert.ToInt32(txtBoxCityId.Text.ToString()) };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/employees/", emp).Result;
        }

        private void btnGetDataById_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.GetAsync("api/employees/" + txtBoxSearch.Text).Result;
            EmployeeDto emp = response.Content.ReadAsAsync<EmployeeDto>().Result;
            List<EmployeeDto> emplist = new List<EmployeeDto>();
            emplist.Add(emp);
            dataGridView1.DataSource = emplist;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeDto emp = new EmployeeDto { Id = Convert.ToInt32(txtBoxSearch.Text), Name = txtBoxEmployeeName.Text, DepartmentId = Convert.ToInt32(txtBoxDepartmentId.Text.ToString()), ProjectId = Convert.ToInt32(txtBoxProjectId.Text.ToString()), CityId = Convert.ToInt32(txtBoxCityId.Text.ToString()) };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.PutAsJsonAsync("api/employees/", emp).Result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.DeleteAsync("api/employees/" + txtBoxSearch.Text).Result;
        }


        //************************************************Department************************************************//


        private void btnGetAllDept_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.GetAsync("api/departments/").Result;
            var dept = response.Content.ReadAsAsync<IEnumerable<DepartmentDto>>().Result;
            dataGridView2.DataSource = dept;
        }

        private void btnInsertDept_Click(object sender, EventArgs e)
        {
            DepartmentDto dept = new DepartmentDto() { Name = txtBoxDeptName.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/departments/", dept).Result;
        }

        private void btnUpdateDept_Click(object sender, EventArgs e)
        {
            DepartmentDto dept = new DepartmentDto { Id = Convert.ToInt32(txtBoxSearchDept.Text), Name = txtBoxDeptName.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.PutAsJsonAsync("api/departments/", dept).Result;
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.DeleteAsync("api/departments/" + txtBoxSearchDept.Text).Result;
        }

        private void btnGetByIdDept_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.GetAsync("api/departments/" + txtBoxSearchDept.Text).Result;
            DepartmentDto dept = response.Content.ReadAsAsync<DepartmentDto>().Result;
            List<DepartmentDto> deptlist = new List<DepartmentDto>();
            deptlist.Add(dept);
            dataGridView2.DataSource = deptlist;
        }

        
        //************************************************Project************************************************//


        private void btnGetAllProject_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.GetAsync("api/projects/").Result;
            var project = response.Content.ReadAsAsync<IEnumerable<ProjectDto>>().Result;
            dataGridView3.DataSource = project;
        }

        private void btnInsertProject_Click(object sender, EventArgs e)
        {
            ProjectDto project = new ProjectDto() { Name = txtBoxPrjctName.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/projects/", project).Result;
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            ProjectDto project = new ProjectDto { Id = Convert.ToInt32(txtBoxSearchProject.Text), Name = txtBoxPrjctName.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.PutAsJsonAsync("api/projects/", project).Result;
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.DeleteAsync("api/projects/" + txtBoxSearchProject.Text).Result;
        }

        private void btnGetByIdProject_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.GetAsync("api/projects/" + txtBoxSearchProject.Text).Result;
            ProjectDto project = response.Content.ReadAsAsync<ProjectDto>().Result;
            List<ProjectDto> projectlist = new List<ProjectDto>();
            projectlist.Add(project);
            dataGridView3.DataSource = projectlist;
        }


        //************************************************City************************************************//


        private void btnGetAllCity_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.GetAsync("api/cities/").Result;
            var city = response.Content.ReadAsAsync<IEnumerable<CityDto>>().Result;
            dataGridView4.DataSource = city;
        }

        private void btnInsertCity_Click(object sender, EventArgs e)
        {
            CityDto city = new CityDto() { Name = txtBoxCtyName.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/cities/", city).Result;
        }

        private void btnUpdateCity_Click(object sender, EventArgs e)
        {
            CityDto city = new CityDto { Id = Convert.ToInt32(txtBoxSearchCity.Text), Name = txtBoxCtyName.Text };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.PutAsJsonAsync("api/cities/", city).Result;
        }

        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.DeleteAsync("api/cities/" + txtBoxSearchCity.Text).Result;
        }

        private void btnGetByIdCity_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:38160/");
            HttpResponseMessage response = client.GetAsync("api/cities/" + txtBoxSearchCity.Text).Result;
            CityDto city = response.Content.ReadAsAsync<CityDto>().Result;
            List<CityDto> citylist = new List<CityDto>();
            citylist.Add(city);
            dataGridView4.DataSource = citylist;
        }
    }
}
