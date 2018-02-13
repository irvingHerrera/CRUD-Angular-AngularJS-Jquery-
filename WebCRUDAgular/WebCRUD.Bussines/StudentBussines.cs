using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCRUD.Bussines.Interfaces;
using WebCRUD.Core.ViewModels;
using WebCRUD.Data.Entities;
using WebCRUD.Data.RepositoryContract;

namespace WebCRUD.Bussines
{
    public class StudentBussines : IStudentBussines
    {
        private readonly IUnityOfWork unityOfWork;

        public StudentBussines(IUnityOfWork unityOfWork)
        {
            this.unityOfWork = unityOfWork;
        }

        public async Task<int> AddStudent(StudentViewModel student)
        {
            var studentModel = new Student
            {
                Id = student.Id,
                Name = student.Name,
                LastName = student.LastName,
                EnrollmentDate = student.EnrollmentDate
            };

            unityOfWork.Student.Add(studentModel);
            var result = await unityOfWork.SaveChangesAsync();

            return result;
        }

        public async Task<int> Delete(int id)
        {
            var student = await unityOfWork.Student.GetAsync(id);
            unityOfWork.Student.Remove(student);
            return await unityOfWork.SaveChangesAsync();
        }

        public async Task<List<StudentViewModel>> GetAllStudent()
        {
            var listStudent = await unityOfWork.Student.GetAllAsync();

            return listStudent.Select(e => new StudentViewModel
            {
                Id = e.Id,
                Name = e.Name,
                LastName = e.LastName,
                EnrollmentDate = e.EnrollmentDate
            }).ToList();

        }

        public async Task<int> Update(StudentViewModel student)
        {
            var studenModel = new Student
            {
                Id = student.Id,
                Name = student.Name,
                LastName = student.LastName,
                EnrollmentDate = student.EnrollmentDate
            };

            unityOfWork.Student.Update(studenModel);
            return await unityOfWork.SaveChangesAsync();
        }
    }
}
