using System;
using System.Collections.Generic;
using System.Linq;


using DataHandle;
using DataHandle.Entities;
using DataHandle.Models;

namespace DataHandleExample
{
    public class UserService
    {
        private readonly IAppContext _context;
        private readonly IUserEntity _users;
        
        public UserService(IAppContext context) : base()
        {
            _context = context;
            _users = _context.Users;

        }

        public IEnumerable<User> All()
        {
            return _users.All();
        }

        public User Create(UserViewModel vModel, bool isSoft = false)
        {
            var user = new User()
            {
                Username = vModel.Username,
                Password = vModel.Password,
            };

            if (!isSoft)
            {
                _users.Create(user);
                _context.SaveChanges();

            }

            return user;
        }


        public int Update(UserViewModel vModel)
        {
            User unit = _users.GetBy(vModel.Id);
            unit.Username = vModel.Username;
            unit.Password = vModel.Password;

            _users.Update(unit);
            return _context.SaveChanges();

        }

        public int Delete(int id)
        {
            var user = _users.GetBy(id);
            _users.Delete(user);
            return _context.SaveChanges();

        }

    }
}