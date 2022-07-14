using System;
using static System.Console;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Digite sua idade: ");
            string age = ReadLine();
            WriteLine("Insira seu  peso atual: ");
            float wheight = (float)Convert.ToDouble(ReadLine());
            WriteLine("Insira sua altura: ");
            float higth = (float)Convert.ToDouble(ReadLine());

            float imc = wheight / (higth * higth);
            string text;

            if (imc < 18.5)
                text = "seu IMC é: " + Math.Round(imc, 2) + " e você está abaixo do peso.";
            else if (imc < 25)
                text = "seu IMC é: " + Math.Round(imc, 2) + " e você está com peso normal.";
            else if (imc < 30)
                text = "seu IMC é: " + Math.Round(imc, 2) + " e você está com sobrepeso.";
            else if (imc < 40)
                text = "seu IMC é: " + Math.Round(imc, 2) + " e você está com obesidade.";
            else
                text = "seu IMC é: " + Math.Round(imc, 2) + " e você está com obesidade grave.";

            WriteLine($"Você tem: {age} anos de idade e {text}");


        }
    }
}
