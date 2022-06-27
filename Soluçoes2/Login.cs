using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Soluçoes2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)// cadastrar
        {
            Cadastro Cadastro1 = new Cadastro();
            Cadastro1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)// acessar
        {
            try
            {
                string conexao = "server=localhost;DataBase=BDlogin;Uid=root;password=";
                var connection = new MySqlConnection(conexao);
                var comand = connection.CreateCommand();


                MySqlCommand query = new MySqlCommand("select* from Cadastro where nome ='" + textBox1.Text + "' and senha ='" + textBox2.Text + "'", connection);

                connection.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query);
                da.Fill(dataTable);

                foreach (DataRow list in dataTable.Rows)
                {
                    if (Convert.ToInt32(list.ItemArray[0]) > 0)
                    {
                        Form1 Cadastro1 = new Form1();
                        Cadastro1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("errado");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro" + erro);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
