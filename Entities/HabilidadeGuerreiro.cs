namespace Game.Entities
{
    public class HabilidadeGuerreiro
    {
        public HabilidadeGuerreiro()
        {
            Console.WriteLine("[1] - Ataque Rapido");
            Console.WriteLine("[2] - Investida");
            Console.WriteLine("[3] - Descansar");
            Console.WriteLine("---------------");
            int habilidade = int.Parse(Console.ReadLine());
            switch(habilidade)
            {
                case 1 :
                    Delay dl = new Delay();     
                    Console.WriteLine("-10 de energia");
                    Console.WriteLine("Você tirou 10 de vida do seu inimigo");
                    Console.WriteLine("Agora o Lobo-de-raio só possui 15 de vida!");
                    Console.WriteLine("Você perdeu 10 de escudo após receber um ataque rápido");                    
                break;
                
                case 2 : 
                    Console.WriteLine("-50 de energia");
                    Console.WriteLine("Você tirou 40 de vida do seu inimgo");
                    Console.WriteLine("Você eliminou o Lobo-de-raio!");
                break;

                case 3:
                    Console.WriteLine("Você descansou! Sua energia agora está em 100");                    
                break;
            }
        }
    }
}