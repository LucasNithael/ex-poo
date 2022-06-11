using System;

class Program{
  public static void Main(){
    Energia a = new Energia(9, 2020, 30);
    
  }
}


class Energia{
  private int mes, ano;
  private double valor=0;
  public Energia(int mes, int ano, double valor){
    //SetMes(mes);
    if(mes>=1 && mes<=12) this.mes = mes;
    if(valor>=0) this.valor = valor;
    if(ano>=0) this.ano = ano;
  }
  public void SetMes(int mes){
    if(mes>=1 && mes<=12) this.mes = mes;
  }
  public void SetAno(int ano){
    if(ano>=0) this.ano = ano;
  }
  public void SetValor(double valor){
    if(valor>=0) this.valor = valor;
  }
  public int GetMes(){
    return mes;
  }
  public int GetAno(){
    return ano;
  }
  public double GetValor(){
    return valor;
  }
  public override string ToString(){
    return $"mes{mes} ano{ano} valor{valor:0.00}";
  } 
}