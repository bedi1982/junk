using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPagamentoQuinta
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 6;
            while (opcao != 5)
            {
                opcao = MostraMenu();

                if (opcao != 5)
                {
                    EscolhaMenu(opcao);
                }
            }
        }

        static void EscolhaMenu(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Funcionario funcionario = new Funcionario();

                    Console.WriteLine("Nome do Func");
                    funcionario.nome = Console.ReadLine();

                    Console.WriteLine("CPF do Func");
                    funcionario.Cpf = Console.ReadLine();

                    FuncionarioCollection.Insert(funcionario);
                    break;

                case 2:
                    Console.WriteLine("Digite o CPF do funcionario)");
                    string cpf = Console.ReadLine();
                    //######################################################
                         //Consultar professor sobre esse xunxo
                    if (FuncionarioNegocios.ConsultaSeJaTemCPFCadastrado(cpf) != null)
                    { //retorna true se ja tem o cpf
                        Folha folhas = new Folha();
                        folhas.funcionario = FuncionarioNegocios.ConsultaSeJaTemCPFCadastrado(cpf);
                        //Consultar professor sobre esse xunxo 
                        //(chamando duas vezes: FuncionarioNegocios.ConsultaSeJaTemCPFCadastrado(cpf));
                   //######################################################

                        Console.WriteLine("CPF numero " + cpf + " pertence a: " + folhas.funcionario.nome);

                        Console.WriteLine("Ano atual: ");
                        folhas.ano = int.Parse(Console.ReadLine());

                        Console.WriteLine("Mês atual: ");
                        folhas.mes = int.Parse(Console.ReadLine());

                        //Se a data for invalida, nem pergunte os outros dados//
                        if (FolhaNegocios.ValidaData(folhas))
                        {
                            Console.WriteLine("Item já cadastrado nesta data, voltando ao menu...");
                        }
                            //Se a data for valida, pergunta os outros dados e adiciona o objeto a lista
                        else
                        {
                            Console.WriteLine("Horas Trabalhadas no mês: ");
                            folhas.HorasTrabalhadas = int.Parse(Console.ReadLine());

                            Console.WriteLine("Custo da hora trabalhada: ");
                            folhas.ValorDaHora = float.Parse(Console.ReadLine());

                            FolhaCollection.Insert(folhas);
                        }

                    }
                    else
                    {
                        Console.WriteLine("\nEste funcionário não está cadastrado.\n");
                    }
                    break;

                case 3:

                    Folha tmp = new Folha();

                        Console.WriteLine("Mês: ");
                        tmp.mes = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ano: ");
                        tmp.ano = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Nome: ");
                    //#####
                        Console.WriteLine("TESTE: " + tmp.funcionario.nome);
                        tmp.funcionario.nome = Console.ReadLine();
                    //######

                        if (FuncionarioNegocios.VerificaData(tmp) != null) {
                            tmp = FuncionarioNegocios.VerificaData(tmp);
                            Console.WriteLine(tmp);
                        }
                    break;

                case 4:
                    //Bloco de testes
                    foreach (Folha x in FolhaCollection.GetFolhas())
                    {
                        Console.WriteLine("\n\nNome: " + x.funcionario.nome);
                        Console.WriteLine("CPF: " + x.funcionario.Cpf);
                        Console.WriteLine("Ano: " + x.ano);
                        Console.WriteLine("Mes: " + x.mes);
                        Console.WriteLine("Horas Trabalhadas: " + x.HorasTrabalhadas);
                        Console.WriteLine("Valor da hora: " + x.ValorDaHora + "\n");
                    }

                    //Console.ReadKey();
                    //Bloco de testes

                    break;
            }
        }

        static int MostraMenu()
        {
            int opcao;
            Console.WriteLine("1 - Cadastro de funcionário");
            Console.WriteLine("2 - Cadastro da folha");
            Console.WriteLine("3 - Consultar folha");
            Console.WriteLine("4 - Listar folha");
            Console.WriteLine("5 - Sair");
            opcao = int.Parse(Console.ReadLine());
            return opcao;
        }
    }
}
