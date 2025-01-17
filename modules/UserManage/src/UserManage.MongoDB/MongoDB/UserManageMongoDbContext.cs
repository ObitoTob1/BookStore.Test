﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace UserManage.MongoDB
{
    [ConnectionStringName(UserManageDbProperties.ConnectionStringName)]
    public class UserManageMongoDbContext : AbpMongoDbContext, IUserManageMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureUserManage();
        }
    }
}