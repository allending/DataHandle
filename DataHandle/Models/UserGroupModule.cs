using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace App.Models
{
    public class UserGroupModule : BaseModel
    {
        public int UserGroupId { get; set; }
        [ForeignKey("UserGroupId")]
        public UserGroup UserGroup { get; set; }
        
        public int UserModuleId { get; set; }
        [ForeignKey("UserModuleId")]
        public UserModule UserModule { get; set; }

        public bool CanView { get; set; }
        public bool CanList { get; set; }
        public bool CanAdd { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }

        private ICollection<UserGroupModuleAccess> _accesses { get; set; }
        public ICollection<UserGroupModuleAccess> Accesses
        {
            get { return _accesses ?? (_accesses = new Collection<UserGroupModuleAccess>()); }
            set { _accesses = value; }
        }

    }   
}
