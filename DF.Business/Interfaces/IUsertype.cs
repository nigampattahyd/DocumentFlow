using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF.Business.Model.EntityFramework;

namespace DF.Business.Interfaces
{
    public interface IUsertype
    {
        bool CreateUserType(UserType usertype);
        List<UserType> GetAllUserTypes();
        bool UpdateUserType(UserType usertype);
        bool DeleteUserType(int id);
    }
}
