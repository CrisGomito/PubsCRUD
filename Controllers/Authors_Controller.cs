
using System.Data.SqlClient;
using PubsCRUD.Config;
using PubsCRUD.Models;

namespace PubsCRUD.Controllers
{
    public class Authors_Controller
    {
        public List<Author_Model> GetAll()
        {
            List<Author_Model> lista = new List<Author_Model>();
            string query = "SELECT * FROM authors";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Author_Model
                    {
                        Au_Id = reader["au_id"].ToString(),
                        Au_Lname = reader["au_lname"].ToString(),
                        Au_Fname = reader["au_fname"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Address = reader["address"].ToString(),
                        City = reader["city"].ToString(),
                        State = reader["state"].ToString(),
                        Zip = reader["zip"].ToString(),
                        Contract = Convert.ToBoolean(reader["contract"])
                    });
                }
            }
            return lista;
        }

        public bool Add(Author_Model author)
        {
            string query = @"INSERT INTO authors 
                             (au_id, au_lname, au_fname, phone, address, city, state, zip, contract) 
                             VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)";
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@au_id", author.Au_Id);
                cmd.Parameters.AddWithValue("@au_lname", author.Au_Lname);
                cmd.Parameters.AddWithValue("@au_fname", author.Au_Fname);
                cmd.Parameters.AddWithValue("@phone", author.Phone);
                cmd.Parameters.AddWithValue("@address", (object?)author.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@city", (object?)author.City ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@state", (object?)author.State ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@zip", (object?)author.Zip ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@contract", author.Contract);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(Author_Model author)
        {
            string query = @"UPDATE authors 
                             SET au_lname=@au_lname, au_fname=@au_fname, phone=@phone, address=@address, 
                                 city=@city, state=@state, zip=@zip, contract=@contract 
                             WHERE au_id=@au_id";
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@au_id", author.Au_Id);
                cmd.Parameters.AddWithValue("@au_lname", author.Au_Lname);
                cmd.Parameters.AddWithValue("@au_fname", author.Au_Fname);
                cmd.Parameters.AddWithValue("@phone", author.Phone);
                cmd.Parameters.AddWithValue("@address", (object?)author.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@city", (object?)author.City ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@state", (object?)author.State ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@zip", (object?)author.Zip ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@contract", author.Contract);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string au_id)
        {
            string query = "DELETE FROM authors WHERE au_id=@au_id";
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@au_id", au_id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
