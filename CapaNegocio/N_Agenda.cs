using Capa_Datos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class N_Agenda
    {
        private D_Agenda datos = new D_Agenda();

        
        public void InsertarContacto(E_Agenda contacto)
        {
            datos.InsertarContacto(contacto);
        }

        // Método para editar un contacto
        public void EditarContacto(E_Agenda contacto)
        {
            datos.EditarContacto(contacto);
        }

        // Método para eliminar un contacto
        public void EliminarContacto(int idContacto)
        {
            datos.EliminarContacto(idContacto);
        }

        // Método para buscar contactos
        public DataTable BuscarContacto(string buscar)
        {
            return datos.BuscarContacto(buscar);
        }
    }
}
