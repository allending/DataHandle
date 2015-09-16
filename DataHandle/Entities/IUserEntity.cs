using System;
using System.Collections.Generic;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public interface IUserEntity : IRepository<User>
    {
        IQueryable<User> GetAll();
        User GetBy(int id);
        User GetBy(string name);
    }
}