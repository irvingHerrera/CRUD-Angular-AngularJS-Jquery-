using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using WebCRUD.Bussines;
using WebCRUD.Bussines.Interfaces;
using WebCRUD.Data.Repository;
using WebCRUD.Data.RepositoryContract;

namespace WebCRUPJQuery
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            //registrar dependencias
            container.RegisterType<IUnityOfWork, UnityOfWork>();
            container.RegisterType<IStudentBussines, StudentBussines>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}