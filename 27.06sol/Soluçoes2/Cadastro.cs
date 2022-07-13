using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Soluçoes2
{


    public partial class Cadastro : Form
    {
        DAOCadastro cad;
        public Cadastro()
        {
            {
                InitializeComponent();
                cad = new DAOCadastro();//Abrindo a conexão com o Banco de Dados
            }//Fim do método construtor
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// cadastrar
        {
            {
                try
                {
                    //int codigo = Convert.ToInt32(textBox1.Text);//Coletando o dado do campo código

                    string nome = textBox1.Text;
                    string telefone = textBox3.Text;//Coletando o dado do campo nome
                    string email = textBox2.Text;//Coletando o dado do campo telefone
                    string senha = textBox4.Text;//Coletando o dado do campo Endereço
                                                 //Chamar o método inserir que foi criado na classe DAOPessoa
                   cad.Inserir(nome, telefone, email, senha);//Inserir no banco os dados do formulário
                }
                catch (Exception erro)
                {
                    MessageBox.Show("" + erro);
                }
            }//fim do botão cadastrar
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)// e-mail
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
