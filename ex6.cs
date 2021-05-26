using System;

class MainClass {
  public static void Main (string[] args) {

    int soma = 0;
    for (int c = 12; c <= 102; c++){
      soma += c;
      //Console.WriteLine(c);
      c += 9;
    }
    Console.WriteLine(soma);
  }
}