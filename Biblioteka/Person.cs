namespace Biblioteka
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }



        public Person(int age, string name, string surname, DateTime birthDate, string phoneNumber)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
        }

        public DateTime GetBirthDate()
        {
            return this.BirthDate;
        }

        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public void sayHiPerson()
        {
            Console.WriteLine($"Hello my name is {this.Name} and im {this.Age} years old.");
        }

    }
}
