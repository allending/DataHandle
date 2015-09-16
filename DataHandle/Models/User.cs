using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace DataHandle.Models
{
    public class User : BaseModel
    {
        [MaxLength(20)]
        public string Username { get; set; }
        public string Password { get; set; }

        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual UserGroup UserGroup { get; set; }

    }
}