using System;

class MainClass {
  public static void Main (string[] args) {

    int numero = Int32.Parse(Console.ReadLine());
    int soma = 0;

    for (int c = 1; c <= numero; c++){

     soma += c;
    
    }
    Console.WriteLine(soma);
    
  }
}