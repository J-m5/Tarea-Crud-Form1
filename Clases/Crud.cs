using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miformulario.Clases
{
    public class Crud
    {


        string connectionString = "Server=MARIO\\SQLEXPRESS;Database=UMG;Integrated Security=True; TrustServerCertificate=True; ";
        public string MostrarInformacion(string carnet)
        {
            string nombre = "No Existe";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = $"SELECT * FROM Tb_alumnos where carnet = '{carnet}' ";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nombre = reader["estudiante"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    nombre = "Error";
                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return nombre;
        }
        public string MostrarInformacionSeccion(string carnet)
        {

            string seccion = "No Existe";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = $"SELECT * FROM Tb_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        seccion = reader["seccion"].ToString();

                    }

                }
                catch (Exception ex)
                {

                    seccion = "Error";


                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return seccion;

        }
        public string MostrarInformacionCorreo(string carnet)
        {

            string correo = "No Existe";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = $"SELECT * FROM Tb_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        correo = reader["email"].ToString();

                    }

                }
                catch (Exception ex)
                {

                    correo = "Error";


                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return correo;

        }
        public string AgregarAlumno(string carnet, string nombre, string email, string seccion)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String query = "insert into tb_alumnos (carnet, estudiante, email, seccion) values(@carnet,@nombre,@email,@seccion)";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return "Registros insertados exitosamente";

                }
                catch (Exception ex)
                {
                    return "Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message;
                }
                connection.Close();
            }
        }
        public string MostrarTareas(string carnet)
        {
            string resultado = "No Existe";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT nota1, nota2, nota3, nota4 FROM tareas WHERE carnet = @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        resultado = $"Nota1: {reader["nota1"]}, Nota2: {reader["nota2"]}, Nota3: {reader["nota3"]}, Nota4: {reader["nota4"]}";
                    }
                }
                catch (Exception ex)
                {
                    resultado = "Error";
                    //Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
            return resultado;
        }



    }
} 

