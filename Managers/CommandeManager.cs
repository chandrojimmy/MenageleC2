using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;



namespace Menagelec.Manager
{

   
    

    class CommandeManager
    {


        public MySqlCommand ClickAndSelect(connexion conn,int idCommande)
        {
            MySqlCommand mySql = new MySqlCommand("SELECT * FROM  lignecommande  WHERE `commande` = @idCommande", conn.Connection) ;
            mySql.Parameters.AddWithValue("@idCommande", idCommande);

            return mySql;
        }

        public MySqlCommand ViewData(connexion conn)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM commande", conn.Connection);
            return command ;
        }

        public MySqlCommand ViewDataNoPay(connexion conn)
        {
            MySqlCommand command = new MySqlCommand("SELECT id , date , client FROM commande", conn.Connection);
            return command;
        }
    }
}
