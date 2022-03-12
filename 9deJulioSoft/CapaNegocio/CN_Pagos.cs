using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Pagos

    {
        private CD_Pagos objPagos = new CD_Pagos();


        #region Atributos
        private int idsociocuota;
        //private string fecha;
        //private string hora;
        //private string nombreEvento;
        //private int espacio;

        #endregion
        #region Properties
        public int Idsociocuota
        {
            get => idsociocuota;
            set { idsociocuota = value; }

        }
        //public string Fecha
        //{
        //    get => fecha;
        //    set { fecha = value; }
        //}
        //public string Hora
        //{
        //    get => hora;
        //    set { hora = value; }
        //}
        //public string NombreEvento
        //{
        //    get => nombreEvento;
        //    set { nombreEvento = value; }
        //}
        //public int Espacio
        //{
        //    get => espacio;
        //    set { espacio = value; }
        //}
        #endregion

        private void PasarDatos()
        {
            objPagos.Idsociocuota = idsociocuota;
        }

        public DataTable consultar_cuota(int nro_socio)
        {
            DataTable tabla = new DataTable();
            tabla = objPagos.consultarCuotas(nro_socio);
            return tabla;
        }

        public void Actualizar_Cuota()
        {
            PasarDatos();
            objPagos.ActualizarCuota();
        }

    }
}
