using System;

class Produto{
  public int Id{get;set;}
  public string Descricao{get;set;}
  public double Preco{get;set;}
  public int Estoque{get;set;}
  public override string ToString(){
    return $"{Id} {Descricao} {Preco} {Estoque}";
  }
}