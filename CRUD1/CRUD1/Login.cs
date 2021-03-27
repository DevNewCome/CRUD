using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD1
{
    class Login
    {
        public string login;
        public string senha;


        public Login()
        {
       

        }

        public Login (string login, string senha)
        {
            this.login = login;
            this.senha = senha;

        }

        public void Autenticacao()
        {
           
            bool entrou = false; //autenticando entrada caso esteja invalida, retornara
            while (entrou == false)
            {
                Console.WriteLine("Digite o login");
                string login = Console.ReadLine();
                Console.WriteLine("Digite a senha");
                string senha = Console.ReadLine();
                Login p = new Login(login, senha);

                if (p.login == "jefferson" && p.senha == "123")
                {

                   // entrou = true;
                    Console.Clear();
                    Console.WriteLine("Login efetuado com sucesso");
                    Console.WriteLine();
                    Menu m = new Menu();
                    m.menu();

                }
                else
                {
                    
                    Console.WriteLine("Usuário inválido, tente novamente ");
                
                  
                    Console.ReadKey();
                    
                }
                
                Console.Clear();

            }

           /* Console.WriteLine("Digite o login");
            string login = Console.ReadLine();
            Console.WriteLine("Digite a senha");
            string senha = Console.ReadLine();
            Login p = new Login(login, senha);



                if (p.login == "jefferson" && p.senha == "123")
            {
                Menu m = new Menu();
                m.menu();

            } else
            {
                Console.WriteLine("Usuario inválido");
            }*/
        }
    }
}
