using IBMiX.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Service.Common
{
    public interface IUserService
    {
        List<IUser> GetUsers();
    }
}
