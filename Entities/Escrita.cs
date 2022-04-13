namespace Minirpg.Entities
{
    public class Escrita
    {
        public string Texto { get ; set;}

        public Escrita(string texto)
        {
            Texto = texto;
        }
        public void EscritaTela()
        {
            char[] arrayText = Texto.ToCharArray();

            foreach ( char letra in arrayText)
            {
                Thread.Sleep(20);
                Console.Write(letra);
            }
        }
    }
}