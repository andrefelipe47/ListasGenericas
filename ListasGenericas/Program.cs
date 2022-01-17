using System;
using System.Collections.Generic;


namespace ListasGenericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomesAnimais = new List<string>();

            int quantidadeMaximaPerguntas = 5;

            for (int i = 0; i < quantidadeMaximaPerguntas; i++)
            {
                Console.WriteLine("Qual o nome do animal?");
                string nomeAnimal = Console.ReadLine();

                nomesAnimais.Add(nomeAnimal);
            }
            nomesAnimais.Add("asdasd");
            foreach (var nomeAnimal in nomesAnimais)
            {
                Console.WriteLine(nomeAnimal);
            }
        }
    }
}
