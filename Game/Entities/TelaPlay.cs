namespace Game.Entities
{
    public class TelaPlay
    {
        public TelaPlay()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("     ↓ Selecione o seu personagem ↓ ");
            Console.WriteLine("-------------------------------------------");
            Console.Write("│ > Guerreiro[G] < ");
            Console.Write("    │ ");
            Console.WriteLine("     > Mago[M] < │");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Info. dos personagens pressione a tecla [i]");
            Console.WriteLine("-------------------------------------------");
            Console.Write("→ ");

            char prota = char.Parse(Console.ReadLine());
            
            switch(prota)
            {
                case 'G':
                    Console.Clear();
                    Escolhaum eum = new Escolhaum();
                    break;
                
                case 'g':
                    Console.Clear();
                    Escolhaum e1 = new Escolhaum();
                    break;

                case 'M':
                    Console.Clear();
                    Escolhadois edois = new Escolhadois();
                    break;

                case 'm':
                    Console.Clear();
                    Escolhadois e2 = new Escolhadois();
                    break;
                
                case 'i': 
                    Console.Clear();                   
                    Info i = new Info();
                    break;

                case 'I': 
                    Console.Clear();                   
                    Info inf = new Info();
                    break;
            }
        }
    }
}