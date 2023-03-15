using System;
using ApiBusinessLogic.Interfaces.Permissions;
using Xunit;

namespace UnitTest
{
    public class PermissionTest
    {
        private readonly IPermissionLogic _permissionLogic;
        public PermissionTest()
        { 
        }

        [Fact]
        public void GetPermissionTest()
        {
            var result = _permissionLogic.GetPermissions();

            Assert.Equal(result, result);
        }
    }
}
