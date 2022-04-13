namespace Game.Entities
{
    public class TelaInicio
    {
        public TelaInicio()
        {
            Console.WriteLine("→ Jogar [j] ");
            Console.WriteLine("→ Sair [s]");
            Console.WriteLine("-------------------------------------------");
            Console.Write("→ ");
            char option = char.Parse(Console.ReadLine());
            switch(option)
            {
                case 'J':
                    Console.Clear();
                    TelaPlay play = new TelaPlay();                    
                    break;
                case 'j':
                    Console.Clear();
                    TelaPlay iniciar = new TelaPlay();                    
                    break;
                case 'S':
                    Console.Clear();
                    Environment.Exit(0);                    
                    break;
                case 's':
                    Console.Clear();  
                    Environment.Exit(0);                
                    break;
            }
        }
    }
}