using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DF.Business.Model.ExtendedModels
{
    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {

    }

    public partial class UserMetaData
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public byte[] ProfilePic { get; set; }
        public string About { get; set; }
        public int UserTypeId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsLocked { get; set; }
    }
}
