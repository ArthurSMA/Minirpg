namespace Minirpg.Entities
{
    public class Amarelo : Escrita
    {
        public Amarelo(String texto) : base(texto)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            EscritaTela();
            Console.ResetColor();
        }
    }
    
}