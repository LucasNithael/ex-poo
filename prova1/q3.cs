using System;

class Program{
  public static void Main(){
    Console.WriteLine("Primeira Aposta: ");
    string[] a = Console.ReadLine().Split();  
    Console.WriteLine("Segunda Aposta: ");
    string[] b = Console.ReadLine().Split();
    Console.WriteLine("Valores Sorteados: ");
    string[] c = Console.ReadLine().Split();
    ApostaLoteria x = new ApostaLoteria(a, b, c);
    Console.WriteLine(x);
  }
}

class ApostaLoteria{
  private string[] a;
  private string[] b;
  private string[] c;
  public ApostaLoteria(string[] a, string[] b, string[] c){
    this.a=a;
    this.b=b;
    this.c=c;
  }
  public int Acertos(){
    int qtd1 = 0;
    int qtd2 = 0;
    for(int i=0; i<6; i++){
      for(int j=0; j<6; j++){
        if(a[i]==c[j]) qtd1++;
      }
    }
    for(int i=0; i<6; i++){
      for(int j=0; j<6; j++){
        if(b[i]==c[j]) qtd1++;
      }
    }
    return qtd1+qtd2;
  }
  public override string ToString(){
    return "Acertos: " + Acertos();
  } 
}
