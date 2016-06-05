using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using System.Data;

namespace MercadoEnvio.Repositories
{
    class FuncionalidadRepository
    {
       
        public Funcionalidades getFuncionalidad(int codigo)
        {
            return parse(DBAdapter.retrieveDataTable("Get_Funcionalidad", codigo).Rows[0]);
        }

        public List<Funcionalidades> getFuncionalidades()
        {
            return parseFuncionalidad(DBAdapter.retrieveDataTable("Get_Funcionalidades"));
        }

        public List<Funcionalidades> getFuncionalidadesByRol(int codRol )
        {
            return parseFuncionalidades(DBAdapter.retrieveDataTable("Get_Funcionalidades_De_Rol", codRol));
        }

        public List<Funcionalidades> parseFuncionalidad(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }
        
        public List<Funcionalidades> parseFuncionalidades(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public Funcionalidades parse(DataRow dr)
        {
            return new Funcionalidades(
                Convert.ToInt32(dr["Cod_Funcionalidad"]),
                dr["Descripcion_Funcionalidad"] as string
            );
        }

    }
}
