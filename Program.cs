namespace _03_02_25
{
    class Program
    {
        static void Main(string[] args)

            //exercício 1
           
        { /*
            System.Console.WriteLine("Insira o primeiro número: ");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            var n2 = int.Parse(Console.ReadLine());

            var soma = n1 + n2;
            var subt = n1 - n2;
            var mult = n1 * n2;
            double div = n1 / n2;

            System.Console.WriteLine($"Soma:  {soma}");
            System.Console.WriteLine($"Subtração:  {subt}");
            System.Console.WriteLine($"Multiplicação:  {mult}");
            System.Console.WriteLine($"Divisão:  {div}"); */


            //exercício 2

            /* System.Console.WriteLine("Insira o preço do produto: ");
             float valor = float.Parse(Console.ReadLine());

             double desconto = (valor * 0.2);

             System.Console.WriteLine($"O desconto é de: {desconto}"); */

            //exercício 3

            /* for(int numero3 = 0; numero3 < 20; numero3 ++) { 

                 if(numero3 % 2 == 0)
                 {

                     System.Console.WriteLine($"{numero3}"); 
                 }

             }*/

            //exercício 4

            /*System.Console.WriteLine("Insira um número: ");
            var numero4 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira o segundo número: ");
            var numero5 = int.Parse(Console.ReadLine());

            int soma1 = 0;

            for(int i = numero4; i <= numero5; i++) {
                soma1 += i;
                    
            }
            System.Console.WriteLine($"A soma dos números no intervalo do número {numero4} e o número {numero5} é {soma1}");
             */

            //exercício 5

            int[] vetor= new int[5];
            
            for (int i1 = 0;i1 < 5; i1++)
            {
                System.Console.WriteLine($"Insira o {i1 + 1}°:   ");
                var numero6 = int.Parse(Console.ReadLine());
                vetor[i1] = numero6;

             
            }
            
            for (int i2 = 4; i2 >= 0; i2--)
            {
                System.Console.WriteLine($"{vetor[i2]}");
            }


        }

    }                                             
    }  