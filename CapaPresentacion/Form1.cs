using CapaEntidad;
using CapaNegocio;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        N_Agenda negocio = new N_Agenda();
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moverFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                ReleaseCapture();

                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tablaAgenda.SelectedRows.Count > 0)
            {
                int idContacto = Convert.ToInt32(tablaAgenda.SelectedRows[0].Cells["IDCONTACTO"].Value);
                N_Agenda negocio = new N_Agenda();
                negocio.EliminarContacto(idContacto);
                MessageBox.Show("Contacto eliminado con éxito.");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un contacto para eliminar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            E_Agenda nuevoContacto = new E_Agenda
            {
                Nombre = txtboxNombre.Text,
                Apellido = txtboxApellido.Text,
                Direccion = txtboxDireccion.Text,
                Telefono = txtboxTelefono.Text,
                Destino = txtboxDestino.Text,
                Fecha = boxFecha.Value
            };

            N_Agenda negocio = new N_Agenda();
            negocio.InsertarContacto(nuevoContacto);
            MessageBox.Show("Contacto guardado con éxito.");
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtboxNombre.Clear();
            txtboxApellido.Clear();
            txtboxDireccion.Clear();
            txtboxTelefono.Clear();
            txtboxDestino.Clear();
            boxFecha.Value = DateTime.Now;
            txtboxNombre.Focus();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string busqueda = txtBoxbuscar.Text.Trim();
            N_Agenda negocio = new N_Agenda();
            tablaAgenda.DataSource = negocio.BuscarContacto(busqueda);
        }

        private void CargarDatos()
        {
            N_Agenda negocio = new N_Agenda();
            tablaAgenda.DataSource = negocio.BuscarContacto(""); // Trae todos los contactos
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
