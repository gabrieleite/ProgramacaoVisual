using System;

class MainClass {
  public static void Main (string[] args) {

    double soma = 0;
    for (double c = 1; c <= 10; c++){
      soma += Math.Pow(c,2);
      //Console.WriteLine(Math.Pow(c,2));
    }
    Console.WriteLine(soma);
  }
}