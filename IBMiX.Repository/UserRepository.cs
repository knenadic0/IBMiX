using AutoMapper;
using IBMiX.Model;
using IBMiX.Model.Common;
using IBMiX.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<IUser> users;

        public UserRepository()
        {
            users = LoadUsers();
        }

        private List<IUser> LoadUsers()
        {
            return new List<IUser>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Karlo",
                    LastName = "Nenadić"
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Zvonimir",
                    LastName = "Petričušić"
                },
                new User()
                {
                    Id = 3,
                    FirstName = "Josip",
                    LastName = "Matoković"
                }
            };
        }

        public List<IUser> GetUsers()
        {
            return users;
        }

        public IUser GetUser(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }
    }
}
