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
    
    public partial class Hijo
    {
        public int Id { get; set; }
        public string Ci_Hijo { get; set; }
        public string Nombre_Hijo { get; set; }
        public string Apellido_Hijo { get; set; }
        public string FechaNaciemiento_Hijo { get; set; }
        public string Genero_Hijo { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}
