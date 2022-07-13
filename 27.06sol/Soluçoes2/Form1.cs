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
    public partial class Form1 : Form
    {
        DAOCadastro cadastro;

        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }
        private void label2_Click(object sender, EventArgs e)//
        {

        }

        private void button1_Click(object sender, EventArgs e)//1
        {
            textBox1.Text = "1. A CPU superaqueceu.\r\n" +
                            "     - Reinstale a CPU.\r\n" +
                            "     * Subistitua o ventilador da CPU.\r\n" +
                            "     * Adicione ventiladores ao gabinete.\r\n\r\n" +
                "2. O ventilador da CPU está falhando\r\n" +
                "   - Substitua o ventilador sa CPU\r\n\r\n"+
                "3. A CPU falhou!\r\n" +
                "    - Substitua a CPU." ;
                 
        }

        private void button3_Click(object sender, EventArgs e)//3
        {
            textBox1.Text = "1. O FSB (Barramento frontal) está configurado com frequência Alta demais.\r\n" +
                "   - Redefina a placa-mãe para as configurações de fábrica.\r\n" +
                "   *Baixe as configurações do barramento dianteiro.\r\n\r\n" +
                "2. O muntiplicador da CPU está alto demais\r\n" +
                "   Reduza a configuração do multiplicador\r\n\r\n" +
                "3. a Tensão da CPU está alta demais\r\n" +
                "   Reduza a configuração de temção da CPU." ;
        }

        private void button5_Click(object sender, EventArgs e)//5
        {
            textBox1.Text = "1. O Tipo da CPU é incorreto\r\n" +
                             "    - Substitua a CPU por uma CPU que corresponda ao tipo de suporte da placa-mãe ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)//2
        {
            textBox1.Text = "1. O ventilador da CPU  está falhando.\r\n" +
                "    - Substitua o ventilador da CPU.";
        }

        private void button4_Click(object sender, EventArgs e)// 4
        {
            textBox1.Text = "1. O BIOS não reconhece a CPU duol core\r\n" +
                            "   - Atualize o firmware da BIOSpara comportar a CPU dual core.";
        }

        private void button6_Click(object sender, EventArgs e)//6
        {
            textBox1.Text = "1. A nova RAM está com defeito\r\n" +
                             "  - Substitua a RAM.\r\n\r\n" +
                            "3. A RAM que foi adicionada não e do mesmo tipo da RAM ja Instalada\r\n" +
                            "   - Instale o tipo correto de RAM.\r\n\r\n" +
                            "4. A nova RAM está solta no slot de memória\r\n" +
                            "   - Prenda a RAM no slot de memória";
        }

        private void button7_Click(object sender, EventArgs e)//7
        {
            textBox1.Text = "1. O computador não tem RAM o Suficiente\r\n " + 
                             "  - Intale RAM adicional.\r\n\r\n" +
                            "2. A placa de video não tem memoria o suficiente" +
                            "   - Instale uma placa de video com mais memória."; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
