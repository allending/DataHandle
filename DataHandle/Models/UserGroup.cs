using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DataHandle.Models
{
    public class UserGroup : BaseModel
    {
        public string Name { get; set; }
        public byte Level { get; set; }

        private ICollection<User> _users { get; set; }
        public virtual ICollection<User> Users
        {
            get { return _users ?? (_users = new Collection<User>()); }
            set { _users = value; }
        }

        private ICollection<UserGroupModuleAccess> _groupModuleAccesses { get; set; }
        public virtual ICollection<UserGroupModuleAccess> GroupModuleAccesses
        {
            get { return _groupModuleAccesses ?? (_groupModuleAccesses = new Collection<UserGroupModuleAccess>()); }
            set { _groupModuleAccesses = value; }
        }


    }
}
