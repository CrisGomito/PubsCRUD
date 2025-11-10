using System;
using System.Data.SqlClient;
using PubsCRUD.Config;
using PubsCRUD.Models;

namespace PubsCRUD.Controllers
{
    public class Login_Controller
    {
        private int intentos = 0;
        private const int MaxIntentos = 3;

        public bool ValidarLogin(User_Model user)
        {
            try
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();
                    string query = "SELECT COUNT(*) FROM employee WHERE fname = @user AND lname = @pass";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@user", user.Username);
                    cmd.Parameters.AddWithValue("@pass", user.Password);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión o consulta: " + ex.Message);
            }
        }

        public bool IntentarLogin(User_Model user, out string mensaje)
        {
            intentos++;

            if (ValidarLogin(user))
            {
                mensaje = "Inicio de sesión exitoso.";
                intentos = 0; // Reiniciar intentos
                return true;
            }
            else
            {
                if (intentos >= MaxIntentos)
                {
                    mensaje = "Ha superado el número máximo de intentos. El programa se cerrará.";
                    Environment.Exit(0);
                }

                mensaje = $"Credenciales incorrectas. Intento {intentos} de {MaxIntentos}.";
                return false;
            }
        }
    }
}
