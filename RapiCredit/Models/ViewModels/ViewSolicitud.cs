using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace RapiCredit.Models.ViewModels
{
    public class ViewSolicitud
    {
  
           public int Id {get; set; }
           public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string DPI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public int Monto { get; set; }
        public int Cuotas { get; set; }





    }
}