using Models;
using Repositories.BaseRepositorie;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class StudentRepositore : BaseRepositorie<StudentModel>, IStudentRepositore
    {
    }
}
