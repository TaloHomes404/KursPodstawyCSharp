namespace Kolekcje
{
    internal class ListaObecnosci
    {

        List<int> listaObecnosci = new List<int>();


        public void DodajObecnosc(int numer)
        {
            listaObecnosci.Add(numer);
            Console.WriteLine($"Dodano do listy numer: {numer}");
        }

        public void UsunObecnosc(int numer)
        {
            listaObecnosci.Remove(numer);
            Console.WriteLine($"Usunięto z listy numer: {numer}");
        }

        public List<int> WypiszListeObecnosci()
        {
            return listaObecnosci;
        }

    }
}
