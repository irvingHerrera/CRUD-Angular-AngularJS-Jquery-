using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCRUD.Core.ViewModels;

namespace WebCRUD.Bussines.Interfaces
{
    public interface IStudentBussines
    {
        Task<int> AddStudent(StudentViewModel student);
        Task<List<StudentViewModel>> GetAllStudent();
        Task<int> Delete(int id);
        Task<int> Update(StudentViewModel student);
    }
}
