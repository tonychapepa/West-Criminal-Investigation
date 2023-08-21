using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace West
{
    internal class Program
    {
        enum  inimigoPolitico{
            cuba,
            irao
        }
        String nacao = "usa";

       static bool criminiso = false;
       static bool americano = false;
        static bool possuiArma = false;
        static String nome = " ";
        //x=>Americano=West

        enum arma
        {
            bomba,
            missil
        }


       
        static void Main(string[] args)
        {
            Console.WriteLine("SEU NOME");
            nome = Console.ReadLine();
            if(nome == "West") {
                americano = true;
            }
            else
            {
                Console.WriteLine("VOCÊ NÃO É AMERICANO NEM TAO POUCO! Está ");
            }

            if (americano)
            {
                Console.WriteLine("QUAIS ARMAS ELE POSSUIA");
                String armaPossui = Console.ReadLine();

                if(armaPossui == arma.bomba.ToString() || armaPossui ==arma.missil.ToString())
                {
                    possuiArma = true;

                    Console.WriteLine("Qual país você manteve comunicação nesse Período (...)");
                    String pais = Console.ReadLine();

                    if(pais == inimigoPolitico.cuba.ToString() || pais == inimigoPolitico.irao.ToString())
                    {
                        criminiso=true;
                        Console.WriteLine("EXISTE UM MISSIL VENDIDO POR UM AMERICANO");
                        Console.Write(nome +" Vendeu "+armaPossui+ " para o pais de nome " +pais);
                       
                    }
                    else
                    {
                        Console.WriteLine(" O/A " + nome + " Apenas possui as armas");
                    }
                }
                
            }
         
            else
            {
                Console.WriteLine("O/A " + nome + " não é Criminoso!");
                Console.WriteLine("Não tem relação com um dos paises inimigos!");
            }
        }
    }
}
