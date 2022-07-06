using System;

class MainClass{
  public static void Main(){
    object x;
    dynamic x;
    x = 10;
    Console.WriteLine(x);

    Pessoa p = new Pessoa("Lucas");
    x = p;
    Console.WriteLine(x.nome);
  }
}

class Pessoa{
  public string nome;
  public Pessoa(string n){
    nome = n;
  }
  public string GetNome(){
    return nome;
  }
}