using System;

class MainClass {
  public static void Main (string[] args) {
    int numero = Int32.Parse(Console.ReadLine());
    int fatorial = 1;

    for(int c = numero; c >= 1; c--){
       fatorial *= c;
    }

    Console.WriteLine(fatorial);
  }
}