using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using System.Data;


namespace MercadoEnvio.Repositories {

  class RolesRepository {

    public int agregarRol( string rol_name )
    {
        var retorno = DBAdapter.executeProcedureWithReturnValue("Agregar_Rol", rol_name);
        return retorno;
    }

    public int agregarRelacionRolFuncionabilidad(int codRol,int codFuncionalidad)
    {
        var retorno = DBAdapter.executeProcedureWithReturnValue("Agregar_Rol_Por_Funcionalidad", codRol, codFuncionalidad);
        return retorno;
    }

    public void quitarFuncionabilidad( int codRol, string descripcionFuncionabilidad )
    {
        DBAdapter.executeProcedure("Quitar_Funcionalidad_A_Rol", descripcionFuncionabilidad, codRol);
    }

    public int modificarNombre( Rol rol, string nombre )
    {
        var retorno = DBAdapter.executeProcedureWithReturnValue("Modificar_Nombre_Rol", rol.Nombre, nombre );
        return retorno;
    }

    //public List<Rol> findRol(  string nombre  )
    //{
        //return parseRoles( DBAdapter.retrieveDataTable("Filtrar_Roles", nombre ));  
    //}

    public int ObtenerRolIDPorDescripcion(String descripcion)
    {
        var retorno = DBAdapter.executeProcedureWithReturnValue("ObtenerRol", descripcion );
        return retorno;
    }

    public Rol getRol( int idRol )
    {
      return parse( DBAdapter.retrieveDataTable("GetRol", idRol ).Rows[0]);
    }

    public List<Rol> getRoles()
    {
      return parseRoles( DBAdapter.retrieveDataTable( "Get_Roles" ));
    }


    public void modificarEstado( Rol rol, Boolean estado )
    {
      DBAdapter.executeProcedure("Modificar_Estado_Rol", 
      rol.Nombre,
      estado
      );
    }


    public void darDeBaja( Rol rol )
    {
      DBAdapter.executeProcedure("Baja_Rol", rol.Nombre );        
    }

    public List<Rol> parseRoles ( DataTable dataTable )
    {
      return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
    }

    public Rol parse(DataRow dr)
        {
          return new Rol(
            Convert.ToInt32(dr["Cod_Rol"]),
            dr["Nombre"] as string,
            ( bool ) dr["Estado_Rol"],
                new FuncionalidadRepository().getFuncionalidadesByRol( Convert.ToInt32(dr["Cod_Rol"]) )
          );
        }

    }
}