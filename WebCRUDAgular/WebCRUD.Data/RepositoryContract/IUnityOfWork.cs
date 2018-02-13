using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCRUD.Data.Entities;

namespace WebCRUD.Data.RepositoryContract
{
    public interface IUnityOfWork
    {
        IRepository<Student> Student { get; }
        Task<int> SaveChangesAsync();
    }
}
