using Manager.BaseManager;
using Manager.Interface;
using Models;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
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
