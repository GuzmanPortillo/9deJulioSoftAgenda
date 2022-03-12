using System;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class StockNegocio
    {
        StockDatos stockDatos = new StockDatos();
        public bool Existente(string Producto)
        {
            return stockDatos.Existe(Producto);
        }
        public bool ExisteId(int IdCodigo)
        {
            return stockDatos.ExisteId(IdCodigo);
        }
        
        public DataTable ListadoStock(string Producto)
        {
            DataTable tabla = new DataTable();
            tabla = stockDatos.ListaStock(Producto);
            return tabla;
        }
        public DataTable ListarStock()
        {
            DataTable tabla = new DataTable();
            tabla = stockDatos.ListarStock();
            return tabla;
        }
        public Tuple<string> Modificar(int IdCodigo)
        {
            return stockDatos.Modificar(IdCodigo);
        }
        public Tuple<string, string, string, string> LeerStk()
        {
            return stockDatos.LeerSt();
        }
    }
    public class ModeloStock
    {
        StockDatos stockDatos = new StockDatos();

        private string Producto;
        private int Cantidad;
        private int Total;


        public ModeloStock(string Producto, int Cantidad, int Total)
        {
            this.Producto = Producto;
            this.Cantidad = Cantidad;
            this.Total = Total;

        }


        public string CrearStock()
        {
            try
            {
                stockDatos.NuevoStock(Producto, Cantidad, Total);

                return "Ingreso de stock creado satisfactoriamente";

            }
            catch (Exception)
            {
                return "Ingreso de stock no pudo crearse, vuelva a intentarlo";
            }
        }
    
    }
    public class ModeloStockId
    {
        StockDatos stockDatos = new StockDatos();

        private int IdCodigo;
        public ModeloStockId(int IdCodigo)
        {
            this.IdCodigo = IdCodigo;

        }
        public string EliminarStock()
        {
            try
            {
                if (IdCodigo >= 0)
                {
                    stockDatos.BajaStock(IdCodigo);
                    return "Operacion realizada con éxito";
                }
                else {
                    return "Porfavor, verifique que el codigo ingresado sea valido";
                }

            }
            catch (Exception)
            {
                return "La operacion no pudo realizarse, vuelva a intentarlo";
            }
        }

    }
    public class ModeloStockMod
    {
        StockDatos stockDatos = new StockDatos();

        private int IdCodigo;
        private int Cantidad;
        private int Total;


        public ModeloStockMod(int IdCodigo, int Cantidad, int Total)
        {
            this.IdCodigo = IdCodigo;
            this.Cantidad = Cantidad;
            this.Total = Total;

        }


        public string ModificacionStock()
        {
            try
            {
                stockDatos.ModificarStock(IdCodigo, Cantidad, Total);

                return "Stock actualizado satisfactoriamente";

            }
            catch (Exception)
            {
                return "No se logro actualizar el stock , vuelva a intentarlo";
            }
        }

    }

}
