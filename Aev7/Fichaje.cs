using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aev7
{
    class Fichaje
    {
        private string NIF_Empleado;
        private DateTime dia;
        private TimeSpan hora_Entrada;
        private TimeSpan hora_Salida;
        private bool entrada;
        private bool salida;
        
        public Fichaje(string NIF_Empleado, DateTime dia, TimeSpan hora_Entrada, TimeSpan hora_Salida, bool entrada, bool salida)
        {
            this.NIF_Empleado = NIF_Empleado;
            this.dia = dia;
            this.hora_Entrada = hora_Entrada;
            this.hora_Salida = hora_Salida;
            this.entrada = entrada;
            this.salida = salida;
        }

        public string NIF { get { return NIF_Empleado; } }
        public DateTime Dia { get { return dia; } }
        public TimeSpan Hora_Entrada { get { return hora_Entrada; } }
        public TimeSpan Hora_Salida { get { return hora_Salida; } }
        public bool Entrada { get { return entrada; } }
        public bool Salida { get { return salida; } }

        public static Fichaje BuscarFichaje(MySqlConnection conexion, string seleccion)
        {
            MySqlCommand comando = new MySqlCommand(seleccion, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                Fichaje fichaje = new Fichaje(reader.GetString(0),
                    reader.GetDateTime(1), reader.GetTimeSpan(2), reader.GetTimeSpan(3), reader.GetBoolean(4), reader.GetBoolean(5));
                return fichaje;
            }
            else
            {
                return null;
            }
        }
        public static void FicharEntrada(MySqlConnection conexion, string nif)
        {
            string consulta = String.Format("INSERT INTO fichaje (nif_empleado,dia,hora_entrada,hora_salida,fichado_entrada,fichado_salida) VALUES " +
                        "('{0}','{1}','{2}','{3}','{4}','{5}')", nif, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH:mm:ss"), null, 1,0);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
        }
        
        public static void FicharSalida(MySqlConnection conexion, string nif)
        {
            string consulta = String.Format("UPDATE fichaje SET hora_salida='{0}', fichado_salida = '{1}' WHERE nif_empleado = '{2}' and fichado_salida = 0",DateTime.Now.ToString("HH:mm:ss"),1,nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
        }
        
        public static List<Fichaje> BuscarFichajes(MySqlConnection conexion, string seleccion)
        {
            List<Fichaje> fichajes = new List<Fichaje>();
            MySqlCommand comando = new MySqlCommand(seleccion, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Fichaje fichaje = new Fichaje(reader.GetString(0),
                                        reader.GetDateTime(1), reader.GetTimeSpan(2), 
                                        reader.GetTimeSpan(3), reader.GetBoolean(4), 
                                        reader.GetBoolean(5));
                    fichajes.Add(fichaje);
                }
                return fichajes;
            }
            else
            {
                return null;
            }
        }
    }
}
