using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data
{
    public class DatabaseConnection
    {
        public string Server { get; }
        public string Port { get; }
        public string Database { get; }
        public string User { get; }
        public string Password { get; }
        public string SSL { get; }

        public DatabaseConnection(string server,string port,string database,string user,string password,string ssl)
        {
            this.Server = this.Decrypte(server);
            this.Port = this.Decrypte(port);
            this.Database = this.Decrypte(database);
            this.User = this.Decrypte(user);
            this.Password = this.Decrypte(password);
            this.SSL = this.Decrypte(ssl);
        }

        private string Decrypte(string encodeString)
        {
            string decodeString = "";
            if (encodeString != "")
            {
                foreach (int letter in encodeString)
                {
                    decodeString += Convert.ToChar(letter - 1);
                }
            }
            return decodeString;
        }
    }

}
