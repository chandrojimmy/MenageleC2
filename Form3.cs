using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using System.Data.Common;
using Menagelec.Manager;
using Menagelec.Entity;



namespace Menagelec1
{
    public partial class Form3 : Form
    {
        connexion conn = new connexion();
        CommandeManager commandeManager = new CommandeManager();
        Commande commande = new Commande(null,null,null,null,null);
        List<Commande> lstcom = new List<Commande>();


        public Form3()
        {

            

            InitializeComponent();
            Chargedonnes();
          
            

        }



        public void Chargedonnes()
        {
            // les commandes sql
            conn.ConnexionOpen();
            DataTable table = new DataTable();
            // rajoute les colonnes
            table.Columns.Add("idCommande", typeof(int));
            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("client", typeof(int));
            MySqlCommand cmd = commandeManager.ViewData(conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                // creer une nouvelle lignes
                DataRow dataRow = table.NewRow();
                table.Rows.Add(dataRow);
                // Remplir la nouvelle ligne
                dataRow["idCommande"] = reader.GetInt32("id");
                dataRow["date"] = reader.GetDateTime("date");
                dataRow["client"] = reader.GetInt32("client");
                
                dataGridView1.DataSource = table;
                commande = new Commande(reader.GetInt32("id"), reader.GetDateTime("date"), reader.GetInt32("estPayee"), reader.GetInt32("estExpediee"), reader.GetInt32("client"));
                lstcom.Add(commande);
                


            }
            conn.CloseMysql();
            //lire les donnees 






        }

        public void Selectdata()
        {
            // les commandes sql
            conn.ConnexionOpen();
            DataTable table = new DataTable();
            MessageBox.Show(commande.Id.ToString());
            // rajoute les colonnes
            table.Columns.Add("Produit commandé", typeof(int));
            table.Columns.Add("Quantité", typeof(int));
            int row = dataGridView1.CurrentRow.Index+1;
            MySqlCommand comd = commandeManager.ClickAndSelect(conn, row ) ;
            MySqlDataReader reader = comd.ExecuteReader();


            while (reader.Read())
            {
                // creer une nouvelle lignes
                DataRow dataRow = table.NewRow();
                // Remplir la nouvelle ligne
                dataRow["Produit commandé"] = reader.GetInt32("produit");
                dataRow["Quantité"] = reader.GetInt32("commande");
                MessageBox.Show(row.ToString());
               
                table.Rows.Add(dataRow);
                dataGridView2.DataSource = table;



            }
            conn.CloseMysql();
            //lire les donnees 
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            Selectdata();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }





        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                // les commandes sql
                conn.ConnexionOpen();
                DataTable table = new DataTable();
                // rajoute les colonnes
                table.Columns.Add("idCommande", typeof(int));
                table.Columns.Add("date", typeof(DateTime));
                table.Columns.Add("client", typeof(int));
               
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT id, date, client  FROM commande WHERE estExpediee = 0 and estPayee = 1 ", conn.Connection);
                MySqlDataReader Data = mySqlCommand.ExecuteReader();
                while (Data.Read())
                {
                    // creer une nouvelle lignes
                    DataRow dataRow = table.NewRow();
                    // Remplir la nouvelle ligne
                    dataRow["idCommande"] = Data.GetInt32("id");
                    dataRow["date"] = Data.GetDateTime("date");
                    dataRow["client"] = Data.GetInt32("client");
                    table.Rows.Add(dataRow);
                    dataGridView1.DataSource = table;






                }
                conn.CloseMysql();
            }



        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox3.Checked = false;
                checkBox2.Checked = false;
                // les commandes sql
                conn.ConnexionOpen();
                DataTable table = new DataTable();
                // rajoute les colonnes
                table.Columns.Add("idCommande", typeof(int));
                table.Columns.Add("date", typeof(DateTime));
                table.Columns.Add("client", typeof(int));

                MySqlCommand command = new MySqlCommand("SELECT id , date , client  FROM commande", conn.Connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    // creer une nouvelle lignes
                    DataRow dataRow = table.NewRow();
                    // Remplir la nouvelle ligne
                    dataRow["idCommande"] = dataReader.GetInt32("id");
                    dataRow["date"] = dataReader.GetDateTime("date");
                    dataRow["client"] = dataReader.GetInt32("client");
                    table.Rows.Add(dataRow);
                    dataGridView1.DataSource = table;



                }
                conn.CloseMysql();
                
            }
        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                conn.ConnexionOpen();
                DataTable table = new DataTable();
                // rajoute les colonnes
                table.Columns.Add("idCommande", typeof(int));
                table.Columns.Add("date", typeof(DateTime));
                table.Columns.Add("client", typeof(int));
                // les commandes sql
                MySqlCommand command = new MySqlCommand("SELECT id , date , client  FROM commande WHERE estPayee = 0 ", conn.Connection);
                //lire les donnees 
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    // creer une nouvelle lignes
                    DataRow dataRow = table.NewRow();
                    // Remplir la nouvelle ligne
                    dataRow["idCommande"] = dataReader.GetInt32("id");
                    dataRow["date"] = dataReader.GetDateTime("date");
                    dataRow["client"] = dataReader.GetInt32("client");
                    table.Rows.Add(dataRow);
                    dataGridView1.DataSource = table;



                }
                conn.CloseMysql();
                
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
