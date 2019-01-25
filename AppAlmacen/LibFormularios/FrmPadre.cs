using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//utilizando libreria de clases
using LibClases;

namespace LibFormularios
{
    public partial class FrmPadre : Form
    {
        //---------------- ATRIBUTOS ------------------
        protected cEntidad aEntidad;

        //---------------- METODOS --------------------
        //--------------- Constructor -----------------
        public FrmPadre()
        {
            InitializeComponent();
        }
        //-------------- Metodos base ----------------
        //Metodo Virtual... pero pinta para Abstracto (Es obligatorio para los hijos, pero...)
        public virtual string[] AsignarValoresAtributos()
        {
            return null;
        }
        //--------------------------------------------
        public void IniciarEntidad(cEntidad pEntidad)
        {
            //-- Indicar con que entidad trabajará el formulario
            aEntidad = pEntidad;
        }
        //-------------------------------------------------
        public virtual void InicializarAtributoClave()
        {   //--Dar valores a los controles relacionados al atributo clave
        }
        //-------------------------------------------------
        public virtual void InicializarAtributosNoClave()
        {   //--Dar valores a los controles relacioados a los tributos no clave
        }
        //-----------------------------------------------------
        public virtual void InicializarAtributos()
        {   //--Dar valor inicial a todos los atributos del formulario
            InicializarAtributoClave();
            InicializarAtributosNoClave();
        }
        //------------------------------------------------------
        public virtual void MostrarDatos()
        {   //----Visualiza la informacion de un registro en el formulario
        }
        public virtual void ListarRegistros()
        {   //----Lista todos los registros de la tabla relacionada
        }
        //--------------------------------------------------------
        public virtual bool EsRegistroValido()
        {   //---Verifica que los datos obligatorios esten completos en el formulario
            return true;
        }
        //---------------------------------------------------------
        public virtual void ProcesarClave()
        {
            //-----Recuperar atributos,el primer atributo es clave 
            string[] Atributos = AsignarValoresAtributos();
            //-----Verificar si existe clave primaria 
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {   //--------Registro existente,Recuperar Atributos y mostrarlos
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {   //----Registro nuevo, inicializar atributos no clave
                InicializarAtributosNoClave();
            }
        }
        public virtual void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {   //-----Recuperar atributos,el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //----Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                        aEntidad.Actualizar(Atributos);
                    else
                        aEntidad.Insertar(Atributos);
                    //---Inicializar el formulario
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    InicializarAtributos();
                    ListarRegistros();
                }
                else MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
        //-----------------------EVENTOS-----------------------
        //Si se programa el click en el hijo no lo reemplazará... solo se agregará mas código que se ejecutará despues
        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            Grabar();//Este metodo si se puede redefinir si se quiere que el button del hijo haga algo diferente
        }
        //-----------------------------------------------------
        private void BtnSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //----------------------------------------------------
        private void BtnNuevo_Click(object sender, System.EventArgs e)
        {
            InicializarAtributos();
        }
       
    }
}
