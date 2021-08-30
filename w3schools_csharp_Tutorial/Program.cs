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
            // int myNum = 5;
            // double myDoubleNum = 5.99D;
            // char myLetter = 'D';
            // bool myBool = true;
            // string myText = "Hello";

            // Variaveis de exibição
            Console.WriteLine("Bem-vindo " + name);

            int x = 5;
            int y = 10;

            Console.WriteLine(x + y);

            // Declare Muitas Variáveis
            int x1 = 5, y2 = 6, z3 = 50;
            Console.WriteLine(x1 + y2 + z3);
        }
        
        /*
        static void dataTypes()
        {
            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String
        }
        */

        static void typeCasting()
        {
            // Implicit Casting
            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            // Explicit Casting
            double myDoubleEx = 9.78;
            int myIntEx = (int) myDoubleEx;

            Console.WriteLine(myDoubleEx);
            Console.WriteLine(myIntEx);

            // Type Conversion Methods
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Escrever na tela."); 

            // Este é um comentario

            /*
                Comentario de multiplas linhas
            */

            // Executando função
            typeCasting();
        }
    }
}
