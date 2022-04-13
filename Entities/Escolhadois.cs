namespace Minirpg.Entities
{
    public class Escolhadois
    {
        public Escolhadois()
        {
            Console.WriteLine("Olá mago! Temos uma missão para você!");
            Console.WriteLine("Boa sorte lek! Duvido você conseguir enfrentar essa jornada!");
            
            char escolha = char.Parse(Console.ReadLine());
            if(escolha == 'S' || escolha == 's')
            {

            }
            else if(escolha == 'N' || escolha == 'n' )
            {

            }
            else
            {
                Console.WriteLine("Invalido! Tente outra vez!");
                Escolhadois e2 = new Escolhadois();
            }
        }
    }
}