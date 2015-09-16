using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DataHandle.Models
{
    public class UserModule : BaseModel
    {
        [MaxLength(100)]
        public string Name { get; set; }

        public int? UserModuleId { get; set; }
        public UserModule ParentModule { get; set; }

        public int ListOrder { get; set; }

        [MaxLength(50)]
        public string CssIcon { get; set; }

        [MaxLength(50)]
        public string MvcController { get; set; }

        [MaxLength(50)]
        public string MvcAction { get; set; }

        private ICollection<UserModuleAccessType> _moduleAcessTypes { get; set; }
        public ICollection<UserModuleAccessType> ModuleAccessTypes
        {
            get { return _moduleAcessTypes ?? (_moduleAcessTypes = new Collection<UserModuleAccessType>()); }
            set { _moduleAcessTypes = value; }
        }

        private ICollection<UserModule> _childModules { get; set; }
        public ICollection<UserModule> ChildModules
        {
            get { return _childModules ?? (_childModules = new Collection<UserModule>()); }
            set { _childModules = value; }
        }
    }
}
