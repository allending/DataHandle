using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using DataHandle.Models;

namespace DataHandle.Entities
{
    public class UserModuleEntity : EfRepository<UserModule>, IUserModuleEntity
    {

        public UserModuleEntity(DbContext context, bool shareContext) : base(context, shareContext) { }

        public IQueryable<UserModule> GetAll()
        {
            return All();
        }

        public UserModule GetBy(int id)
        {
            return Find(u => u.Id == id);
        }

        public UserModule GetBy(string controller)
        {
            return Find(u => u.MvcController == controller);
        }


        public IQueryable<UserModule> GetManyBy(int? parentModuleId)
        {
            return FindAll(m => m.UserModuleId == parentModuleId).OrderBy(m => m.ListOrder);
        }

        public IQueryable<UserModule> GetManyByGroup(int groupId, int? parentModuleId = null)
        {
            return FindAll(
                m => m.UserModuleId == parentModuleId && m.Status == 1 && 
                     m.ModuleAccessTypes.Any(
                       ma => ma.UserAccessType.Name.Equals("View") && 
                             ma.GroupModuleAccesses.Any(
                                gma => gma.UserGroupId == groupId && gma.hasAccess == true
                             )
                     )
                ).OrderBy(m => m.ListOrder);                           
        }
    }
}