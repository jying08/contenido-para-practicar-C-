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
    
    public partial class DocentexCurso
    {
        public int Docente_id { get; set; }
        public int Id_curso { get; set; }
        public string Semestre { get; set; }
    
        public virtual Curso Curso { get; set; }
        public virtual Docente Docente { get; set; }
    }
}
