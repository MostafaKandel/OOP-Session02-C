namespace OOP_Session02_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            // Person struct
            Person[] people = new Person[3];
            people[0] = new Person("MOSTAFA", 30);
            people[1] = new Person("AHMED", 25);
            people[2] = new Person("MAHMOUD", 35);

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }


            #endregion
        }
    }
}
