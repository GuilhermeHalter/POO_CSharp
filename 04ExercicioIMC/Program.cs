using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa ps = new Pessoa();

            ps.peso = 110.0;
            ps.altura = 1.80;

            ps.mensagem();
        }
    }
}