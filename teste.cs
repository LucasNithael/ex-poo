using System;

class Program{
  public static void Main(){
    Ex1 x = new Ex1(10, 5);
    Console.WriteLine(x.ToString());
    
    Ex1 y = new Ex1();
    
    Console.WriteLine(y.ToString());
    
    
  }
}

class Ex1{
  private int a=0;
  private int b=0;
 public Ex1() { }
  public Ex1(int a, int b){
    this.a = a; 
    this.b = b;
  }
  public void SetA(int va){
    a=va;
  }
  public void SetB(int vb){
    b=vb;
  }
  public int GetA(){
    return a;
  }
  public int GetB(){
    return b;
  }
  public override string ToString(){
    return $"{a} | {b}";
  }
}