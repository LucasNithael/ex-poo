using System;

class Program{
  
}

class Loja{
  private Aplicativo[] apps = new Aplicativo[1];
  private int k = 0;
  public string Nome{get; set;}
  public int Qtd{get{return k;}}
  public void Inserir(Aplicativo app){
    if(k==apps.Length)
      Arrays.Resize(ref apps, 1 + apps.Length);
    apps[k] = apps;
    k++;
  }
  public void Excluir(Aplicativo app){
    foreach(Aplicativo i in Lista())
      if(i==app)
        i == null;
  }
  public Aplicativo[] Listar(){
    return app;
  }
}

class Aplicativo{
  private int curtidas;
  public string Nome{get; set;}
  public string Categoria{get; set;}
  public double Preco{get; set}
  public int Curtidas{get;}
}