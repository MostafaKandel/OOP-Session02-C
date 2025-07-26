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
            #endregion

        }
    }
}
