//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiSegura.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estadistica
    {
        public int Codigo { get; set; }
        public Nullable<int> CodigoUsuario { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public string Navegador { get; set; }
        public string PlataformaDispositivo { get; set; }
        public string FabricanteDispostivo { get; set; }
        public string Vista { get; set; }
        public string Accion { get; set; }
    }
}
