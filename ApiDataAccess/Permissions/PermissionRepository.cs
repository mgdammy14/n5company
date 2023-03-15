using System;
using ApiDataAccess.General;
using ApiModel.Permissions;
using ApiRepositories.Permissions;

namespace ApiDataAccess.Permissions
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        public PermissionRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
