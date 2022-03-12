using CapaDatos;
using System;
using System.Data;

namespace CapaNegocio
{
    public class CN_Reservas
    {
        ReservasDatos reservasDatos = new ReservasDatos();

        public bool ValDni(string Dni)
        {
            return reservasDatos.Documento(Dni);
        }
        public DataTable ListaDeReservas(string fecInicio, string Fecfin)
        {
            DataTable tabla = new DataTable();
            tabla = reservasDatos.ListaDeReservas(fecInicio, Fecfin);
            return tabla;
        }
        /*public bool Leer(string Dni, string Nombre, string Apellido)
        {
                Console.WriteLine(Dni);
                Console.WriteLine(Nombre);
                Console.WriteLine(Apellido);
               
            return reservasDatos.Leer(Dni, Nombre, Apellido);
           
        }*/
        public Tuple<string, string> Leer(string Dni)
        {
            return reservasDatos.Leer(Dni);
        }
            public bool CheckF()
        {
            return reservasDatos.CheckF();
        }
        public bool CheckB()
        {
            return reservasDatos.CheckB();
        }

    }
    public class ModeloReserva
    {
        ReservasDatos reservasDatos = new ReservasDatos();

        private string Nombre;
        private string Apellido;
        private string Dni;
        private string Deporte;
        private string Fecha;
        private string Horario;
        

        public ModeloReserva( string Nombre, string Apellido, string Dni, string Deporte, string Fecha, string Horario)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Dni = Dni;
            this.Deporte = Deporte;
            this.Fecha = Fecha;
            this.Horario = Horario;
            
        }

        public string CrearReserva()
        {
            try
            {
                reservasDatos.NuevaReserva(Nombre, Apellido, Dni, Deporte, Fecha, Horario);

                return "La reserva ha sido creado satisfactoriamente";

            }
            catch (Exception)
            {
                return "La reserva no pudo crearse, vuelva a intentarlo";
            }
        }

    }
}

