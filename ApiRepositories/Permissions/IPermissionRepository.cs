using System;
using ApiModel.Permissions;
using ApiRepositories.General;

namespace ApiRepositories.Permissions
{
    public interface IPermissionRepository : IRepository<Permission>
    {
    }
}
