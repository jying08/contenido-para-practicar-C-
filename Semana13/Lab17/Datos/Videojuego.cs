//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Videojuego
    {
        public int Id_Videojuego { get; set; }
        public string Titulo { get; set; }
        public Nullable<decimal> Valoracion { get; set; }
        public Nullable<int> Id_Desarrollador { get; set; }
    
        public virtual Desarrollador Desarrollador { get; set; }
    }
}
