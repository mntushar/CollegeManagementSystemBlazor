using Services.Interface;
using Microsoft.AspNetCore.Components;
using Models;

namespace CollegeManagementSystem.Pages.Admin.StudentDepartment
{
    public class AddDepartmentBase : ComponentBase
    {
        [Inject]
        protected IDepartmentManager DepartmentManager { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected string errorMassage { get; set; }

        protected DepartmentModel departmentModel = new DepartmentModel();

        protected void HandleValidSubmit()
        {
            bool isAdd = DepartmentManager.Add(departmentModel);
            if (isAdd) 
            {
                NavigationManager.NavigateTo("admin/department/list");
            }
            else
            {
                errorMassage = "Please enter valid information";
            } 
        }
    }
}

