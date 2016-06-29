using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MercadoEnvio.Utils;
using MercadoEnvio.Domain;

namespace MercadoEnvio.Repositories
{
    class VisibilidadRepository
    {

        public int altaVisibilidad( string Descripcion_Visibilidad, int Precio_Visibilidad, int Porcentaje, int Comision_Entregas )
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Alta_Visibilidad",
                Descripcion_Visibilidad,
                Precio_Visibilidad,
                Porcentaje,
                Comision_Entregas
                );
            return retorno;
        }

        public void modificarVisibilidad(VisibilidadPublicaciones visibilidad)
        {
            DBAdapter.executeProcedure("Modificacion_Visibilidad",
                visibilidad.Cod_Visibilidad,
                visibilidad.Descripcion_Visibilidad,
                visibilidad.Precio_Visibilidad,
                visibilidad.Porcentaje,
                visibilidad.Comision_Entregas);
        }

        public void bajaVisibilidad(VisibilidadPublicaciones visibilidad)
        {
            DBAdapter.executeProcedure("Baja_Visibilidad",
                visibilidad.Cod_Visibilidad );
        }

        public VisibilidadPublicaciones getVisibilidad(int codigo)
        {
            var retorno = parse(DBAdapter.retrieveDataTable("Get_Visibilidad", codigo).Rows[0]);
            return retorno;
        }

        public List<VisibilidadPublicaciones> filtrarVisibilidades(string nombreVisibilidad)
        {
            return parseVisibilidades(DBAdapter.retrieveDataTable("Filtrar_Visibilidad", nombreVisibilidad));
        }

        public List<VisibilidadPublicaciones> getVisibilidades()
        {
            return parseVisibilidades(DBAdapter.retrieveDataTable("Get_Visibilidades"));
        }

        public List<VisibilidadPublicaciones> parseVisibilidades(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public VisibilidadPublicaciones parse(DataRow dr)
        {
            return new VisibilidadPublicaciones(
                Convert.ToInt32(dr["Cod_Visibilidad"]),
                dr["Descripcion_Visibilidad"] as string,
                Convert.ToInt32(dr["Precio_Visibilidad"]),
                Convert.ToInt32(dr["Porcentaje"]),
                Convert.ToInt32(dr["Comision_Entregas"]),
                Convert.ToBoolean(dr["Estado_Visibilidad"])
            );
        }

    }
}
