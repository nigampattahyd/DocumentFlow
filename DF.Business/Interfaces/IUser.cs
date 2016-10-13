using DF.Business.Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.Business.Interfaces
{
    public interface IUser
    {
        List<User> getAllUsers();
        User getUserDetailsById(int userId);
        bool createUser(User user);
        bool updateUser(User user);
        bool deleteUser(int userId);
    }
}
