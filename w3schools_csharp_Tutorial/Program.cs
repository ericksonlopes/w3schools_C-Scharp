using System;

namespace w3schools_csharp_Tutorial
{
    class Program
    {
        static void variables()
        {
            // string
            string name = "John";
            Console.WriteLine(name);

            // int / Outra forma de declarar variaveis
            int meuNum;

            meuNum = 15;
            Console.WriteLine(meuNum);

            // Constantes - Para que o valor da variavel não seja alterado
            // A const palavra-chave é útil quando você deseja que uma variável armazene sempre o mesmo

            const int numConst = 35;
            Console.WriteLine(numConst);

            // Outros tipos
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Escrever na tela."); 

            // Este é um comentario

            /*
                Comentario de multiplas linhas
            */

            // Executando função
            variables();
        }
    }
}
