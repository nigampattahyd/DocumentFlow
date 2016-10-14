using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DF.Business.Interfaces;
using DF.Business.Model.EntityFramework;
using DF.Business.Repository;



namespace DF.Business.Repository
{
    public class UserTypeRepo : IUsertype
    {
        public bool CreateUserType(UserType usertype)
        {
            var dfEntities = new DF_DefaultEntities();
            bool created = false;
            try
            {
                var result = dfEntities.DF_CreateUserType(usertype.UserType1, usertype.Description);
                if (result > 0)
                {
                    created = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dfEntities.Dispose();
            }
            return created;
        }

        public List<UserType> GetAllUserTypes()
        {
            var dfEntities = new DF_DefaultEntities();
            List<UserType> userTypeList = new List<UserType>();
            try
            {
                List<DF_GetAllUserType_Result> lstUserType = dfEntities.DF_GetAllUserType().ToList();
                return lstUserType.Select(usertype => new UserType
                {
                    UserTypeId = usertype.UserTypeId,
                    UserType1 = usertype.UserType,
                    Description = usertype.Description,
                    CreatedOn = usertype.CreatedOn,
                    ModifiedOn = usertype.ModifiedOn
                }
                ).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateUserType(UserType usertype)
        {
            throw new NotImplementedException();
        }
    }
}
