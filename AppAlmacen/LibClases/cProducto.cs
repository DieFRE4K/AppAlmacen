using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cProducto : cEntidad
    {
        //------------ ATRIBUTOS -------------
        //-- Se heredan de cEntidad

        //------------ METODOS ---------------
        //----- Constructores
        public cProducto() : base("TProducto")
        {
        }
        //---- Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] { "CodProducto", "Producto", "Marca", "UnidadMedida", "PrecioUnitario", "Stock" ,"CodTipoProducto" };
        }

        //=========================================================================================
        //Ir haciendo estos cambios en el AppVentas y aumentar parametros para aceptar claves compuestas
        //==========================================================================================
    }
}
