using System.Data.SqlClient;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using NLog.Internal;
using System.Data;
using CapaEntidad;

namespace Capa_Datos
{
    public class D_Agenda
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


        public void InsertarContacto(E_Agenda contacto)
        {
            SqlCommand comando = new SqlCommand("SP_INSERTARCONTACTOS", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE", contacto.Nombre);
            comando.Parameters.AddWithValue("@APELLIDO", contacto.Apellido);
            comando.Parameters.AddWithValue("@DIRECCION", contacto.Direccion);
            comando.Parameters.AddWithValue("@TELEFONO", contacto.Telefono);
            comando.Parameters.AddWithValue("@DESTINO", contacto.Destino);
            comando.Parameters.AddWithValue("@FECHA", contacto.Fecha);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Método para editar un contacto
        public void EditarContacto(E_Agenda contacto)
        {
            SqlCommand comando = new SqlCommand("SP_EDITARCONTACTOS", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDCONTACTO", contacto.IDContacto);
            comando.Parameters.AddWithValue("@NOMBRE", contacto.Nombre);
            comando.Parameters.AddWithValue("@APELLIDO", contacto.Apellido);
            comando.Parameters.AddWithValue("@DIRECCION", contacto.Direccion);
            comando.Parameters.AddWithValue("@TELEFONO", contacto.Telefono);
            comando.Parameters.AddWithValue("@DESTINO", contacto.Destino);
            comando.Parameters.AddWithValue("@FECHA", contacto.Fecha);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Método para eliminar un contacto
        public void EliminarContacto(int idContacto)
        {
            SqlCommand comando = new SqlCommand("SP_ELIMINARCONTACTOS", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDCONTACTO", idContacto);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // Método para buscar contactos
        public DataTable BuscarContacto(string buscar)
        {
            SqlCommand comando = new SqlCommand("SP_BUSCARCONTACTOS", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@BUSCAR", buscar);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
    }

    

}
