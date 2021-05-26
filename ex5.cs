using System;

class MainClass {
  public static void Main (string[] args) {
     
    int numero = Int32.Parse(Console.ReadLine());

    while (numero < 1 || numero > 10){
      Console.WriteLine("Número inválido, digite um número inteiro entre 1 e 10");
      numero = Int32.Parse(Console.ReadLine());
    }

    for(int c = 1; c <= 10; c++){
      Console.WriteLine(numero + " x " + c + " = " + (numero*c));
    }
  }
  
}