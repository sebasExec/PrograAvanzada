//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoPrograAvanzada.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        public int IdCurso { get; set; }
        public int IdReceta { get; set; }
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Profesor { get; set; }
        public string Horario { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
    }
}
