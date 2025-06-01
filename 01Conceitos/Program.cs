using System;

namespace _01Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();

            obj.nome = "Guilherme";
            obj.idade = 20;
            obj.mensagem();
        }
    }
}