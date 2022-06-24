using System;
using System.Globalization;
using System.Threading;

class Program{
  public static void Main(){
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;
    Paciente p = new Paciente{Nome = "matheus", CPF = "70541519417", Telefone = "40028922", Nascimento = DateTime.Parse("27/7/2025")};
    
    Console.WriteLine(p);
    Console.WriteLine(p.Idade);
  }
}

class Paciente{
  private string nome, cpf, telefone;
  private DateTime nascimento;
  public string Nome{
    get => nome; set => nome = value;
  }
  public string CPF{
    get => cpf; set => cpf = value;
  }
  public string Telefone{
    get => telefone; set => telefone = value;
  }
  public DateTime Nascimento{
    get {return nascimento;}
    set {nascimento = value;}
  }
  public string Idade{
    get => $"{DateTime.Today.Year - nascimento.Year} anos e {Math.Abs(DateTime.Today.Month - nascimento.Month)} meses";
  }
  public override string ToString(){
    return $"{nome} - {cpf} - {telefone} - {nascimento: dd/MM/yyyy}";
  }
}