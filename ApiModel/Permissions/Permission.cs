using System;
using Dapper.Contrib.Extensions;

namespace ApiModel.Permissions
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public int TipoPermiso { get; set; }
        public DateTime FechaPermiso { get; set; }
    }
}
