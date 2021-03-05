using System;

namespace Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha");
            int leituraSenha = int.Parse(Console.ReadLine());
            LerSenha(leituraSenha);

            string[] coords = Console.ReadLine().Split(' ');
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);

            Cartesiano(x, y);

            int codigo = int.Parse(Console.ReadLine());
            Posto(codigo);
        }

        static void LerSenha(int senha)
        {
            int senhaCorreta = 2002;

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
        }
        static void Cartesiano(int x, int y)
        {
            while (x != 0 && y != 0)
            {


                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                string[] coords = Console.ReadLine().Split(' ');
                x = int.Parse(coords[0]);
                y = int.Parse(coords[1]);
            }
        }
        static void Posto(int codigo)
        {
            int contAl = 0;
            int contGs = 0;
            int contDs = 0;

            while (codigo != 4)
            {
                codigo = int.Parse(Console.ReadLine());
                switch (codigo)
                {
                    case 1:
                        contAl++;
                        break;
                    case 2:
                        contGs++;
                        break;
                    case 3:
                        contDs++;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine($"MUITO OBRIGADO \nAlcool: {contAl} \nGasolina: {contGs} \nDiesel {contDs}");

        }
    }
}
