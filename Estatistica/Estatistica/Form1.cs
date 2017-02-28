using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estatistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaração de um ArrayList para armazenar os números informados
        ArrayList rol = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Posiciona o cursor na caixa de texto para incluir um número
            txtValores.Focus();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            // Inclui o número digitado no ArrayList
            rol.Add(Convert.ToDouble(txtValores.Text));

            // Inclui o número na caixa de texto para visualização
            txtValoresDesordenados.Text = txtValoresDesordenados.Text + Convert.ToDouble(txtValores.Text) + Environment.NewLine;
            txtValores.Text = "";

            // Envia o cursos novamente para a caixa de texto
            txtValores.Focus();
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            rol.Sort();
            txtValoresOrdenados.Text = "";
            foreach (double numero in rol)
            {
                txtValoresOrdenados.Text = txtValoresOrdenados.Text + numero + Environment.NewLine;
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            // Apresenta a quantidade de elementos contidos no rol
            lblContagemElementos.Text = rol.Count.ToString();

            // Realiza o cálculo da média e apresenta o resultado
            double tmp = 0;
            double resultado = 0;
            int total = rol.Count;

            foreach (double numero in rol)
            {
                tmp = (tmp + numero);

            }
            resultado = (tmp / total);
            lblCalculoMedia.Text = resultado.ToString();

            // Calculando a mediana (Cálculo correto apenas para número de elementos ímpares)
            int esq = 0;
            int dir = rol.Count - 1;
            int meio;
            meio = (esq + dir) / 2;
            lblCalculoMediana.Text = rol[meio].ToString();

        }
    }
}
