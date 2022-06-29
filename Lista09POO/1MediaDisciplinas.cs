using System;
using System.Collections;

class MainClass{
  public static void Main(){
    
  }
}


interface IDisciplina{
  string GetNome();
  int CalcMediaParcial();
  int CalcMediaFinal();
}

class DisciplinasAnual : IDisciplina{
  private string nome;
  private int nota1, nota2, nota3, nota4, notaFinal;
  public DisciplinaAnual(int n1, int n2, int n3, int n4, int nf){
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
    return (nota1+nota2+nota3+nota4)/4;
  }
  public int CalcMediaFinal(){
    return (CalcMediaParcial()+notaFinal)/2;
  }
}