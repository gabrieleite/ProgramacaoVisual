using System;

class MainClass {
  public static void Main (string[] args) {
    
    
    int soma = 0;

    for (int c = 1; c <= 10; c++){
      int numero = Int32.Parse(Console.ReadLine());

      if(numero < 0){
        soma += numero;
      }
  
    }
    Console.WriteLine(soma);

  }
}