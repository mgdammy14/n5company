using System;
using System.Collections.Generic;
using ApiBusinessLogic.Interfaces.Permissions;
using ApiModel.Permissions;
using ApiUnitOfWork.General;

namespace ApiBusinessLogic.Implementation.Permissions
{
    public class PermissionLogic : IPermissionLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermissionLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Permission> GetPermissions()
        {
            try
            {
                return _unitOfWork.IPermission.GetList();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public int RequestPermission(Permission dto)
        {
            try
            {
                return _unitOfWork.IPermission.Insert(dto);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public bool ModifyPermission(Permission dto)
        {
            try
            {
                return _unitOfWork.IPermission.Update(dto);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
