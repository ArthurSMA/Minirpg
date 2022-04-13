namespace Minirpg.Entities
{
    public class Escolhaum
    {
        public Escolhaum()
        {
            Console.WriteLine("Olá guerreiro! Temos um missão para você");
            Console.WriteLine("Mostre que tu é brabo!");
            Console.Write("→ [press S]  ");
            string VouMostrar = Console.ReadLine();
            if(VouMostrar == "S" ||VouMostrar == "s")
            {
                PrimeiroMobG p1 = new PrimeiroMobG();
            }else
            {
                Console.WriteLine("Ta tirando 0 6 ?");
                System.Console.WriteLine("Bora tentar de novo!");
                Escolhaum e1 = new Escolhaum();
            }

            
        }
    }
}