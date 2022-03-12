using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Agenda
    {
        private CD_Agenda objDatos = new CD_Agenda();

        #region Atributos
        private int id;
        private string fecha;
        private string hora;
        private string nombreEvento;
        private string espacio;

        #endregion

        #region Properties
        public int ID
        {
            get => id;
            set { id = value; }

        }
        public string Fecha
        {
            get => fecha;
            set { fecha = value; }
        }
        public string Hora
        {
            get => hora;
            set { hora = value; }
        }
        public string NombreEvento
        {
            get => nombreEvento;
            set { nombreEvento = value; }
        }
        public string Espacio
        {
            get => espacio;
            set { espacio = value; }
        }

        #endregion
        private void PasarDatos()
        {
            objDatos.ID = id;
            objDatos.Hora = this.hora;
            objDatos.Fecha = this.fecha;
            objDatos.NombreEvento = this.nombreEvento;
            objDatos.Espacio = Convert.ToInt32(this.espacio);

        }

        public DataTable consultarAgenda(string fecInicio, string Fecfin)
        {
            DataTable tabla = new DataTable();
            tabla = objDatos.consultarAgenda(fecInicio, Fecfin);
            return tabla;
        }
        public DataTable consultar_ListaEventos(string fecInicio, string Fecfin)
        {
            DataTable tabla = new DataTable();
            tabla = objDatos.consultarListaEventos(fecInicio, Fecfin);
            return tabla;
        }
        public DataTable consultarEventoItem(int idapp )
        {
            DataTable tabla = new DataTable();
            tabla = objDatos.MostrarEventoSelec(idapp);
            return tabla;
        }
        public void insertar_Datos()
        {
            PasarDatos();
            objDatos.insertarDatos();
        }
        public void Actualizar_datos()
        {
            PasarDatos();
            objDatos.Actualizar();
        }
        public void Eliminar()
        {
            PasarDatos();
            objDatos.Delete();
        }
    }
}
