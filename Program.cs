using System;


namespace calculadora
{
    class Faz_numero()
    {
        public int numero()
        {
            Console.Write("digite um numero 1 :");
            return Convert.ToInt32(Console.ReadLine());   
        }

        public int recebi_numero{get =>  numero(); }

        public int numero2()
        {
            Console.Write("digite um numero 2 :");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int recebi_numero2 {get => numero2();}
    }

    class configuração_numericas:Faz_numero
    {

        public void soma(int numero, int numero2)
        {
            Console.Write(numero+ numero2);
            Console.ReadKey();
        }


        public void multiplicação(int numero, int numero2)
        {
            Console.Write(numero * numero2);
            Console.ReadKey();
        }

        
        public void diminuição(int numero, int numero2)
        {
            
            Console.Write(numero-numero2);
            Console.Read();
        }

        
        public void divisão(int numero, int numero2)
        {
            if (numero2 != 0)
            {
                Console.WriteLine(numero/numero2);
            }
            else
            {
                Console.Write("algo deu errado");
            }
        }

    }

    class Resultado:configuração_numericas
    {

        static void Main(string[] args)
        {
             configuração_numericas caracteres = new configuração_numericas();
            
            int numero, numero2;
            
            Faz_numero num = new Faz_numero();
            
            numero = num.recebi_numero;
            numero2 = num.recebi_numero2;

            

            Console.Write("digite um dos numeoros para fazer seu calculo\n1 se quer soma\n2 se quer multiplicação\n3 se quer diminuisão\n4 se quer divisão\ndigite: ");
            int escolhas = Convert.ToInt32(Console.ReadLine());


            switch(escolhas)
            {
                case 1 : caracteres.soma(numero,numero2); break;
                case 2 : caracteres.multiplicação(numero,numero2); break;
                case 3 : caracteres.diminuição(numero,numero2); break;
                case 4 : caracteres.divisão(numero,numero2); break;
                default:
                 Console.Write("ERRO"); break;
            } 
             
        }

    }
}