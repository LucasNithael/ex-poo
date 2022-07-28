using System;


class Cliente{
  public int Id{get; set;}
  public string Nome{get; set;}
  public int IdUsuario{get; set;}
  public override string ToString(){
    return $"{Id} - {Nome}";
  }
}