using System;
using ApiBusinessLogic.Interfaces.Permissions;
using ApiModel.General;
using ApiModel.Permissions;
using Microsoft.AspNetCore.Mvc;

namespace Web_ApiCore.Controllers.Permissions
{
    [Route("api/permission")]
    public class PermissionController : Controller
    {
        private ResponseDTO _responseDTO = new ResponseDTO();
        private IPermissionLogic _logic;
        public PermissionController(IPermissionLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public IActionResult GetPermissions()
        {
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetPermissions());
                return Ok(response);
            }
            catch(Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        public IActionResult RequestPermission(Permission dto)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.RequestPermission(dto));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPut]
        public IActionResult ModifyPermission(Permission dto)
        {
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.ModifyPermission(dto));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }
    }
}
