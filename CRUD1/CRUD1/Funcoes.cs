using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CRUD1
{
    class Funcoes
    {

        public Funcoes()
        {

        }
      
        public List <Idados> lista = new List<Idados>();

        public void Listagem()
        {
            Console.WriteLine("Lista de produtos");
            int i = 0;
                foreach(Idados dados in lista)
            {
                Console.WriteLine("ID " + i);
                dados.Exibir();
                i++;
            }
            Console.ReadLine();
            
        }

        public void Cadastro()
        {
            Console.WriteLine("Cadastro de funcionarios");
            Console.WriteLine("1-funcionario externo\n2-funcionario interno");
            string optStr = Console.ReadLine();
            int optInt = int.Parse(optStr);

                switch (optInt)
            {
                case 1:
                    CadastroFuncionarioExterno();
                        break;
                case 2:
                    CadastroFuncionarioInterno();
                        break;
            }
        }

        public void CadastroFuncionarioExterno()
        {
            Console.WriteLine("Cadastro de funcionario");
            Console.WriteLine();
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("endereco: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("cpf: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("cargo: ");
            string cargo = Console.ReadLine();
            FuncionarioExterno f = new FuncionarioExterno(nome, telefone, endereco, cpf, cargo);
            lista.Add(f);
            Console.WriteLine("Cadastro feito com sucesso");
        }

        public void CadastroFuncionarioInterno()
        {
            Console.WriteLine("Cadastro de funcionario");
            Console.WriteLine();
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("endereco: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("cpf: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("cargo: ");
            string cargo = Console.ReadLine();
            FuncionarioInterno fi = new FuncionarioInterno(nome, telefone, endereco, cpf, cargo);
            lista.Add(fi);
            Console.WriteLine("Cadastro feito com sucesso");
        }

        public void Remover()
        {

            Listagem();
            Console.WriteLine("Digite o ID do elemento que você deseja remover");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < lista.Count)
            {
                lista.RemoveAt(id);
            }
        }

        public void Entrada()
        {
            Listagem();
            Console.WriteLine("Digite o ID do funcionario para registrar os dias trabalhados");
            int id = int.Parse(Console.ReadLine());
             if (id >= 0 && id < lista.Count)
            {
                lista[id].AdicionarEntrada();
            }
            Console.WriteLine("Digite o ID do funcionario para realizar o pagamento");
            int id1 = int.Parse(Console.ReadLine());
            if (id1 >= 0 && id1 < lista.Count)
            {
                lista[id1].Pagamento();
            }
        }

        public void Pagamento()
        {
            Listagem();
            Console.WriteLine("Digite o ID do funcionario para realizar o pagamento");
            int id = int.Parse(Console.ReadLine());
                if (id >= 0 && id < lista.Count)
            {
                lista[id].Pagamento();
            }
        }

    }
}
