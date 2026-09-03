using CapaModelo_MVC4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_MVC4
{
    internal class Controlador
    {
        Sentencias sentencias = new Sentencias();
        public DataTable llenarDgv(string nombreTabla)
        {
            OdbcDataAdapter daControlador = sentencias.llenarTbl(nombreTabla);
            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);
            return dtControlador;
        }
    }
}
