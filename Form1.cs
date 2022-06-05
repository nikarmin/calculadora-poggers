using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCalculadora
{
  public partial class FrmCalculadora : Form
  {
    public FrmCalculadora()
    {
      InitializeComponent();
    }

    Calculadora umaCalc;
    private void btnSomar_Click(object sender, EventArgs e)
    {
      double valor1 = double.Parse(txtValor1.Text);
      double valor2 = double.Parse(txtValor2.Text);
      var umaCalc = new Calculadora(valor1, valor2);
      umaCalc.Somar();
      lbResultado.Text = $"Soma = {umaCalc.Resultado}";
    }

    private void txtValor1_TextChanged(object sender, EventArgs e)
    {
      double numero;
      bool sucesso = double.TryParse(txtValor1.Text, out numero);
      if (!sucesso) // if sucesso == false; nao conseguiu converter, para real, o dado digitado
      {
        MessageBox.Show("Valor inválido. Digite corretamente!");
        txtValor1.Focus();
      }
    }

    private void txtValor2_TextChanged(object sender, EventArgs e)
    {
      double numero;
      bool sucesso = double.TryParse(txtValor2.Text, out numero);
      if (!sucesso) // if sucesso == false; nao conseguiu converter, para real, o dado digitado
      {
        MessageBox.Show("Valor inválido. Digite corretamente!");
        txtValor2.Focus();
      }
    }

    private void FrmCalculadora_Load(object sender, EventArgs e)
    {

    }

    private void btnSubtrair_Click(object sender, EventArgs e)
    {
      double valor1 = double.Parse(txtValor1.Text);
      double valor2 = double.Parse(txtValor2.Text);
      var umaCalc = new Calculadora(valor1, valor2);
      umaCalc.Subtrair();
      lbResultado.Text = $"Subtração = {umaCalc.Resultado}";
    }

    private void btnMultiplicar_Click(object sender, EventArgs e)
    {
      double valor1 = double.Parse(txtValor1.Text);
      double valor2 = double.Parse(txtValor2.Text);
      var umaCalc = new Calculadora(valor1, valor2);
      umaCalc.Multiplicar();
      lbResultado.Text = $"Multiplicação = {umaCalc.Resultado}";
    }

    private void btnDividir_Click(object sender, EventArgs e)
    {
      double valor1 = double.Parse(txtValor1.Text);
      double valor2 = double.Parse(txtValor2.Text);
      var umaCalc = new Calculadora(valor1, valor2);
      umaCalc.Dividir();
      lbResultado.Text = $"Divisão = {umaCalc.Resultado}";
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
      txtValor1.Clear();
      txtValor2.Clear();
    }

        private void simToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmARespeito = new frmSobre();
            frmARespeito.Show();
        }
    }
}
