using System;
using System.Collections;

class MainClass{
  public static void Main(){
    IDisciplina d1 = new DisciplinasAnual(30, 40, 50, 60, 70);
    IDisciplina d2 = new DisciplinasAnual(20, 10, 80, 65, 60);
    //IDisciplina d = new DisciplinasSemestral(30, 70);
    Historico h = new Historico();
    h.InserirDisciplinasAnual(d1);
    h.InserirDisciplinasAnual(d2);
    h.ListarDisciplinasAnual();
    
    
  }
}


interface IDisciplina{
  string GetNome();
  int CalcMediaParcial();
  int CalcMediaFinal();
}

class Historico{
  private DisciplinasAnual[] disciplinasAnual = new DisciplinasAnual[1];
 private DisciplinasSemestral[] disciplinasSemestral = new DisciplinasSemestral[1];
  private int k1;
  private int k2;
  public void InserirDisciplinasAnual(DisciplinasAnual d1){
    if(k1==disciplinasAnual.Length)
      Array.Resize(ref disciplinasAnual, 1 + disciplinasAnual.Length);
    disciplinasAnual[k1] = d;
    k1++;
  }
  public void InserirDisciplinasSemestral(DisciplinasSemestral d2){
    if(k2==disciplinasSemestral.Length)
      Array.Resize(ref disciplinasSemestral, 1 + disciplinasSemestral.Length);
    disciplinasSemestral[k2] = d;
    k2++;
  }
  public void ListarDisciplinasSemestral(){
    foreach(IDisciplina d in disciplinasSemestral)
      if(d!=null)
        Console.WriteLine($"{d.GetNome()} - {d.CalcMediaFinal()}");
  }
  public void ListarDisciplinasAnual(){
    foreach(IDisciplina d in disciplinasSemestral)
      Console.WriteLine($"{d.GetNome()} - {d.CalcMediaFinal()}");
  }

}

class DisciplinasAnual : IDisciplina{
  private string nome;
  private int nota1, nota2, nota3, nota4, notaFinal;
  public DisciplinasAnual(int n1, int n2, int n3, int n4, int nf){
    nota1 = n1; nota2 = n2; nota3 = n3; nota4 = n4; notaFinal = nf;
  }
  public string GetNome(){ return nome;}
  public int CalcMediaParcial(){
    return (nota1+nota2+nota3+nota4)/4;
  }
  public int CalcMediaFinal(){
    return (CalcMediaParcial()+notaFinal)/2;
  }
}

class DisciplinasSemestral : IDisciplina{
  private string nome;
  private int nota1, nota2, notaFinal;
  public string GetNome(){ return nome;}
  public int CalcMediaParcial(){
    return (nota1+nota2)/2;
  }
  public int CalcMediaFinal(){
    return (CalcMediaParcial()+notaFinal)/2;
  }
}