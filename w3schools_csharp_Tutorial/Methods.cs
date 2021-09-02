using System;
class Methods
{
    static void MeuMetodo()
    {
        Console.WriteLine("Olá mundo");
    }
    // parametros
    static void meumetodopar(string nome)
    {
        Console.WriteLine("olá mundo" + nome);
    }
    // multiplos parametros
    static void meumetodomultpara(string nome, int idade)
    {
        Console.WriteLine("olá mundo " + nome + " tem " + idade + " anos");
    }

    // valores retornados
    static string MetodoRetorno(string nome)
    {
        return "Seu nome é:" + nome;
    }

    // Argumentos Nomeados
    static void MetodoNomeado(string nome1, string nome2, string nome3)
    {
        Console.WriteLine("Exibir nome" + nome1);
    }
    // Argumentos Nomeados e Padrão
    static void MetodoNomeadoPadrao(string nome1 = "", string nome2 = "", string nome3 = "")
    {
        Console.WriteLine("Exibir nome" + nome1);
    }

}