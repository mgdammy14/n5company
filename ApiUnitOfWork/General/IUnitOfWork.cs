using System;
using ApiRepositories.Permissions;

namespace ApiUnitOfWork.General
{
    public interface IUnitOfWork
    {
        public IPermissionRepository IPermission { get; set; }
    }
}