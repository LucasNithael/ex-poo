using System;

class Program{
  public static void Main(){
    Paciente p = new Paciente{Nome = "Lucas", CPF = "70541519417", Telefone = "40028922", Nascimento = DateTime.Parse("04/04/2000")};
    
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
    get => $"{DateTime.Today.Year - nascimento.Year} anos e {DateTime.Today.Month - nascimento.Month} meses";
  }
  public override string ToString(){
    return $"{nome} - {cpf} - {telefone} - {nascimento: dd/MM/yyyy}";
  }
}