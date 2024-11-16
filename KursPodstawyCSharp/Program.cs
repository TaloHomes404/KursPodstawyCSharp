using System.Text;

namespace KursPodstawyCSharp;

internal class Program
{
    static void Main(string[] args)
    {

        //Wypisywanie w konsoli (println, print)
        Console.WriteLine("Hello, World!");
        Console.Write("Hello, ");
        Console.Write("World!");

        //Pobieranie od użytkownika input (w tym przypadku stringa)
        //string inputText = Console.ReadLine();

        //Definiowanie typów zmiennych
        //Liczby
        int liczbaInteger = 420;
        byte liczbaByte = 55;
        long liczbaDuza = 60000009;
        float temperatura = 36.6f;
        double pomiar = 0.70000001;

        //DateTime - Typ zmiennej do definiowania dat (typu NOW)
        DateTime now = DateTime.Now;
        //Obiekt - przedstawienie jakiejś daty
        DateTime dateOfBirth = new DateTime(1990, 8, 15);

        //Zmienne znakowe
        string greeting = "Hello";
        string concatedString = "Hello" + " its " + " me.";
        string textWithVar = $"Pomiar z sensora wskazał wartość: {pomiar}";
        StringBuilder sbLetters = new StringBuilder("1");
        sbLetters.Append("2");
        sbLetters.Append("3");
        sbLetters.Append("4");
        sbLetters.Append("5");
        char letter = 'T';

        //Zmienna logiczna Boolean - bool
        bool theSameText = sbLetters.ToString().Equals(greeting);

        //Komentarze // single line /* */ multi line #region tworzy region do zwinięcia
        #region Test
        //Tutaj region do zwinięcia
        //
        //
        #endregion


        //BMI calculator exercise:
        #region BMICalculator


        //Welcome message and enter user input as bodyweight in kilograms
        Console.WriteLine("Welcome to BMI Calculator! \nPlease enter your bodyweight (in kilograms): ");
        string bodyWeightInput = Console.ReadLine();
        double bodyWeight = double.Parse(bodyWeightInput);

        //User input as height in cm
        Console.WriteLine("Enter your height (in cm): ");
        string heightInput = Console.ReadLine();
        double height = double.Parse(heightInput) / 100;


        double bmi = bodyWeight / (height * height);
        Console.WriteLine("Your BMI value is: " + bmi);



        switch (bmi)
        {
            case < 18.5:
                Console.WriteLine("You're underweight.");
                break;
            case >= 18.5 and < 24.9:
                Console.WriteLine("You're in normal healthy bmi range.");
                break;
            case >= 25 and < 29.9:
                Console.WriteLine("You're in slight overweight.");
                break;
            case >= 30 and < 34.9:
                Console.WriteLine("You're in obese bmi range, try to move more and control your calorie intake");
                break;
            case > 35:
                Console.WriteLine("You're severly obese, make sure you are in calorie deficit \n do at least 6000 steps a day \n reduce sugar intake");
                break;
        }
        #endregion

        //Iterowanie po danych wejsciowych 
        #region exitWithZero

        Console.WriteLine("Please enter numbers (0 - exit): ");
        int sum = 0;
        int max = 0;
        int userInput;

        do
        {
            string userInputText = Console.ReadLine();
            userInput = int.Parse(userInputText);
            Console.WriteLine($"Number entered: {userInput}");
            sum += userInput;
            if (max < userInput) max = userInput;
            if (userInput == 0) Console.WriteLine("Program ");

        }
        while (userInput != 0);

        Console.WriteLine($"Sum of entered numbers is: {sum}");
        Console.WriteLine($"Biggest number entered: {max}");

        #endregion

        //Zadanie operujące na klasie z wartościami ENUM - Gentleman Club
        #region GentlemanCub
        Console.WriteLine("Please enter your gender: \n Male - 1 \n Female - 2 ");
        string genderInputText = Console.ReadLine();
        //Deklarujemy zmienną inputGender typu Gender, następnie z użyciem klasy Enum i metody Parse
        //Zamieniamy wprowadzony przez uzytkownika tekst na znaną nam formę klasy enum (Gender)
        Gender inputGender = (Gender)Enum.Parse(typeof(Gender), genderInputText);

        if (inputGender == Gender.Female) Console.WriteLine("Excuse me, only gentleman's allowed");
        else Console.WriteLine("Welcome Sir.");

        #endregion

        //Zmienne typu null
        int? nullableVal = null;
        //If val is null write empty, otherwise print val
        Console.WriteLine($"Value is: " + (nullableVal.HasValue ? nullableVal : "empty"));

        #region DaysOnThisWorld

        Console.WriteLine("Enter your birthdate (in format day.month.year): ");
        string birthDateInput = Console.ReadLine();
        DateTime birthDate = DateTime.Parse(birthDateInput);
        TimeSpan timeSpan = DateTime.Now - birthDate;
        Console.WriteLine($"You are {timeSpan} days on this world");


        #endregion

    }
}




