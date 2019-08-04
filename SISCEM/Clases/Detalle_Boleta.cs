using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISCEM
{
    class Detalle_Boleta
    {
              
        //Detalle-Boleta
        public string D_detlle_id { get; set; }
        public int D_Boleta_Id { get; set; }
        public int D_Cliente_Id { get; set; }
        public string D_Cliente_Nombre { get; set; }
        public int D_Tipo_documento { get; set; }
        public int D_Categoria_Id { get; set; }
        public string D_Categoria_Nombre { get; set; }
        public int D_Kilateje { get; set; }
        public string D_SubCategoria_Nombre { get; set; }
        public string D_Estado { get; set; }
        public string D_Descripcion { get; set; }
        public decimal D_Peso { get; set; }
        public decimal D_P_Piedra { get; set; }
        public string D_Boleta_Fecha { get; set; }
        public string D_Boleta_Fecha_Vencimiento { get; set; }
        public string D_Plazo { get; set; }        
        public Decimal D_Prestamo { get; set; }
        public Decimal D_Avaluo { get; set; }
   
       
        //Encabezado
        public int E_Boleta_Id { get; set; }
        public int E_Cliente_Id { get; set; }
        public string E_Boleta_Fecha { get; set; }
        public string E_Boleta_Fecha_Vencimiento { get; set; }
        public int E_Tipo_documento { get; set; }
        public int E_Categoria_Id { get; set; }
        public Decimal E_Prestamo { get; set; }
        public Decimal E_Avaluo { get; set; }

    }
}
