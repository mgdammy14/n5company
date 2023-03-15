using System;
using ApiDataAccess.Permissions;
using ApiRepositories.Permissions;
using ApiUnitOfWork.General;

namespace ApiDataAccess.General
{
    public class UnitOfWork: IUnitOfWork
    {
        public IPermissionRepository IPermission { get; set; }
        public UnitOfWork(string connectionString)
        {
            IPermission = new PermissionRepository(connectionString);
        }
    }
}
