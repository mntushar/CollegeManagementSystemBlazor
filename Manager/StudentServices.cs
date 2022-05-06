using Models;
using Repositories.Interface;
using Services.BaseManager;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class StudentServices : BaseManager<StudentModel>, IStudentServices
    {
        private IStudentRepositore _studentRepositore;
        private IDepartmentManager _departmentManager;

        public StudentServices(IStudentRepositore studentRepositore) : base(studentRepositore)
        {
            _studentRepositore = studentRepositore;
        }

        public StudentServices(IStudentRepositore studentRepositore, IDepartmentManager departmentManager) : base(studentRepositore)
        {
            _studentRepositore = studentRepositore;
            _departmentManager = departmentManager;
        }

        public override bool Add(StudentModel entity)
        {
            DepartmentModel department = _departmentManager.Get(entity.DeptId);
            if (department != null)
            {
                return _studentRepositore.Add(entity);
            }
            else
            {
                return false;
            }
        }

        public override bool Update(StudentModel entity)
        {
            DepartmentModel department = _departmentManager.Get(entity.DeptId);
            if (department == null) return false;
            return _studentRepositore.Update(entity);

        }
    }
}
