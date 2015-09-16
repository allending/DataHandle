using System;
using System.Collections.Generic;
using System.Linq;


namespace DataHandle.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public int Type { get; set; }

        public int Status { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public BaseModel(int createdBy = 0, DateTime? eventDate = null, int type = 1, int status = 1)
        {
            CreatedBy = createdBy;
            CreatedDate = eventDate ?? DateTime.Now;
            Type = type;
            Status = status;
        }
    }
}