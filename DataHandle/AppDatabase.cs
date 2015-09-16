using DataHandle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;


namespace DataHandle
{
    public class AppDatabase : DbContext
    {
        public DbSet<UserAccessType> UserAccessTypes { get; set; }
        public DbSet<UserModule> UserModules { get; set; }
        public DbSet<UserModuleAccessType> UserModuleAccessTypes { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserGroupModuleAccess> UserGroupModuleAccesses { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDatabase(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModule>()
                .HasOptional(u => u.ParentModule)
                .WithMany()
                .HasForeignKey(u => u.UserModuleId);

            base.OnModelCreating(modelBuilder);

        }

    }








}