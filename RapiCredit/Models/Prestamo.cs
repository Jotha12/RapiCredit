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
    
    public partial class Prestamo
    {
        public int ID { get; set; }
        public Nullable<int> IdSolicitud { get; set; }
        public Nullable<int> IdTipoPrestamo { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<System.DateTime> FechaAutorizacion { get; set; }
        public Nullable<int> NoDeCuotas { get; set; }
        public Nullable<System.DateTime> FechaPago { get; set; }
        public Nullable<decimal> InteresMora { get; set; }
    }
}