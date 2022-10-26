using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercíco_43__While_
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double valor;
            string descricao, algo_mais = "SIM";
            char tipo;


            while (algo_mais == "SIM")
            {

                Console.WriteLine("Digite um código:");
                codigo = int.Parse(Console.ReadLine());
                while (codigo < 0 || codigo > 500)
                {
                    Console.WriteLine("Codigo inválido. Tente entre 0 e 500");
                    codigo = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite umna descrição:");
                descricao = Console.ReadLine();
                while (descricao.Length < 3)
                {
                    Console.WriteLine("Descrição inválida. Tente mais de 3 carácteres");
                    descricao = (Console.ReadLine());
                }
                Console.WriteLine("Digite uma tipo:");
                tipo = Console.ReadLine().ToUpper()[0];
                while (tipo != 'H' && tipo != 'S')
                {
                    Console.WriteLine("Tipo inválido. Tente 'H' para Hardware e 'S' para Software");
                    tipo = Console.ReadLine().ToUpper()[0];
                }
                Console.WriteLine("Digite um valor:");
                valor = double.Parse(Console.ReadLine());
                while (valor < 0)
                {
                    Console.WriteLine("Valor inválido. Tente maior que 0");
                    valor = double.Parse(Console.ReadLine());
                }

                string tipo_2;
                if (tipo == 'S')
                    tipo_2 = "Software";
                else if (tipo == 'H')
                    tipo_2 = "Hardware";


                Console.WriteLine($"Código: {codigo}; Descrição: {descricao}; Tipo: {tipo_2}; Valor: {valor}");

                Console.WriteLine("\nDeseja algo mais?(Sim ou Não)\n");
                algo_mais = Console.ReadLine().ToUpper();

                if(algo_mais=="SIM")
                Console.Clear();
            }

            if (algo_mais == "NÃO")
                Console.WriteLine("Obrigado, otário!");


            Console.ReadKey();
        }
    }
}
