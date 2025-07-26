namespace OOP_Session02_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            // Person struct
            /*
            Person[] people = new Person[3];
            people[0] = new Person("MOSTAFA", 30);
            people[1] = new Person("AHMED", 25);
            people[2] = new Person("MAHMOUD", 35);

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            */


            #endregion

            #region question 2
            // PoINTS
            /*
            Console.Write("please enter X for P1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter Y for P1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter X for P2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter Y for P2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            Console.WriteLine($"the Distance between P1 and P2 is: {Point.CaluculateDistance(p1,p2)}");
            */
            #endregion


            #region question 3
            // arrray of Persons

            Person[] people = new Person[3];

            for (int i = 0; i < people.Length; i++)
            {
                Console.Write($"Enter name for person{i+1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter age for person{i + 1}: ");
                bool isParsed= int.TryParse(Console.ReadLine(), out int age);
                while (!isParsed)
                {
                    Console.WriteLine("Invalid age input. Please enter a valid integer.");
                    Console.Write($"Enter age for person {i + 1}: ");
                    isParsed = int.TryParse(Console.ReadLine(), out age);

                }
                people[i] = new Person(name, age);
            }

            Person oldestPerson = people[0];
            foreach (Person person in people)
            {
                if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }
            Console.Write("the oldest person: ");
            Console.WriteLine(oldestPerson.ToString());

            #endregion
        }
    }
}
