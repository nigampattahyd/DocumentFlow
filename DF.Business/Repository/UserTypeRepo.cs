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

        public bool DeleteUserType(int id)
        {
            var dfEntities = new DF_DefaultEntities();
            bool deleted = false;
            try
            {
                dfEntities.DF_DeleteUserType(id);
                deleted = true;
            }
            catch (Exception)
            {
                
            }
            return deleted;
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

        public UserType GetUserTypeById(int id)
        {
            var dfentities = new DF_DefaultEntities();
            UserType usertype = new UserType();
            try
            {
               List<DF_GetAllUserTypeById_Result> usertyperetreived =  dfentities.DF_GetAllUserTypeById(id).ToList();
                foreach (var item in usertyperetreived)
                {
                    usertype.UserTypeId = item.UserTypeId;
                    usertype.UserType1 = item.UserType;
                    usertype.Description = item.Description;
                    usertype.CreatedOn = item.CreatedOn;
                    usertype.ModifiedOn = item.ModifiedOn;
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
            return usertype;
        }

        public bool UpdateUserType(UserType usertype)
        {
            var dfEntities = new DF_DefaultEntities();
            bool updated = false;
            try
            {
                dfEntities.DF_UpdateUserType(usertype.UserTypeId, usertype.UserType1, usertype.Description);
                updated = true;
            }
            catch (Exception)
            {

                throw;
            }
            return updated;
        }
    }
}
