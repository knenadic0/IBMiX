using AutoMapper;
using IBMiX.Model.Common;
using IBMiX.Repository.Common;
using IBMiX.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public List<IUser> GetUsers()
        {
            return userRepository.GetUsers();
        }
    }
}
