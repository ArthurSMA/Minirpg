namespace Minirpg.Entities
{
    public class TelaInicio
    {
        public TelaInicio()
        {
            string j = "→ Jogar [j] ";
            string s = "→ Sair  [s]";
            Azul am = new Azul(j);
            Console.WriteLine();
            Azul ama = new Azul(s);
            Console.WriteLine(); 
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