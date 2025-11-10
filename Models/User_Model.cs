
namespace PubsCRUD.Models
{
    public class User_Model
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User_Model() { }

        public User_Model(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
