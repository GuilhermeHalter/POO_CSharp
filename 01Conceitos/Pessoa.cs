using System;

class Pessoa
{
    // Atributos
    public string nome;
    public int idade;

    // Métodos

    public void mensagem()
    {
        Console.WriteLine("Salve " + nome + " voce tem "+ idade + " anos.");
    }

}