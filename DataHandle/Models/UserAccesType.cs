using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DataHandle.Models
{
    public class UserAccessType : BaseModel
    {
        [MaxLength(100)]
        public string Name { get; set; }

        private ICollection<UserModuleAccessType> _moduleAcessTypes { get; set; }
        virtual public ICollection<UserModuleAccessType> ModuleAccessTypes
        {
            get { return _moduleAcessTypes ?? (_moduleAcessTypes = new Collection<UserModuleAccessType>()); }
            set { _moduleAcessTypes = value; }
        }



    }
}
