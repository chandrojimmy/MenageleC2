using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Menagelec.Manager
{
    class connexion
    {
        private MySqlConnection connection;

        public MySqlConnection Connection { get => connection; set => connection = value; }

        public connexion()
        {
            // Initialisez la connexion dans le constructeur
            Connection = new MySqlConnection("Database=menagelecsharp;Server=localhost;User=root;Password=");
        }

        public void Connexion()
        {
            // Vous n'avez pas besoin de redéclarer la connexion ici
            // MySqlConnection connection = new MySqlConnection("Database=menagelecsharp;Server=localhost;User=root;Password=");
        }

        public bool ConnexionOpen()
        {
            try
            {
                Connection.Open();

                return true;
            }
            catch
            {
                MessageBox.Show("Non Connecté");
                return false;
            }
        }

        public bool CloseMysql()
        {
            try
            {
                Connection.Close();
                
                return true;
            }
            catch
            {
                MessageBox.Show("Erreur lors de la déconnexion");
                return false;
            }
        }
    }
}
