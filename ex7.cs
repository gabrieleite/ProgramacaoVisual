using System;

class MainClass {
  public static void Main (string[] args) {
    int numero = Int32.Parse(Console.ReadLine());
    int contagem = numero;

    
    for(int c = 1; c <= 11; c++){

      Console.WriteLine(contagem);
      contagem = contagem + numero;
    }
  }
}