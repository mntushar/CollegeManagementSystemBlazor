using Manager.Interface;
using Microsoft.AspNetCore.Components;
using Models;

namespace CollegeManagementSystem.Pages.Department
{
    public class AddDepartmentBase : ComponentBase
    {
        protected string componentTitle { get; set; }
        protected string submitType { get; set; }
        protected DepartmentModel departmentModel = new DepartmentModel();

        [Inject]
        protected IDepartmentManager DepartmentManager { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            componentTitle = "Add Department";
            submitType = "submit";
        }

        protected void HandleValidSubmit()
        {
            bool isAdd = DepartmentManager.Add(departmentModel);
            if (isAdd) NavigationManager.NavigateTo("/counter");

            NavigationManager.NavigateTo("400", true);
        }
    }
}

