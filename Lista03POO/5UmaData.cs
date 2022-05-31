 
class Program{
  public static void Main(){
    
  }
}

class Data{
  private int dia, mes, ano;
  public Data(string a){
    string[] data = data.Split("/");
    this.dia = int.Parse(data[0]);
    this.mes = int.Parse(data[1]);
    this.ano = int.Parse(data[2]);
  }
}