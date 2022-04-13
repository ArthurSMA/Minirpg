using Minirpg.Entities;

namespace Minirpg.Entities
{
    public class HabilidadeGuerreiro
    {
        public HabilidadeGuerreiro()
        {
            string texto = " Ataque Rapido[1] Investida[2] Descansar[3]";
            Azul ea = new Azul(texto);
            System.Console.WriteLine();
                        
            int habilidade = int.Parse(Console.ReadLine());
                        
            switch(habilidade)
            {
                case 1 : 
                    Console.WriteLine();                                         
                    string menos = "-10 de energia";
                    Vermelho m = new Vermelho(menos);
                    Console.WriteLine();                    
                    Console.WriteLine("Você tirou 10 de vida do seu inimigo");
                    Console.WriteLine("Agora o Lobo-de-raio só possui 15 de vida!");
                    Console.WriteLine("Você perdeu 10 de escudo após receber um ataque rápido");                                        
                break;
                
                case 2 : 
                    Console.WriteLine();
                    string menose = "-50 de energia";
                    Vermelho me = new Vermelho(menose);
                    Console.WriteLine();
                    string ama = "Você tirou 40 de vida do seu inimgo";
                    Amarelo a = new Amarelo(ama);
                    Console.WriteLine();
                    string am = "Parabéns! Você derrotou seu primeiro inimigo!";
                    Amarelo aa = new Amarelo(am);

                break;

                case 3:
                    Console.WriteLine("Você descansou! Sua energia agora está em 100");                    
                break;
            }
        }
    }
}