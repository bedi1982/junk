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
                    //Tenho que criar variaveis porque não consigo usar o objeto//
                    //FolhaNegocios antes recebia um objeto, agora recebe variaveis, bad//
                    string nome;
                    int mes, ano;

                    Console.WriteLine("\nMês: ");
                    mes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ano: ");
                    ano = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nome: ");
                    //#####
                    nome = Console.ReadLine();
                    //Console.WriteLine("SAIDA: " + tmp.funcionario.Cpf);
                    //######
                    //Enviando variaveis, porque nao posso enviar o objeto folha //
                    //e no método chamar, por ex, folha.funcionario.nome //?
                    tmp = FolhaNegocios.VerificaDataUsuario(nome, mes, ano);
                    if (tmp != null)
                    {
                        float bruto = FuncionarioNegocios.CalcularSalarioBruto(tmp.ValorDaHora, tmp.HorasTrabalhadas);
                        Console.WriteLine("Bruto: " + bruto);
                        Console.WriteLine("IR: " + FuncionarioNegocios.CalcularIR(bruto));
                        Console.WriteLine("INSS: " + FuncionarioNegocios.CalcularINSS(bruto));
                        Console.WriteLine("FGTS: " + FuncionarioNegocios.CalcularFGTS(bruto));
                        Console.WriteLine("Liquido: " + FuncionarioNegocios.CalcularSalarioLiquido(bruto, FuncionarioNegocios.CalcularINSS(bruto), FuncionarioNegocios.CalcularFGTS(bruto)));
                    }
                    else
                    {
                        Console.WriteLine("\nEste preguiçoso não trabalhou neste mês");
                    }
                    break;

                case 4:
                    //Bloco de testes
                    float TotalSalarios = 0;

                    Console.WriteLine("\nMês: ");
                    mes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ano: ");
                    ano = int.Parse(Console.ReadLine());

                    foreach (Folha x in FolhaCollection.GetFolhas())
                    {
                        if (x.mes.Equals(mes) && x.ano.Equals(ano))
                        {
                            Console.WriteLine("Nome: " + x.funcionario.nome);
                            //Xunxo
                            float bruto = FuncionarioNegocios.CalcularSalarioBruto(x.ValorDaHora, x.HorasTrabalhadas);
                            float liquido = FuncionarioNegocios.CalcularSalarioLiquido(bruto, FuncionarioNegocios.CalcularINSS(bruto), FuncionarioNegocios.CalcularFGTS(bruto));
                            TotalSalarios += liquido;
                        }
                    }
                    if (TotalSalarios == 0) {
                        Console.WriteLine("Nenhum folha encontrada");
                    }else{
                    Console.WriteLine("Liquido no mês: " + TotalSalarios);
                    }
                    break;
            }
        }

        static int MostraMenu()
        {
            int opcao;
            Console.WriteLine("\n1 - Cadastro de funcionário");
            Console.WriteLine("2 - Cadastro da folha");
            Console.WriteLine("3 - Consultar folha(mes, ano e nome do func)");
            Console.WriteLine("4 - Listar todas as folhas(folhas, não funcionarios)");
            Console.WriteLine("5 - Sair");
            opcao = int.Parse(Console.ReadLine());
            return opcao;
        }
    }
}
