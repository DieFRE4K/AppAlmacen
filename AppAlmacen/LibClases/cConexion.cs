﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para tener acceso al adaptador, dataset...
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    class cConexion
    {
        //=================== ATRIBUTOS ====================
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        //================== METODOS =======================
        //----------------- Constructor -------------------- 
        public cConexion()
        {
            //Iniciar la conexion
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            //Realizar la conexion
            String CadenaConexion = "Data Source=INFO-PC;Initial Catalog=BDAlmacen;Integrated Security=SSPI;";
            //String CadenaConexion = "Data Source=DESKTOP-SNCH8FI\\SQLEXPRESS;Initial Catalog=BdBiblioteca;Integrated Security=SSPI;";
            //Si el nombre del servidor tiene un 'contraslash' se debe colocar doble
            aConexion = new SqlConnection(CadenaConexion);
        }
        //------------------ Propiedades -------------------
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }
        //--------------------------------------------------
        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }
        //--------------------------------------------------
        public DataSet Datos
        {
            get { return aDatos; }
        }
        //------------------- Servicios --------------------
        //-- Metodos para ejecutar comandos sql server
        //-- Devuelve el resultado en la tabla cero del dataser
        //-- Virtual: Metodos que pueden heredad los hijos
        public virtual DataSet EjecutarSelect(string pConsulta)
        {
            //Metodo para ejecutar consultas del tipo SELECT
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        //----------------------------------------------------------------
        //-- Metodo para ejecutar instrucciones DML. No retorna resultado
        //----------------------------------------------------------------
        public virtual void EjecutarComando(string pComando)
        {
            //Metodo para ejecutar consultas del tipo INSERT, UPDATE, DELETE
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
    }
}
