using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMiX.Model.Common
{
    public interface IUser
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        List<IBook> Books { get; set; }
        string FullName { get => $"{FirstName} {LastName}"; }
    }
}
