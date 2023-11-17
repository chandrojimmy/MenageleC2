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




namespace Menagelec1
{
    public partial class Form3 : Form
    {

        public MySqlConnection connection = new MySqlConnection("Database=menagelecsharp;Server=localhost;User=root;Password=");


        public Form3()
        {
           
           
            
            InitializeComponent();
            Chargedonnes();
          
        }
        
        public bool ConnexionMysql()
        {

            try

            {
                connection.Open();
                MessageBox.Show("Connecté");
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
                connection.Close();
                MessageBox.Show("Connecté");
                return true;
            }
            catch
            {
                MessageBox.Show("Non Connecté");
                return false;
            }

        }


        public void Chargedonnes()
        {
            connection.Open();
            DataTable table = new DataTable();
            // rajoute les colonnes
            table.Columns.Add("idCommande", typeof(int));
            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("client", typeof(int));
            // les commandes sql
            MySqlCommand command = new MySqlCommand("SELECT id , date , client FROM commande", connection);
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
            connection.Close();
        }
        
       

      

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            
           
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

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
