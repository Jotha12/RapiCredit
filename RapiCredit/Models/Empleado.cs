//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RapiCredit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int ID { get; set; }
        public string DPI { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string OtrosNombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string TelefonoMovil { get; set; }
        public string Rol { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaRetiro { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> Sucursal { get; set; }
    }
}
