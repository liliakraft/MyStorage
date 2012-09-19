using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;

namespace TestProject
{
    public class LiliasModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserDetailsRepository>().To<UserRepository>();
        }
    }

    public class UserRepository : IUserDetailsRepository
    {
        public void Save(User user)
        {
            throw new NotImplementedException();
        }
    }

    public interface IUserDetailsRepository
    {
        void Save(User user);
    }
}