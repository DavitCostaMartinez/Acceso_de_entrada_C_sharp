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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("T");
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (Empleado.ComprobarDNI(txtNif.Text))
            {
                Empleado empleado = null;
                string seleccion = string.Format("select * from empleado where nif = '{0}'", txtNif.Text);
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    empleado = Empleado.BuscarEmpleado(ConexionBD.Conexion, seleccion);
                    ConexionBD.CerrarConexion();
                }
                else
                {
                    txtInfo.Text = "No hay conexión con la base de datos";
                }

                if (empleado != null)
                {
                    if (empleado.Admin)
                    {
                        btnClave.Show();
                        txtClave.Show();
                        txtNif.Enabled = false;
                        btnReset.Visible = true;
                        txtClave.Focus();
                        BloquearInterfaz();
                    }
                    else
                    {
                        txtInfo.Text = "El empleado no es administrador";
                    }
                }
                else
                {
                    txtInfo.Text = "Empleado Inexistente";
                }
            }
            else
            {
                txtInfo.Text = "DNI Incorrecto";
            }
        }

        private void btnClave_Click(object sender, EventArgs e)
        {
            Empleado empleado = null;
            string seleccion = string.Format("select * from empleado where nif = '{0}'", txtNif.Text);
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                empleado = Empleado.BuscarEmpleado(ConexionBD.Conexion, seleccion);
                ConexionBD.CerrarConexion();
            }
            else
            {
                txtInfo.Text = "No hay conexión con la base de datos";
            }

            if (empleado.Clave == txtClave.Text)
            {
                frmMantenimiento mantenimiento = new frmMantenimiento();
                mantenimiento.ShowDialog();
                this.Hide();
            }
            else
            {
                txtInfo.Text = "Clave incorrecta";
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Empleado.ComprobarDNI(txtNif.Text))
            {
                Empleado empleado = null;
                string seleccion = string.Format("select * from empleado where nif = '{0}'", txtNif.Text);
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    empleado = Empleado.BuscarEmpleado(ConexionBD.Conexion, seleccion);
                    ConexionBD.CerrarConexion();
                }
                else
                {
                    txtInfo.Text = "No hay conexión con la base de datos";
                }

                if (empleado != null)
                {
                    if (true)
                    {
                        Fichaje fichaje = null;
                        string select2 = string.Format("select * from fichaje where nif_empleado = '{0}' and fichado_entrada = 1 and fichado_salida = 0", empleado.Nif);
                        if (ConexionBD.Conexion != null)
                        {
                            ConexionBD.AbrirConexion();
                            fichaje = Fichaje.BuscarFichaje(ConexionBD.Conexion, select2);
                            ConexionBD.CerrarConexion();
                        }
                        else
                        {
                            txtInfo.Text = "No hay conexión con la base de datos";
                        }

                        if (fichaje == null)
                        {
                            if (ConexionBD.Conexion != null)
                            {
                                ConexionBD.AbrirConexion();
                                Fichaje.FicharEntrada(ConexionBD.Conexion, empleado.Nif);
                                ConexionBD.CerrarConexion();
                            }
                            else
                            {
                                txtInfo.Text = "No hay conexión con la base de datos";
                            }
                            txtInfo.Text = "Entrada Fichada correctamente";
                            btnReset.Visible = true;
                            BloquearInterfaz();
                        }
                        else
                        {
                            txtInfo.Text = "Ya está fichado";
                            btnReset.Visible = true;
                            BloquearInterfaz();
                        }
                    }
                }
                else
                {
                    txtInfo.Text = "Empleado Inexistente";
                }
            }
            else
            {
                txtInfo.Text = "DNI Incorrecto";
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (Empleado.ComprobarDNI(txtNif.Text))
            {
                Empleado empleado = null;
                string seleccion = string.Format("select * from empleado where nif = '{0}'", txtNif.Text);
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    empleado = Empleado.BuscarEmpleado(ConexionBD.Conexion, seleccion);
                    ConexionBD.CerrarConexion();
                }
                else
                {
                    txtInfo.Text = "No hay conexión con la base de datos";
                }

                if (empleado != null)
                {

                    Fichaje fichaje = null;
                    string select2 = string.Format("select * from fichaje where nif_empleado = '{0}' " +
                        "and fichado_entrada = 1 and fichado_salida = 0", empleado.Nif);
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        fichaje = Fichaje.BuscarFichaje(ConexionBD.Conexion, select2);
                        ConexionBD.CerrarConexion();
                    }
                    else
                    {
                        txtInfo.Text = "No hay conexión con la base de datos";
                    }

                    if (fichaje != null)
                    {
                        if (ConexionBD.Conexion != null)
                        {
                            ConexionBD.AbrirConexion();
                            Fichaje.FicharSalida(ConexionBD.Conexion, empleado.Nif);
                            ConexionBD.CerrarConexion();
                        }
                        else
                        {
                            txtInfo.Text = "No hay conexión con la base de datos";
                        }
                        txtInfo.Text = "Salida Fichada correctamente";
                        btnReset.Visible = true;
                        BloquearInterfaz();
                    }
                    else
                    {
                        txtInfo.Text = "No está fichada la entrada";
                        btnReset.Visible = true;
                        BloquearInterfaz();
                    }

                }
                else
                {
                    txtInfo.Text = "Empleado Inexistente";
                }
            }
            else
            {
                txtInfo.Text = "DNI Incorrecto";
            }
        }

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            List<Fichaje> fichajes = null;
            string seleccion = string.Format("select * from fichaje where fichado_entrada = '1' and fichado_salida = '0'");
            if (ConexionBD.Conexion != null)
            {
                ConexionBD.AbrirConexion();
                fichajes = Fichaje.BuscarFichajes(ConexionBD.Conexion, seleccion);
                ConexionBD.CerrarConexion();
            }
            else
            {
                txtInfo.Text = "No hay conexión con la base de datos";
            }

            if (fichajes != null)
            {
                txtInfo.Clear();
                foreach (Fichaje item in fichajes)
                {
                    Empleado empleado = null;
                    string select2 = string.Format("select * from empleado where nif = '{0}'", item.NIF);
                    if (ConexionBD.Conexion != null)
                    {
                        ConexionBD.AbrirConexion();
                        empleado = Empleado.BuscarEmpleado(ConexionBD.Conexion, select2);
                        ConexionBD.CerrarConexion();
                    }
                    else
                    {
                        txtInfo.Text = "No hay conexión con la base de datos";
                    }
                    txtInfo.Text += string.Format("{3}{0} {1} {2}", empleado.Nombre, empleado.Apellidos, item.Hora_Entrada, Environment.NewLine);
                }
            }
            else
            {
                txtInfo.Text = "No hay fichajes";
            }
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            if (Empleado.ComprobarDNI(txtNif.Text))
            {
                Empleado empleado = null;
                string seleccion = string.Format("select * from empleado where nif = '{0}'", txtNif.Text);
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    empleado = Empleado.BuscarEmpleado(ConexionBD.Conexion, seleccion);
                    ConexionBD.CerrarConexion();
                }
                else
                {
                    txtInfo.Text = "No hay conexión con la base de datos";
                }
                
                if (empleado != null)
                {
                    lblFecha_Inicial.Visible = true;
                    lblFecha_Final.Visible = true;
                    dtpInicial.Visible = true;
                    dtpFinal.Visible = true;
                    btnFechas.Visible = true;
                    txtNif.Enabled = false;
                    pcbfondo_per.Visible = true;
                    BloquearInterfaz();
                    btnReset.Visible = true;
                }
                else
                {
                    txtInfo.Text = "Empleado Inexistente";
                }
            }
            else
            {
                txtInfo.Text = "DNI Incorrecto";
            }
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            if (dtpInicial.Value > dtpFinal.Value)
            {
                txtInfo.Text = "La fecha final debe ser posterior a la fecha inicial";
            }
            else
            {
                List<Fichaje> fichajes = null;
                string seleccion = string.Format("select * from fichaje where nif_empleado = '{0}' and fichado_entrada = '1' and fichado_salida = '1' and dia between '{1}' and '{2}'", 
                    txtNif.Text, dtpInicial.Value.Day, dtpFinal.Value.ToString("yyyy-MM-dd"), dtpFinal.Value.ToString("yyyy-MM-dd")); 
                if (ConexionBD.Conexion != null)
                {
                    ConexionBD.AbrirConexion();
                    fichajes = Fichaje.BuscarFichajes(ConexionBD.Conexion, seleccion);
                    ConexionBD.CerrarConexion();
                }
                else
                {
                    txtInfo.Text = "No hay conexión con la base de datos";
                }

                if (fichajes != null)
                {
                    TimeSpan suma = new TimeSpan();
                    txtInfo.Clear();
                    foreach (Fichaje item in fichajes)
                    {
                        suma += item.Hora_Salida.Subtract(item.Hora_Entrada);
                        txtInfo.Text += string.Format("{4}{0} {1} {2} {3}",
                            item.Dia.ToString("dd-MM-yyyy"), item.Hora_Entrada, item.Hora_Salida, item.Hora_Salida.Subtract(item.Hora_Entrada).ToString("hh\\:mm"),Environment.NewLine);
                    }
                    txtInfo.Text += string.Format("{1}Tiempo Total: {0}",suma, Environment.NewLine);
                    btnReset.Visible = true;

                }
                else
                {
                    txtInfo.Text = "No hay fichajes";
                    btnReset.Visible = true;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetearInterfaz();
        }

        private void ResetearInterfaz()
        {
            txtNif.Clear();
            txtNif.Enabled = true;
            txtInfo.Clear();
            dtpInicial.Visible = false;
            dtpFinal.Visible = false;
            lblFecha_Inicial.Visible = false;
            lblFecha_Final.Visible = false;
            btnFechas.Visible = false;
            btnReset.Visible = false;
            pcbfondo_per.Visible = false;
            txtClave.Clear();
            txtClave.Visible = false;
            btnClave.Visible = false;
            btnEntrar.Enabled = true;
            btnSalida.Enabled = true;
            btnPresencia.Enabled = true;
            btnPermanencia.Enabled = true;
            btnMantenimiento.Enabled = true;
        }

        private void BloquearInterfaz()
        {
            txtNif.Enabled = false;
            btnEntrar.Enabled = false;
            btnSalida.Enabled = false;
            btnPresencia.Enabled = false;
            btnPermanencia.Enabled = false;
            btnMantenimiento.Enabled = false;
        }
    }
}
