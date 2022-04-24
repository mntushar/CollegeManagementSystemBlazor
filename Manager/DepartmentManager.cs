using Services.BaseManager;
using Services.Interface;
using Models;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class DepartmentManager : BaseManager<DepartmentModel>, IDepartmentManager
    {
        private IDepartmentRepositorie _departmentRepositorie;

        public DepartmentManager(IDepartmentRepositorie departmentRepositorie) : base(departmentRepositorie)
        {
            _departmentRepositorie = departmentRepositorie;
        }
    }
}
