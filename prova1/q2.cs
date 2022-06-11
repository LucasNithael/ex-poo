  using System;

class Program{
  public static void Main(){
    Console.WriteLine("Informe mês, ano e valor 1ª conta");
    int mes = int.Parse(Console.writeLine());
    int ano = int.Parse(Console.WriteLine());
    double valor = double.Parse(Console.WriteLine());
    Energia maior = new Energia(mes, ano, valor);

    for(int i=2; i<=3; i++){
      Console.WriteLine($"Informe mês, ano e valor {i}ª conta");
      mes = int.Parse(Console.writeLine());
      ano = int.Parse(Console.WriteLine());
      valor = double.Parse(Console.WriteLine());
       Energia x = new Energia(mes, ano, valor);
      if(x.GetValor() > maior.GetValor)
        maior = x;
    }
    Console.WriteLine(maior.ToString());
}




class Energia{
  private int mes, ano;
  private double valor;
  public Energia(int mes, int ano, double valor){
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
    return $"mes {mes} ano {ano} valor {valor}";
  }
}