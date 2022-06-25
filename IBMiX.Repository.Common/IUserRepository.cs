using IBMiX.Model;
using IBMiX.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Repository.Common
{
    public interface IUserRepository
    {
        List<IUser> GetUsers();
        IUser GetUser(int id);
    }
}
