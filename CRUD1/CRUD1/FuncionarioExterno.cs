using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD1
{
    class FuncionarioExterno: Funcionarios, Idados
    {


        private int diastrabalhados;
        private double salbas = 1200;
        private double totalreceber;

        public FuncionarioExterno(string nome, string telefone, string endereco, string cpf, string cargo )
        {
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
            this.cpf = cpf;
            this.cargo = cargo;
        }

        public FuncionarioExterno()
        {

        }

      

        public void Exibir()
        {

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Telefone: " + telefone);
            Console.WriteLine("Endereco: " + endereco);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Salario Base: " + salbas);
            Console.WriteLine("Dias trabalhados: " + diastrabalhados);
            Console.WriteLine("Total a receber: " + totalreceber);
            Console.WriteLine();
            
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Dias trabalhadados");
            int diastrab = int.Parse(Console.ReadLine());
            diastrabalhados = diastrab;
            Console.WriteLine("Dias contabilizados com sucesso");
            Console.ReadLine();

        }

        void Idados.Pagamento()
        {
            Console.WriteLine("Informe o valor por dia trabalhado");
            double horastrabalhadas = double.Parse(Console.ReadLine());
            totalreceber = salbas + (diastrabalhados * horastrabalhadas);
            
        }
    }
}
