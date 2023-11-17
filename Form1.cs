using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Menagelec1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text ;
            if(username == "" || password == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs nécessaire. ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(username == "fournier" && password == "1234" || username == "hurier" && password == "5678" )
                {
                    Form2 menu = new Form2();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
