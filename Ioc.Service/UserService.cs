using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc.Core;
using Ioc.Core.Data; 
using Ioc.Data;

namespace Ioc.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> userRepository;
        private IRepository<UserProfile> userProfileRepository;

        //We are injecting the type from the controller 
        //IRepository is defined generic to all types
        //In the constructor we are injecting the type to the interface IRepository

        //We can have an Intrface for the related tables and can be injected in the constructor to perfrom CRUD operations
        public UserService(IRepository<User> userRepository, IRepository<UserProfile> userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public IQueryable<User> GetUsers()
        {

            return userRepository.Table;
        }

        public User GetUser(long id)
        {
            return userRepository.GetById(id);
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            userProfileRepository.Delete(user.UserProfile);
            userRepository.Delete(user);
        }
    }
}
