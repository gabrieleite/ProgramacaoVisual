using System;

class MainClass {
  public static void Main (string[] args) {
    
    
    int pos = 0;
    int neg = 0;

    for (int c = 1; c <= 10; c++){
      int numero = Int32.Parse(Console.ReadLine());

      if(numero < 0){
        neg++;
      }else{
        pos++;
      }
  
    }
    Console.WriteLine("Negativos = " + neg);
    Console.WriteLine("Positivos = " + pos);
  }
}