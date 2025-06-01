using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Lucas";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}