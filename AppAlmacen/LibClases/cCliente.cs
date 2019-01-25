using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cCliente : cEntidad
    {
        //------------ ATRIBUTOS -------------
        //-- Se heredan de cEntidad

        //------------ METODOS ---------------
        //----- Constructores
        public cCliente() : base("TCliente")
        {
        }
        //---- Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            return new string[] { "CodCliente", "Nombre", "Direccion", "Telefono", "RUC"};
        }
    }
}
