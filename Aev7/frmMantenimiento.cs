using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aev7
{
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void btnCerrarm_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            CargarListaEmpleados();
            CargarListaFichajes();
        }

        ///////////////////////////////////////////////

        private void CargarListaFichajes()
        {
            string seleccion = "Select * from fichaje";
            // Necesita propiedades para funcionar porque, no lo se, PREGUNTAR A SALVA!!!!!
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                dgvFichajes.DataSource = Fichaje.BuscarFichajes(ConexionBD.Conexion, seleccion);
                ConexionBD.CerrarConexion();
            }
        }
        private void CargarListaEmpleados()
        {
            string seleccion = "Select * from empleado";
            // Necesita propiedades para funcionar porque, no lo se, PREGUNTAR A SALVA!!!!!
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                dgvEmpleados.DataSource = Empleado.BuscarEmpleados(ConexionBD.Conexion, seleccion);
                ConexionBD.CerrarConexion();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado(txtNif.Text, txtNombre.Text,
                txtApellidos.Text, chkAdmin.Checked, txtClave.Text);
            if (Empleado.ComprobarDNI(empleado.Nif))
            {
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    Empleado.InsertarEmpleado(ConexionBD.Conexion, empleado);
                    ConexionBD.CerrarConexion();
                }
                CargarListaEmpleados();
                LimpiarDatos();
            }
            else
            {
                ErrorProv.SetError(txtNif, "El DNI no es valido");
            }
        }

        private void LimpiarDatos()
        {
            txtApellidos.Clear();
            txtClave.Clear();
            txtNif.Clear();
            txtNombre.Clear();
            chkAdmin.Checked = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                Empleado empleado = new Empleado(dgvEmpleados.CurrentRow.Cells[0].Value.ToString(),
                                        dgvEmpleados.CurrentRow.Cells[1].Value.ToString(),
                                        dgvEmpleados.CurrentRow.Cells[2].Value.ToString(),
                                        Convert.ToBoolean(dgvEmpleados.CurrentRow.Cells[4].Value),
                                        dgvEmpleados.CurrentRow.Cells[3].Value.ToString());
                // Comprobar lo de arriba, no me termina de convencer
                
                DialogResult confirmacion = MessageBox.Show("Borrado el registro seleccionado. ¿Continuar?",
                                                    "Eliminación", MessageBoxButtons.YesNo);
                
                if (confirmacion == DialogResult.Yes)
                {
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        Empleado.EliminarEmpleado(ConexionBD.Conexion, empleado);
                        ConexionBD.CerrarConexion();
                    }
                    CargarListaEmpleados();
                }
            }


        }
    }
}
