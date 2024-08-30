using CadastroFuncionarios.dao;
using CadastroFuncionarios.Models;
using System.Runtime.CompilerServices;

namespace CadastroFuncionarios
{
    internal class Program
    {

        static void Main(string[] args)
        {

            try
            {
                Conexao.Conectar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar:" + ex.Message);
            }

            bool chamarMenu = true;
            while (chamarMenu)
            {
                chamarMenu = Menu();
            }

        }

        private static bool Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CADASTRO DE FUNCIONÁRIOS");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Escolha um opção: ");
            Console.WriteLine("1) Digite 01 - Cadastrar funcionário no banco de dados. ");
            Console.WriteLine("2) Digite 02 - Gerar lista de funcionários. ");
            Console.WriteLine("3) Digite 03 - Deletar funcionário do banco de dados. ");
            Console.WriteLine("4) Digite 04 - Alterar funcionário. ");
            Console.WriteLine("5) Digite 05 - Sair da aplicação. ");

            string resp = Console.ReadLine();

            switch (resp)
            {
                case "01":
                    Opcao1();
                    return true;
                    break;

                case "02":
                    Opcao02();
                    return true;
                    break;

                case "03":
                    Opcao03();
                    return true;
                    break;

                case "04":
                    Opcao04();
                    return true;
                    break;

                case "05":
                    Console.WriteLine("Você saiu da aplicação! ");
                    return false;
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente. ");
                    Console.ReadLine();
                    return true;
            }

        }
        private static void Opcao1()
        {
            /*insert*/
            Console.Clear();
            Funcionario funcionario01 = new Funcionario();
            Console.WriteLine("Você escolheu a opção 01");
            Console.WriteLine();
            Console.WriteLine("Digite o nome do funcionario: ");
            funcionario01.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF: ");
            funcionario01.Cpf = Console.ReadLine();


            FuncionarioDAO f1 = new FuncionarioDAO();
            f1.Insert(funcionario01);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Digite qualquer tecla para retornar ao menu...");
            Console.ReadKey();
            Console.ResetColor();
        }

        private static void Opcao02()
        {
            Console.Clear();

            FuncionarioDAO f1 = new FuncionarioDAO();
            /* gerar lista*/
            Console.WriteLine("Você escolheu a opção 02");
            Console.WriteLine();

            List<Funcionario> lista = f1.List();
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("ID_Funcionario: ");
                Console.ResetColor();

                Console.Write(item.IdFuncionario);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("  Nome_Funcionario: ");
                Console.ResetColor();
                Console.Write(item.Nome);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("  CPF_Funcionario: ");
                Console.ResetColor();

                Console.Write(item.Cpf);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Digite qualquer tecla para retornar ao menu...");
            Console.ReadKey();
            Console.ResetColor();
        }

        private static void Opcao03()
        {
            Console.Clear();
            try
            {
                FuncionarioDAO f1 = new FuncionarioDAO();
                List<Funcionario> lista = f1.List();
                /*delete*/
                Console.WriteLine("Você escolheu a opção 03");
                Console.WriteLine();
                Console.WriteLine("Digite o ID que deseja deletar do banco de dados: ");
                var idfunc = Convert.ToInt32(Console.ReadLine());

                if (idfunc == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Nenhum funcionário encontrado com o ID fornecido.");
                    Console.ReadKey();
                    Console.ResetColor();

                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Tem certeza que deseja deletar o funcionário com o ID: {idfunc}?");
                Console.WriteLine("Digite (Sim) para confirmar");
                Console.WriteLine("Digite (Não) para cancelar");

                Console.ResetColor();
                string resp = Console.ReadLine();
                resp = resp.ToUpper();
                switch (resp)
                {
                    case "SIM":
                        f1.Delete(lista.Find(x => idfunc == x.IdFuncionario));
                        break;
                    case "NÃO":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Opção cancelada com sucesso!");
                        Console.ResetColor();
                        Console.ReadKey();
                        Opcao03();
                        break;

              

                        default:
                        Console.WriteLine();
                        Console.ForegroundColor= ConsoleColor.DarkRed;
                        Console.WriteLine("Você digitou algo errado, tente novamente");
                        Console.ResetColor();
                        Console.ReadKey();
                        Opcao03();
                        break;
                }

             
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro: " + ex.Message);
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Digite qualquer tecla para retornar ao menu...");
            Console.ResetColor();
            Console.ReadKey();
        }

        private static void Opcao04()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Você escolheu a opção 04");
                Console.WriteLine();
                FuncionarioDAO f1 = new FuncionarioDAO();
                List<Funcionario> lista = f1.List();

                Console.WriteLine("Digite o ID do funcionário no qual deseja fazer o Update: ");
                var idfunci = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                var verificacao = lista.Find(x => idfunci == x.IdFuncionario);

                if (verificacao == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Nenhum funcionário encontrado com o ID fornecido.");
                    Console.ReadKey();
                    Console.ResetColor();
                    return;
                }

                Console.WriteLine("O que deseja alterar? (Escolha uma opção)");
                Console.WriteLine("1) Digite 01 - Alterar o Nome e CPF do funcionário");
                Console.WriteLine("2) Digite 02 - Alterar somente o Nome do funcionário");
                Console.WriteLine("3) Digite 03 - Alterar somente o CPF do funcionário");
                string resp = Console.ReadLine();
                Console.WriteLine();
                switch (resp)
                {
                    case "01":
                        Console.WriteLine("Digite o novo nome do funcionário: ");
                        verificacao.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o novo CPF do funcionário: ");
                        verificacao.Cpf = Console.ReadLine();
                        break;

                    case "02":
                        Console.WriteLine("Digite o novo nome do funcionário: ");
                        verificacao.Nome = Console.ReadLine();
                        break;

                    case "03":
                        Console.WriteLine("Digite o novo CPF do funcionário: ");
                        verificacao.Cpf = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente. ");
                        Console.ReadLine();
                        break; 
                }
                f1.Update(verificacao);

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Erro: " + ex.Message);
            }
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Digite qualquer tecla para retornar ao menu...");
            Console.ResetColor();

            Console.ReadKey();


        }
    }
}