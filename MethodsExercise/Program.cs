namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Should we make a story about you?");
            Thread.Sleep(1000);
            string name = getName();
            string animal = getAnimal();
            string color = getColor();
            string band = getBand();


            Console.WriteLine($"There once was a person named {name.ToUpper()}! {name.ToUpper()}'s favorite animal was {animal}. {name.ToUpper()} liked color {color}.{name.ToUpper()}'s favorite band was {band.ToUpper()}.");
            getAge();
            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give another number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to multiply ");
            num2 = int.Parse(Console.ReadLine());
            int product = Multiply(num1, num2);
            Console.WriteLine($"result is {product}");

        }

        static string getName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        static string getAnimal()
        {
            Console.WriteLine("What is your favorite animal?");
            return Console.ReadLine();
        }

        static string getColor()
        {
            Console.WriteLine("What color is your favorite?");
            return Console.ReadLine();
        }

        static string getBand()
        {
            Console.WriteLine("What's your favorite band?");
            return Console.ReadLine();
        }

        static void getAge()
        {
            Console.WriteLine("how old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age > 70)
            { Console.WriteLine("You're an old man"); }
            else
            {
                Console.WriteLine("You're a spring chicken");
            }
        }

        //----EXRCISE 2----------
        static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        }

        static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }

    }
}
