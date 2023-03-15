using System;
using System.Collections.Generic;
using ApiModel.Permissions;

namespace ApiBusinessLogic.Interfaces.Permissions
{
    public interface IPermissionLogic
    {
        public IEnumerable<Permission> GetPermissions();
        public int RequestPermission(Permission dto);
        public bool ModifyPermission(Permission dto);
    }
}
