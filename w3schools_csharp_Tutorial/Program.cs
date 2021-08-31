using System;
using System.Linq;

namespace w3schools_csharp_Tutorial
{
    class Program
    {
        static void comentarios()
        {
            // Este é um comentario

            /*
                Comentario de multiplas linhas
            */

            // Executando função
        }

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
            int myIntCon = 10;
            double myDoubleCon = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myIntCon));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myIntCon));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleCon));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }

        static void userInput()
        {
            // Get User Input
            Console.WriteLine("Digite seu nome:");
            string userName = Console.ReadLine();

            Console.WriteLine("Seu nome é: " + userName);

            // Input and Numbers
            Console.WriteLine("Digite sua idade: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sua idade é: " + age);
        }
        
        static void Operators()
        {
            int x = 100 + 50;
            x += 5;
            Console.WriteLine(x);
        }

        static void MethodMath()
        {
            // Calcula o valor maximo
            int numMax = Math.Max(5, 10);

            Console.WriteLine(numMax);

            // Valor minimo
            int numMin = Math.Min(5, 10);
            Console.WriteLine(numMin);

            // Raiz quadrada
            double numRaiz = Math.Sqrt(64);
            Console.WriteLine(numRaiz);

            // Valor absoluto
            double numAbs = Math.Abs(-4.7);
            Console.WriteLine(numAbs);

            // Arredondado
            double numRound = Math.Round(9.99);
            Console.WriteLine(numRound);
        }

        static void varString()
        {   
            // Contagem de caracteres
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("Total de caracteres: " + txt.Length);

            // Maiusculo minusculo
            string name = "Erickson";
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            // Concatenação
            Console.WriteLine(name.ToLower() + " " + name.ToUpper());

            string conc = string.Concat(name.ToLower(), name.ToUpper());
            Console.WriteLine(conc);
            
            // Interpolação
            string nome = "Erickson";
            string sobrenome = "Lopes";
            
            string completo = $"{nome} {sobrenome}";
            Console.WriteLine(completo);

            // Acessando indices
            string myString = "O livro.";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString[7]);

            // Buscando indice por valor
            Console.WriteLine(myString.IndexOf("."));

            // Extrai os caracteres de uma string até o caractere especificado
            string NomeCompleto = "Erickson Lopes";
            int caracPos = NomeCompleto.IndexOf("L");

            string lastName = NomeCompleto.Substring(caracPos);

            Console.WriteLine(lastName);

            // Caracteres Especiais
            txt = "We are the so-called \"Vikings\" from the north.";
            txt = "It\'s alright.";
            txt = "The character \\ is called backslash.";

            Console.WriteLine("Pula\nLinha"); // pula linha
            Console.WriteLine("Pula\tLinha"); // tab
            Console.WriteLine("Pula\b Linha"); // Backspac
 
        }

        static void varBooleans()
        {
            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine(isTrue);
            Console.WriteLine(isFalse);

            //Boolean Expression
            Console.WriteLine(5 > 1);
            Console.WriteLine(5 == 5);
        }

        static void ifElse()
        {
            if (20 > 18)
            {
                Console.WriteLine("20 é maior que 18.");
            }

            // The else Statement
            /*
            if (10 > 4)
            {
                Console.WriteLine("");
            }
            else if (false)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            */
            //Short Hand If...Else (Ternary Operator)
            int time = 18;
            string result = (time < 18) ? "Bom dia" : "Boa tarde";
            Console.WriteLine(result);
        }
        
        static void switchStatements()
        {   
            int num = 3;

            switch (num)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("Esta opção não existe");
                    break;
            }
        }

        static void whileLoop()
        {
            int num = 0;
            while (num < 5)
            {
                Console.WriteLine($"{num}");
                num++;
            }

            do
            {
                Console.WriteLine($"{num}");
                num++;
            } while (num < 10);
        }

        static void forLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            //The foreach Loop
            string[] carac = {"A", "B", "C"};

            foreach (string item in carac)
            {
                Console.WriteLine(item);
            }
        }

        static void arraysCsharp()
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            Console.WriteLine(cars[0]);

            // Alterar um elemento Array
            cars[0] = "Camaro";

            Console.WriteLine(cars[0]);

            // Comprimento da Matriz
            Console.WriteLine(cars.Length);

            // Loop
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string item in cars)
            {
                Console.WriteLine(item);
            }

            // Sort Arrays
            int[] nums = {11, 5, 77, 2};

            Array.Sort(nums);

            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }

            // Namespace System.Linq
            Console.WriteLine(nums.Max());  // returns the largest value
            Console.WriteLine(nums.Min());  // returns the smallest value
            Console.WriteLine(nums.Sum());  // returns the sum of elements
            
            /* Outras maneiras de criar uma matriz
            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

            // Create an array of four elements without specifying the size 
            string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            */

        }

        static void Main(string[] args)
        {           
           arraysCsharp();
        }
    }
}
