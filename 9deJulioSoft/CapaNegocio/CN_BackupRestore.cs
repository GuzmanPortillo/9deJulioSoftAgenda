using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_BackupRestore
    {
        private CD_BackupRestore objbkpRes = new CD_BackupRestore();
        //public DataTable consultarEventoItem(string query)
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = objbkpRes.Mitabla(query);
        //    return tabla;
        //}

        public void dbGeneral(string query)
        {
            objbkpRes.general_query(query);
        }
    }
}
