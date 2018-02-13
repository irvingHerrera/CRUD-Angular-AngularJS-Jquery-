using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCRUD.Data.Context;
using WebCRUD.Data.Entities;
using WebCRUD.Data.RepositoryContract;

namespace WebCRUD.Data.Repository
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        private readonly DbCrudEntities context;
        private IRepository<Student> _Student;

        public UnityOfWork()
        {
            this.context = new DbCrudEntities();
        }

        public IRepository<Student> Student 
        {
            get
            {

                if (this._Student == null)
                {
                    this._Student = new Repository<Student>(context);
                }
                return this._Student;
            }
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
