using System;

class MainClass {
  public static void Main (string[] args) {

    int maior = 0;
    

    for(int c = 1; c <= 5; c++){
      int numero = Int32.Parse(Console.ReadLine());

      if(numero >= maior){
        maior = numero;
      }
    }
    Console.WriteLine(maior);
  }
}