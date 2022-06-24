using System;

class Program{
  public static void Main(){
    Compromisso a = new Compromisso{Assunto = "Nada", Local = "IFRN", Data = DateTime.Parse("04/04/2000")};
    Agenda x = new Agenda();
    x.Inserir(a);
    foreach(Compromisso i in x.Listar())
      Console.WriteLine(i);
    
  }
}

class Agenda{
  private Compromisso[] comps; 
  private int k=0;
  public int Qdt{
    get => k;
  }
  public void Inserir(Compromisso c){
    if(k == comps.Length)
      Array.Resize(ref comps, 1 + comps.Length);
    comps[k] = c;
  }
  public Compromisso[] Listar() {
    Compromisso[] r = new Compromisso[k];
    Array.Copy(comps, r, k);
    return r;
  }
  public Compromisso[] Excluir(Compromisso c){
    // recebo o vetor, no canto do elemento que quero excluir coloco null e listo todos elementos diferentes de null
    int j = 0;
    foreach(Compromisso i in Listar()){
      if(i==c){
        j++;
      }
    }
    return comps;
  }
  
}

class Compromisso{
  public string Assunto {get; set;}
  public string Local {get; set;}
  public DateTime Data {get; set;}
}



/*
 public void Inserir(Musica m) {
    if (k == musicas.Length)
      Array.Resize(ref musicas, 2 * musicas.Length); 
    musicas[k++] = m;
  }*/