using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apCalculadora
{
  class Calculadora
  {
    double primeiroNumero;
    double segundoNumero;
    double resultado;

    public double Resultado { get => resultado; }

    public Calculadora(double primeiro, double segundo)
    {
       primeiroNumero = primeiro;
       segundoNumero = segundo;
    }

    public void Valorar(double v1, double v2)
    {
      primeiroNumero = v1;
      segundoNumero  = v2;
    }
    public void LimparVisor()
    {
      resultado = 0;
    }
    public void Ligar()
    {
      LimparVisor();
      primeiroNumero = segundoNumero = 0;
    }
    public void Desligar()
    {
      LimparVisor();
      //SairDaMemoria();
    }
    public void Somar()
    {
      resultado = primeiroNumero + segundoNumero;
    }

    public void Subtrair() 
    { 
       resultado = primeiroNumero - segundoNumero; 
    }
    public void Multiplicar() 
    { 
       resultado = primeiroNumero * segundoNumero; 
    }
    public void Dividir() 
    { 
       resultado = primeiroNumero / segundoNumero; 
    }
    public void ExibirResultado(string sinal)
    {
      Console.WriteLine($"{primeiroNumero} {sinal} {segundoNumero} vale {resultado}");
    }
    public void ObterNumeros()
    {
      Console.Write("Digite o 1º valor: ");
      primeiroNumero = double.Parse(Console.ReadLine());

      Console.Write("Digite o 2º valor: ");
      segundoNumero = double.Parse(Console.ReadLine());
    }

  }
}
