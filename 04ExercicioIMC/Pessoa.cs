using System;

class Pessoa
{
    public double peso, altura;

    public double IMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    public string situacao(double IMC)
    {
        if (IMC < 18.5)
        {
            return "A baixo do peso";
        }
        else if (IMC <= 25)
        {
            return "Peso normal";
        }
        else if (IMC <= 30)
        {
            return "Acima do peso";
        }
        else if (IMC <= 35)
        {
            return "Obesidade I";
        }
        else if (IMC <= 40)
        {
            return "Obesidade II";
        }
        else
        {
            return "Obesidade III";
        }
    }

    public void mensagem()
    {
        double imc = IMC(peso, altura);
        string Situacao = situacao(imc);
        Console.WriteLine("Voce esta com " + imc + " e esta " + Situacao);
    }
}