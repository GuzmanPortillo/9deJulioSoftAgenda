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
        private DateTime fecha;
        private string hora;
        private string nombreEvento;
        private int espacio;

        #endregion

        #region Properties
        public int ID
        {
            get => id;
            set { id = value; }

        }
        public DateTime Fecha
        {
            get => fecha;
            set { fecha = value; }
        }
        public string Hora
        {
            get => hora;
            set { hora = value.Replace(":", ""); }
        }
        public string NombreEvento
        {
            get => nombreEvento;
            set { nombreEvento = value; }
        }
        public int Espacio
        {
            get => espacio;
            set { espacio = value; }
        }

        public string Error { get; set; }
        #endregion

        public bool DatosValidos()
        {
            var resultado = true;
            this.Error = string.Empty;

            //si la fecha es menor a getdate
            if (this.fecha < DateTime.Now)
            {
                resultado = false;
                this.Error += "El evento no puede ser inferior a la fecha del día.";
            }

            //si el nombre esta vacio
            if (this.hora.Trim() == string.Empty)
            {
                resultado = false;
                this.Error += Environment.NewLine;
                this.Error += "Debe ingresar la hora del evento.";
            }

            //hora completa
            if (this.hora.Trim().Length != 4)
            {
                resultado = false;
                this.Error += Environment.NewLine;
                this.Error += "Formato de hora no valido.";
            }

            //hora valida
            if (resultado)
            {
                var horaAuxiliar = int.Parse(this.hora.Substring(0, 2));
                if (horaAuxiliar <= 0 || horaAuxiliar > 23)
                {
                    resultado = false;
                    this.Error += "Hora invalida.";
                }
            }
            

            //si el nombre esta vacio
            if (this.nombreEvento.Trim() == string.Empty)
            {
                resultado = false;
                this.Error += Environment.NewLine;
                this.Error += "Debe ingresar el nombre del evento.";
            }

            //si existe otro evento en la DB
            if (resultado)
            {
                //var dtEvento = objDatos.GetEvento("", 1, 1);

                //if (dtEvento.Rows.Count > 0)
                //{
                //    resultado = false;
                //    this.Error += Environment.NewLine;
                //    this.Error += "Ya existe un evento para la combinación de dia, hoya y establecimiento.";
                //}
            }

            return resultado;

            
            
        }
        private void PasarDatos()
        {
            objDatos.ID = id;
            objDatos.Hora = int.Parse(this.hora.Substring(0,2));
            objDatos.Fecha = this.fecha.Date;
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
