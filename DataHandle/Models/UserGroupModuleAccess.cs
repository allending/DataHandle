using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DataHandle.Models
{
    public class UserGroupModuleAccess : BaseModel
    {
        public int UserGroupId { get; set; }
        [ForeignKey("UserGroupId")]
        virtual public UserGroup UserGroup { get; set; }

        public int UserModuleAccessTypeId { get; set; }
        [ForeignKey("UserModuleAccessTypeId")]
        virtual public UserModuleAccessType ModuleAccessType { get; set; }

        public bool hasAccess { get; set; }

    }
}
