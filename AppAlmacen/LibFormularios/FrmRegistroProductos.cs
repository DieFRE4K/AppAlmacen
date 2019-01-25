using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Utilizar libreria de clases
using LibClases;

namespace LibFormularios
{
    public partial class FrmRegistroProductos : LibFormularios.FrmPadre
    {
        public FrmRegistroProductos()
        {
            InitializeComponent();
            IniciarEntidad(new cProducto());//Inicializa entidad apuntando cEntidad
        }
        //Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodProducto.Text, TxtNombre.Text, TxtDireccion.Text, 
                                    TxtTelefono.Text, TxtRUC.Text };
        }
        //-------------------------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {
            //-- Muestra la información contenida en el dataset de cLibro
            TxtNombre.Text = aEntidad.ValorAtributo("Nombre");
            TxtDireccion.Text = aEntidad.ValorAtributo("Direccion");
            TxtTelefono.Text = aEntidad.ValorAtributo("Telefono");
            TxtRUC.Text = aEntidad.ValorAtributo("RUC");
        }
        //------------------------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TxtCodProducto.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtRUC.Text = "";
        }
        //----------------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        {
            //-- Mostrar todos los libros de la tabla en el grid
            DgvClientes.DataSource = aEntidad.ListaGeneral();
        }
        //----------------------------------------------------------------
        //-- Verificar los campos obligatorios (codigo y titulo) estén llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodProducto.Text.Trim() != "" && TxtNombre.Text.Trim() != "")
                return true;
            else
                return false;
        }
        // ======================= EVENTOS =====================
        private void TxtCodCliente_MouseLeave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void FrmRegistroClientes_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }
    }
}
