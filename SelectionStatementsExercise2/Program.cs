namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type your favorite subject in school");
            var userInput=Console.ReadLine();

            switch(userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("math is my favorite as well)) i love how its not subjective!");
                    break;

                case "science":
                    Console.WriteLine("science is pretty cool. seems like people do a lot of stuff with it");
                    break;

                case "history":
                    Console.WriteLine("history is very interesting! i do wonder though if it ought to be pursued as a career");
                    break;

                case "writing":
                    Console.WriteLine("this is a great subject! the power of the written word is incredible");
                    break;

                case "physical education":
                case "pe":
                    Console.WriteLine("it is very important to stay healthy and strong! good choice");
                    break;

                default: Console.WriteLine("That sounds interesting i will have to look into that");
                    break;
            }
        }
    }
}