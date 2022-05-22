using System;

class Program{
  public static void Main(){
  Disciplina x = new Disciplina();
  x.nome = "ingles";
  x.n1 = 20;
  x.n2 = 50;
  x.n3 = 60;
  x.n4 = 70;
  Console.WriteLine(x.MediaParcial());
  x.provaf = 60;
  Console.WriteLine(x.MediaFinal()); 
  }
}

class Disciplina{
  public string nome;
  public double n1, n2, n3, n4, provaf;
  public double MediaParcial(){
    double media = (2*n1+2*n2+3*n3+3*n4)/10;
    return media;
  }
  public double MediaFinal(){
    double mediaf = (provaf+media)/2;
    return mediaf;
  }
}