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
    
    public partial class TransaccionPrestamo
    {
        public int ID { get; set; }
        public Nullable<int> IdPrestamo { get; set; }
        public Nullable<int> NoCuota { get; set; }
        public Nullable<decimal> MontoCapital { get; set; }
        public Nullable<decimal> MontoInteres { get; set; }
        public Nullable<decimal> MontoMora { get; set; }
        public Nullable<int> Capital { get; set; }
        public Nullable<int> EsCuota { get; set; }
        public Nullable<System.DateTime> FechaPago { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
    }
}
