using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DataHandle.Models
{
    public class UserModuleAccessType : BaseModel
    {
        public int UserModuleId { get; set; }
        [ForeignKey("UserModuleId")]
        virtual public UserModule UserModule { get; set; }

        public int UserAccessTypeId { get; set; }
        [ForeignKey("UserAccessTypeId")]
        virtual public UserAccessType UserAccessType { get; set; }

        public bool IsAllowed { get; set; }

        private ICollection<UserGroupModuleAccess> _groupModuleAccesses { get; set; }
        public virtual ICollection<UserGroupModuleAccess> GroupModuleAccesses
        {
            get { return _groupModuleAccesses ?? (_groupModuleAccesses = new Collection<UserGroupModuleAccess>()); }
            set { _groupModuleAccesses = value; }
        }

    }
}
