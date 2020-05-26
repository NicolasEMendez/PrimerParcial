using System;

namespace Comun
{
    public class MenuItem
    {
        public int? SubMenuId { get; set; }
        public string Descripcion { get; set; }
        public Action Accion { get; set; }
    }
}
