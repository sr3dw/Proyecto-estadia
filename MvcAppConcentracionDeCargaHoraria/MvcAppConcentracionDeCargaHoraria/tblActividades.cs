//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAppConcentracionDeCargaHoraria
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblActividades
    {
        public tblActividades()
        {
            this.tblProgramarActividad = new HashSet<tblProgramarActividad>();
        }
    
        public int idActividad { get; set; }
        public string vchActividad { get; set; }
        public string vchActDescripcion { get; set; }
    
        public virtual ICollection<tblProgramarActividad> tblProgramarActividad { get; set; }
    }
}
