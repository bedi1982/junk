using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPagamentoQuinta
{
    class FuncionarioNegocios
    {
        public static Funcionario ConsultaSeJaTemCPFCadastrado(string cpf) {
            foreach (Funcionario x in FuncionarioCollection.GetFuncionarios())
            {
                if (x.Cpf.Equals(cpf))
                {
                    //Console.WriteLine("tem"); //teste status
                    return x;
                }
            }
            return null; //Nao tem :P
        }
        
        //##############Abaixo algoritmo colados#############//
        public static float CalcularIR(float bruto) {
            if (bruto <= 1372.81){
                return 0;
            }else{
                if (bruto <= 2743.25){
                    return (float)((bruto * .15) - 205.92);
                }else{
                    return (float)((bruto * .275) - 548.82);
                }
            }
        }



        public static float CalcularINSS(float bruto){
            if (bruto <= 868.29){
                return (float)(bruto * 0.08);
            }else{
                if (bruto <= 1447.14)
                {
                    return (float)(bruto * 0.09);
                }else{
                    if (bruto <= 2894.28)
                    {
                        return (float)(bruto * 0.11);
                    }else{
                        return (float)318.37;
                    }
                }
            }
        }


        public static float CalcularFGTS(float bruto) {
            return (float)(bruto * 0.08);
        }



        public static float CalcularSalarioLiquido(float bruto, float inss, float fgts)
        {
            return (bruto - inss - fgts);
        }

        public static float CalcularSalarioBruto(float liquido, int trabalhadas)
        {
            return liquido * trabalhadas;
        }
    }
}
