using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aev7
{
    class Empleado
    {
        private string NIF;
        private string nombre;
        private string apellidos;
        private bool admin;
        private string clave;

        public Empleado(string NIF, string nombre, string apellidos, bool admin, string clave)
        {
            this.NIF = NIF;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.admin = admin;
            this.clave = clave;
        }

        public string Nif { get { return NIF; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }
        public string Clave { get { return clave; } }
        public bool Admin { get { return admin; } }

        public static List<Empleado> BuscarEmpleados(MySqlConnection conexion, string seleccion)
        {
            List<Empleado> lista = new List<Empleado>();
            
            MySqlCommand comando = new MySqlCommand(seleccion, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Empleado empleado = new Empleado(reader.GetString(0), reader.GetString(1),
                        reader.GetString(2), reader.GetBoolean(3), reader.GetString(4));
                    lista.Add(empleado);
                }
            }
            return lista;
        }

        public static void InsertarEmpleado(MySqlConnection conexion, Empleado emp)
        {
            try
            {
                string consulta;
                if (emp.Admin)
                {
                    consulta = String.Format("INSERT INTO empleado (nif,nombre,apellidos,administrador,clave) VALUES " +
                    "('{0}','{1}','{2}','{3}','{4}')", emp.Nif, emp.nombre, emp.apellidos, 1, emp.clave);
                }
                else
                {
                    consulta = String.Format("INSERT INTO empleado (nif,nombre,apellidos,administrador,clave) VALUES " +
                    "('{0}','{1}','{2}','{3}','{4}')", emp.Nif, emp.nombre, emp.apellidos, 0, emp.clave);
                }

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ese DNI ya existe");
            }
        }

        public static void EliminarEmpleado(MySqlConnection conexion, Empleado emp)
        {
            string consulta;
            consulta = String.Format("DELETE FROM empleado WHERE nif = '{0}'", emp.Nif);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
        }

        public static Empleado BuscarEmpleado(MySqlConnection conexion, string seleccion)
        {
            MySqlCommand comando = new MySqlCommand(seleccion, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                Empleado empleado = new Empleado(reader.GetString(0),
                    reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetString(4));
                return empleado;
            }
            else
            {
                return null;
            }
        }

        public static bool ComprobarDNI(string dni)
        {

            if (dni.Length != 9)
            {
                return false;
            }


            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);

            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                return false;
            }
            if (CalcularLetraDNI(dniInteger) != dniLeter)
            {
                return false;
            }
            return true;
        }


        private static string CalcularLetraDNI(int dniNumbers)
        {
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }
    }
}
