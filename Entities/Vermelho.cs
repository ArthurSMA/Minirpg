namespace Minirpg.Entities
{
    public class Vermelho : Escrita
    {    
        public Vermelho(String texto) : base(texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            EscritaTela();
            Console.ResetColor();
        }
    }
}