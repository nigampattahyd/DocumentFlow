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
    public class UserRepo : IUser
    {
        public bool createUser(User user)
        {
            var dfEntities = new DF_DefaultEntities();
            bool isCreated = false;
            try
            {
                var DisplayPic = user.ProfilePic;
                dfEntities.Users.Add(user);
                dfEntities.SaveChanges();
                var result = 0;
                //var result = dfEntities.DF_CreateUser(user.UserName, user.Password, user.FirstName, user.LastName, user.Gender, user.DOB,user.Skills, user.EmailAddress, user.Address, user.City, user.State, user.Country, user.Zip, user.ProfilePic, user.About, user.UserTypeId, user.CreatedBy);
                if (result > 0)
                {
                    isCreated = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dfEntities.Dispose();
            }
            return isCreated;
        }

        public bool deleteUser(int userId)
        {
            var dfEntities = new DF_DefaultEntities();
            bool isDeleted = false;
            try
            {
                var result = dfEntities.DF_DeleteUser(userId);
                if (result > 0)
                {
                    isDeleted = true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dfEntities.Dispose();
            }
            return isDeleted;
        }

        public List<User> getAllUsers()
        {
            var dfEntities = new DF_DefaultEntities();
            try
            {
                List<DF_GetAllUsers_Result> lstUsers = dfEntities.DF_GetAllUsers().ToList();
                return lstUsers.Select(user => new User
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DOB = user.DOB,
                    EmailAddress = user.EmailAddress,
                    Address = user.Address,
                    Gender=user.Gender,
                    City = user.City,
                    State = user.State,
                    Country = user.Country,
                    ProfilePic = user.ProfilePic,
                    About = user.About,
                    UserTypeId = user.UserTypeId,
                    CreatedOn = user.CreatedON,
                    CreatedBy = user.CreatedBy,
                    ModifiedOn = user.ModifiedOn,
                    ModifiedBy = user.ModifiedBy,
                    IsActive = user.IsActive,
                    IsLocked = user.IsLocked
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dfEntities.Dispose();
            }
        }

        public User getUserDetailsById(int userId)
        {
            User user = new User();
            var dfEntities = new DF_DefaultEntities();
            try
            {
                var result = dfEntities.DF_GetUsersDetailsById(userId).ToList();
                if (result != null && result.Count > 0)
                {
                    user.Id = userId;
                    user.UserName = result[0].UserName;
                    user.FirstName = result[0].FirstName;
                    user.LastName = result[0].LastName;
                    user.Password = result[0].Password;
                    user.ProfilePic = result[0].ProfilePic;
                    user.Gender = result[0].Gender;
                    user.DOB = result[0].DOB;
                    user.EmailAddress = result[0].EmailAddress;
                    user.Address = result[0].Address;
                    user.City = result[0].City;
                    user.State = result[0].State;
                    user.Country = result[0].Country;
                    user.Zip = result[0].Zip;
                    user.ProfilePic = result[0].ProfilePic;
                    user.About = result[0].About;
                    user.UserTypeId = result[0].UserTypeId;
                    user.CreatedOn = result[0].CreatedON;
                    user.CreatedBy = result[0].CreatedBy;
                    user.ModifiedOn = result[0].ModifiedOn;
                    user.ModifiedBy = result[0].ModifiedBy;
                    user.IsActive = result[0].IsActive;
                    user.IsLocked = result[0].IsLocked;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return user;
        }

        public bool updateUser(User user)
        {
            var dfEntities = new DF_DefaultEntities();
            bool inserted = false;
            try
            {
                dfEntities.DF_UpdateUser1(Convert.ToInt32(user.Id), user.UserName, user.Password, user.FirstName, user.LastName, user.Gender, user.DOB, user.EmailAddress, user.Address, user.City, user.State,user.Country,user.ProfilePic, user.Zip, user.About, 1, Convert.ToInt32(user.Id));
                inserted = true;
            }
            catch (Exception)
            {
                throw;
            }
            return inserted;
        }
    }
}
