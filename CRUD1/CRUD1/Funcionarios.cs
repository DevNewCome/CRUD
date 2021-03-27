using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD1
{
    abstract class Funcionarios 
    {

        public string nome { get; set; } // get = devolve o valor par aquem chama, set = lê o dado e guarda o valor

        public string telefone;

        public string endereco;

        public string cpf;
       
        public string cargo;

        
    }
}
