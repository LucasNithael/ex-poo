using System;
using System.Globalization;


enum SituacaoEstagio{Cadastrado, Iniciado, Cancelado, Finalizado};

class Program{
  public static void Main(){
    CultureInfo ci = new CultureInfo("pt-BR");
    Estagio x = new Estagio("Lucas", "ABC");
    Console.WriteLine(x.Cancelar("27/03/07"));
    Console.WriteLine(x);
  }
}

class Estagio{
  private string estagiario;
  private string empresa;
  private string dataInicio;
  private string dataCancelamento;
  //private DateTime dataFim;
  private SituacaoEstagio situacao;
  public Estagio(string est, string emp){
    this.estagiario = est;
    this.empresa = emp;
    this.situacao = SituacaoEstagio.Cadastrado;
  }
  public bool Iniciar(string data){
    if(situacao==SituacaoEstagio.Cadastrado){
      situacao = SituacaoEstagio.Iniciado;
      dataInicio = data;
      return true;
    }
    else return false;
  }
  
   public bool Cancelar(string data){
    if(situacao==SituacaoEstagio.Iniciado){
      dataCancelamento = data;
      situacao = SituacaoEstagio.Iniciado;
      return true;
    }
    else return false;
  }
 
  public bool Finalizar(string data){
    if(Situacao() ==  SituacaoEstagio.Iniciado){
      dataFim = data;
      situacao = SituacaoEstagio.Finalizado;
      return true;
    }
    else return false;
  }
  public TimeSpan TempoEstagio(){
     if(Situacao() ==  SituacaoEstagio.Iniciado){
        return dataIncio - DateTime.today;
     }
  }
  public SituacaoEstagio Situacao(){
    return situacao;
  }*/
  public override string ToString(){
    return $"{estagiario}, {empresa}";
  }
}
