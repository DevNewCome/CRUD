using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD1
{
    class Menu
    {
        Funcoes f = new Funcoes();
        enum MenuLista { Listar = 1 , Cadastro, Remover, Entrada, Saida, Sair }

    public void menu()
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Gestor de funcionários");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Entrada\n5-Saída\n6-Sair");
                string opStr = Console.ReadLine();
                int optInt = int.Parse(opStr);

                

                if (optInt > 0 && optInt < 7)
                {
                    MenuLista menulista = (MenuLista)optInt;
                    {
                        switch (menulista)
                        {
                            case MenuLista.Listar:
                                f.Listagem();

                                break;

                            case MenuLista.Cadastro:
                                f.Cadastro();

                                break;
                            case MenuLista.Remover:
                                f.Remover();


                                break;
                            case MenuLista.Entrada:
                                f.Entrada();


                                break;
                            case MenuLista.Saida:


                                break;

                            case MenuLista.Sair:
                                escolheuSair = true;

                                break;


                        }
                    }
            
                }  else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }
          
        }


     
    }

    
}
