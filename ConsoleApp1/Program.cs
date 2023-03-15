namespace Verificarnumeroprimo
{
    internal class Program
    {
        static void Main(string[] args)// QUANDO UM NUMERO É PRIMO? QUANDO ELE É DIVISIVEL POR 1 E POR ELE MESMO.
        {
            //Numero PriMo

            //int Numero;// variavel do tipo inteira para armazenar numero de entrada



            //Console.WriteLine("Entre com um numero para verificação se é primo: ");
            //Numero = Convert.ToInt32(Console.ReadLine()); // ESTOU ARMAZENANDO A ENTRADA NESSA VARIAVEL, MAS ESTOU CONVERTENDO PARA INT PORQUE A ENTRADA VEM DA FORMA STR.

            //Console.WriteLine($"É PRIMO: {IsPrimo(Numero)}");

            //iniciando com git

            Console.WriteLine("Entre com 1 numero para fazer a adição: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com 1 numero para fazer a adição: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com 1 numero para fazer a adição: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //int Resultado = Somar(num, num1, num2);
            Console.WriteLine($"Esse é o resultad: {Somar(num, num1, num2)}");
        }




        // METODO
        public static bool IsPrimo(int Numero)
        {
            if (Numero >= 2)
            {
                for (int i = 2; i < Numero; i++)
                {
                    if (Numero % i == 0)
                        return false;


                }

            }
            else
            {
                return false;
            }

            return true;




        }
        //metodo
        public static int Somar(int num1, int num2, int num3)
        {
            //int Adicao = num1 + num2 + num3;
            return num1 + num2 + num3;
        }


    }

}
