namespace ConsoleOOPTraining
{
    internal interface IFigura
    {
        void ObliczPole();
        void ObliczObwod();
    }

    public class Kwadrat : IFigura
    {

        public int BokA { get; set; }
        public Kwadrat(int bok)
        {
            BokA = bok;
        }

        public void ObliczPole()
        {
            Console.WriteLine("Pole kwadratu wynosi: " + BokA * BokA);
        }

        public void ObliczObwod()
        {
            Console.WriteLine("Obwod kwadratu wynosi: " + 4 * BokA);
        }

    }

    public class Kolo : IFigura
    {
        public int Promien { get; set; }
        public readonly double Pi = 3.14;

        public Kolo(int promien)
        {
            Promien = promien;
        }

        public void ObliczPole()
        {
            Console.WriteLine("Pole koła wynosi: " + (Pi * Math.Pow(Promien, 2)));
        }

        public void ObliczObwod()
        {
            Console.WriteLine("Obwod koła wynosi: " + 2 * (Pi * Promien));
        }
    }

}

