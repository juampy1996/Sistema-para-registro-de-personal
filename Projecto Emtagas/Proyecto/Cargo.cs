//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cargo
    {
        public Cargo()
        {
            this.Personal = new HashSet<Personal>();
        }
    
        public int Id { get; set; }
        public string NombreCargo { get; set; }
    
        public virtual ICollection<Personal> Personal { get; set; }
    }
}
