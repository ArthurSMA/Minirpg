namespace Minirpg.Entities
{
    public class Azul : Escrita
    {    
        public Azul(String texto) : base(texto)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            EscritaTela();
            Console.ResetColor();
        }
    }
}