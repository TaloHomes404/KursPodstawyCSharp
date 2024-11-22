namespace Biblioteka
{
    public class GradeManager
    {

        List<int> gradesList = new List<int>();

        Dictionary<string, List<int>> gradeDictionary = new Dictionary<string, List<int>>();

        public void AddGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody AddGrade, aby dodawała nową ocenę do listy ocen ucznia.
            if (gradeDictionary.ContainsKey(studentName)) { gradeDictionary[studentName].Add(grade); }
            else { Console.WriteLine("Nie znaleziono takiego studenta"); }


        }

        public void RemoveGrade(string studentName, int grade)
        {
            // TODO: Uzupełnij implementację metody RemoveGrade, aby usuwała ocenę z listy ocen ucznia, jeśli istnieje.
            if (gradeDictionary.ContainsKey(studentName)) { gradeDictionary[studentName].Remove(grade); }

        }

        public double CalculateAverageGrade(string studentName)
        {
            // TODO: Uzupełnij implementację metody CalculateAverageGrade, aby obliczała średnią ocen ucznia, jeśli istnieją oceny.
            if (gradeDictionary.ContainsKey(studentName)) { return gradeDictionary[studentName].Average(); }
            else return -1;

            //

        }
    }
}
