using EstacoesDoAno.Enum;
using System;


namespace EstacoesDoAno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mesesano, diasdoano;

            Console.WriteLine("Digite um dia do mês entre 1 e 31 dias \r\n");
            diasdoano = int.Parse(Console.ReadLine());

            if (diasdoano > 31)
            {
                Console.WriteLine("Digite um valor válido, sendo de 1 a 31 para dia e 1 a 12 para ano");
                diasdoano = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\r\nVocê digitou dia: \r\n" + diasdoano);
            Console.WriteLine("\r\nDigite o número do mês desejado sendo: \r\n");
            Console.WriteLine("01 - Janeiro");
            Console.WriteLine("02 - Fevereiro");
            Console.WriteLine("03 - Março");
            Console.WriteLine("04 - Abril");
            Console.WriteLine("05 - Maio");
            Console.WriteLine("06 - Junho");
            Console.WriteLine("07 - Julho");
            Console.WriteLine("08 - Agosto");
            Console.WriteLine("09 - Setembro");
            Console.WriteLine("10 - Outubro");
            Console.WriteLine("11 - Novembro");
            Console.WriteLine("12 - Dezembro\r\n");


            mesesano = int.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine();

            if ((mesesano == 12 & diasdoano >= 21) ||
               (mesesano == 01 & diasdoano >= 1 & diasdoano <= 31) ||
               (mesesano == 02 & diasdoano >= 1 & diasdoano <= 28) ||
               (mesesano == 03 & diasdoano >= 1 & diasdoano <= 21))
            {
                Console.WriteLine("Estamos no verão");
            }

            if ((mesesano == 03 & diasdoano > 21)
              || (mesesano == 04 & diasdoano >= 1 & diasdoano <= 30)
              || (mesesano == 05 & diasdoano >= 1 & diasdoano <= 31)
              || (mesesano == 06 & diasdoano >= 1 & diasdoano <= 21))
            {
                Console.WriteLine("Estamos no outono");
            }

            if ((mesesano == 06 & diasdoano > 21)
                || (mesesano == 07 & diasdoano >= 1 & diasdoano <= 31)
                || (mesesano == 08 & diasdoano >= 1 & diasdoano <= 31)
                || (mesesano == 09 & diasdoano >= 1 & diasdoano <= 23))
            {
                Console.WriteLine("Estamos no Inverno");
            }

            if ((mesesano == 09 & diasdoano > 23)
               || (mesesano == 10 & diasdoano >= 1 & diasdoano <= 31)
               || (mesesano == 11 & diasdoano >= 1 & diasdoano <= 31)
               || (mesesano == 12 & diasdoano >= 1 & diasdoano < 21))
            {
                Console.WriteLine("Estamos na Primavera");
            }

            try
            {
                if (diasdoano > 31 || mesesano > 12)
                Console.WriteLine("Essa informação não é inválida");
            }
            finally
            {
                Console.WriteLine("\r\nObrigado(a) por usar nossa aplicação");
            }

            return;
        }

    }
}
